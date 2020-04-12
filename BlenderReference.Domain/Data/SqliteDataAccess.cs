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
                    var output = conn.Query<ReferenceKeyModel>("Select * From vGetReferenceKeys", new DynamicParameters());
                    return output.ToList();
                }
            }

        public static void SaveReferenceKey(ReferenceKeyModel refKey)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                int referenceKeyId;
                string sql;
                sql = "insert into ReferenceKey (Description," +
                      "                            ModeTypeId," +
                      "                            AreaTypeId," +
                      "                            CanGrabScaleRotate," +
                      "                            CanRestrictToXYZAxis," +
                      "                            CanEnterNumericValue," +
                      "                            HasScrollWheelFeature," +
                      "                            Comment) " +
                      "values (@Description, " +
                      "        @ModeTypeId" +
                      "        @AreaTypeId" +
                      "        @CanGrabScaleRotate" +
                      "        @CanRestrictToXYZAxis" +
                      "        @CanEnterNumericValue" +
                      "        @HasScrollWheelFeature" +
                      "        @Comment)";

                referenceKeyId = conn.Query<int>(sql, refKey).First();

                conn.Execute(sql, refKey);                

            }
        }



        private static string LoadConnectionString()
        {
            return @"Data Source=.\Data\Blender3DReferenceDb.db;Version=3";
        }
    }
}
