using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Helpers
{
    public static class KoneksiDB
    {
        private static readonly string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=sikopi_dopy;" +
            "Username=postgres;" +
            "Password=faraday";
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
