using System;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriPenjualan : IRepositoriPenjualan
    {
        public string ProsesPembelian(PembelianProduk pembelian)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var dbTransaction = conn.BeginTransaction();

            try
            {
                decimal stokTersedia;
                decimal hargaPerGram;
                string statusHarga;

                string sqlCekProduk = @"
                    SELECT
                        stok_gram,
                        harga_per_gram,
                        status_harga
                    FROM biji_kopi_roasted
                    WHERE id_roasted = @id_roasted
                      AND is_aktif = TRUE
                    FOR UPDATE;
                ";

                using (var cmdCekProduk = new NpgsqlCommand(sqlCekProduk, conn, dbTransaction))
                {
                    cmdCekProduk.Parameters.AddWithValue("@id_roasted", pembelian.IdRoasted);

                    using var reader = cmdCekProduk.ExecuteReader();

                    if (!reader.Read())
                        throw new Exception("Produk roast bean tidak ditemukan.");

                    stokTersedia = Convert.ToDecimal(reader["stok_gram"]);
                    hargaPerGram = Convert.ToDecimal(reader["harga_per_gram"]);
                    statusHarga = reader["status_harga"].ToString() ?? "";
                }

                if (statusHarga != "SIAP_JUAL")
                    throw new Exception("Produk belum siap dijual.");

                if (hargaPerGram <= 0)
                    throw new Exception("Harga produk belum valid.");

                if (pembelian.JumlahGram <= 0)
                    throw new Exception("Jumlah pembelian harus lebih dari 0 gram.");

                if (pembelian.JumlahGram > stokTersedia)
                    throw new Exception("Jumlah pembelian melebihi stok tersedia.");

                decimal subtotal = pembelian.JumlahGram * hargaPerGram;
                string nomorCatatan = BuatNomorCatatan();

                int idPenjualan;

                string sqlPenjualan = @"
                    INSERT INTO penjualan
                    (
                        id_pengguna,
                        nomor_invoice,
                        nama_pelanggan,
                        total_penjualan,
                        tanggal_penjualan,
                        is_aktif
                    )
                    VALUES
                    (
                        @id_pengguna,
                        @nomor_invoice,
                        @nama_pelanggan,
                        @total_penjualan,
                        NOW(),
                        TRUE
                    )
                    RETURNING id_penjualan;
                ";

                using (var cmdPenjualan = new NpgsqlCommand(sqlPenjualan, conn, dbTransaction))
                {
                    cmdPenjualan.Parameters.AddWithValue("@id_pengguna", pembelian.IdPengguna);
                    cmdPenjualan.Parameters.AddWithValue("@nomor_invoice", nomorCatatan);
                    cmdPenjualan.Parameters.AddWithValue("@nama_pelanggan", pembelian.NamaPembeli);
                    cmdPenjualan.Parameters.AddWithValue("@total_penjualan", subtotal);

                    idPenjualan = Convert.ToInt32(cmdPenjualan.ExecuteScalar());
                }

                string sqlDetailPenjualan = @"
                    INSERT INTO detail_penjualan
                    (
                        id_penjualan,
                        id_roasted,
                        jumlah_gram,
                        harga_per_gram,
                        subtotal
                    )
                    VALUES
                    (
                        @id_penjualan,
                        @id_roasted,
                        @jumlah_gram,
                        @harga_per_gram,
                        @subtotal
                    );
                ";

                using (var cmdDetail = new NpgsqlCommand(sqlDetailPenjualan, conn, dbTransaction))
                {
                    cmdDetail.Parameters.AddWithValue("@id_penjualan", idPenjualan);
                    cmdDetail.Parameters.AddWithValue("@id_roasted", pembelian.IdRoasted);
                    cmdDetail.Parameters.AddWithValue("@jumlah_gram", pembelian.JumlahGram);
                    cmdDetail.Parameters.AddWithValue("@harga_per_gram", hargaPerGram);
                    cmdDetail.Parameters.AddWithValue("@subtotal", subtotal);

                    cmdDetail.ExecuteNonQuery();
                }

                string sqlUpdateStok = @"
                    UPDATE biji_kopi_roasted
                    SET stok_gram = stok_gram - @jumlah_gram
                    WHERE id_roasted = @id_roasted
                      AND is_aktif = TRUE;
                ";

                using (var cmdUpdateStok = new NpgsqlCommand(sqlUpdateStok, conn, dbTransaction))
                {
                    cmdUpdateStok.Parameters.AddWithValue("@jumlah_gram", pembelian.JumlahGram);
                    cmdUpdateStok.Parameters.AddWithValue("@id_roasted", pembelian.IdRoasted);

                    int jumlahBaris = cmdUpdateStok.ExecuteNonQuery();

                    if (jumlahBaris == 0)
                        throw new Exception("Gagal mengurangi stok roast bean.");
                }

                string sqlRiwayatStok = @"
                    INSERT INTO riwayat_stok
                    (
                        id_biji_mentah,
                        id_roasted,
                        kategori,
                        arah,
                        jumlah,
                        satuan,
                        referensi,
                        tanggal_riwayat
                    )
                    VALUES
                    (
                        NULL,
                        @id_roasted,
                        @kategori,
                        @arah,
                        @jumlah,
                        @satuan,
                        @referensi,
                        NOW()
                    );
                ";

                using (var cmdRiwayat = new NpgsqlCommand(sqlRiwayatStok, conn, dbTransaction))
                {
                    cmdRiwayat.Parameters.AddWithValue("@id_roasted", pembelian.IdRoasted);
                    cmdRiwayat.Parameters.AddWithValue("@kategori", "ROAST_BEAN");
                    cmdRiwayat.Parameters.AddWithValue("@arah", "KELUAR");
                    cmdRiwayat.Parameters.AddWithValue("@jumlah", pembelian.JumlahGram);
                    cmdRiwayat.Parameters.AddWithValue("@satuan", "gram");
                    cmdRiwayat.Parameters.AddWithValue("@referensi", nomorCatatan);

                    cmdRiwayat.ExecuteNonQuery();
                }

                dbTransaction.Commit();

                return nomorCatatan;
            }
            catch
            {
                dbTransaction.Rollback();
                throw;
            }
        }

        private string BuatNomorCatatan()
        {
            return "CATAT-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff");
        }
    }
}