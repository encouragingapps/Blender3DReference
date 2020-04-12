using BlenderReference.Domain.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using System.Linq;

namespace BlenderReference.Domain.Data
{
    public class SqliteDataAccess
    {
        public static List<ReferenceKeyModel> LoadReferenceKeys()
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = conn.Query<ReferenceKeyModel>("Select * From ReferenceKey", new DynamicParameters());
                    return output.ToList();
                }
            }

        private static string LoadConnectionString()
        {
            return @"Data Source=.\Data\Blender3DReferenceDb.db;Version=3";
        }
    }
}
