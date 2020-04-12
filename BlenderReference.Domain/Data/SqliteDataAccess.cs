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
        const string QUERY_GetAllReferenceKeys = "Select * " +
                                                 "From vGetReferenceKeys";

        const string QUERY_InsertReferenceKey = "insert into ReferenceKey (Description," +
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


        public static List<ReferenceKeyModel> LoadReferenceKeys()
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = conn.Query<ReferenceKeyModel>(QUERY_GetAllReferenceKeys, new DynamicParameters());
                    return output.ToList();
                }
            }

        public static void SaveReferenceKey(ReferenceKeyModel refKey)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                int referenceKeyId;
               
                referenceKeyId = conn.Query<int>(QUERY_InsertReferenceKey, refKey).First();        

            }
        }



        private static string LoadConnectionString()
        {
            return @"Data Source=.\Data\Blender3DReferenceDb.db;Version=3";
        }
    }
}
