using BlenderReference.Domain.Models;
using BlenderReference.Domain.Utils;
using BlenderReference.Domain.Enums;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using System.IO;

namespace BlenderReference.Domain.Data
{
    public class SqliteDataAccess
    {
               

        public static List<ReferenceKeyModel> LoadReferenceKeys()
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = conn.Query<ReferenceKeyModel>(GetQuery(QueryReaderEnum.GetReferenceKeys), new DynamicParameters());
                    return output.ToList();
                }
            }

        public static List<HotKeyTypeModel> LoadHotKeys()
        {
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = conn.Query<HotKeyTypeModel>(GetQuery(QueryReaderEnum.GetHotKeys));                      
                    return output.ToList();
                }
            }
        }

        public static void SaveReferenceKey(ReferenceKeyModel refKey, List<HotKeyTypeModel> hotKeys)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                int referenceKeyId;

                referenceKeyId = conn.Query<int>(GetQuery(QueryReaderEnum.InsertReferenceKey), refKey).Single();

                int priorityCounter = 0;
                ReferenceKeyHotKeyModel refkeyHotKey;

                foreach(HotKeyTypeModel hotkey in hotKeys)
                {
                    priorityCounter++;

                    refkeyHotKey = new ReferenceKeyHotKeyModel()
                    {
                        ReferenceKeyId = referenceKeyId,
                        HotKeyTypeId = hotkey.Id,
                        OrderId = priorityCounter,
                    };
                                                            
                    conn.Execute(GetQuery(QueryReaderEnum.InsertReferenceHotKey), refkeyHotKey);

                }

            }
        }


        public static void DoesHotKeyExist(String hotkey, String hotkeyAlias)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                //int referenceKeyId;

                // referenceKeyId = conn.Query<int>(QUERY_InsertReferenceKey, refKey).First();

            }
        }

        public static void SaveHotKey(String hotkey)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                //int referenceKeyId;

               // referenceKeyId = conn.Query<int>(QUERY_InsertReferenceKey, refKey).First();

            }
        }

        private static string LoadConnectionString()
        {
            return @"Data Source=.\Data\Blender3DReferenceDb.db;Version=3";
        }

        private static string GetQuery(QueryReaderEnum reader)
        {
            string pathName = CommonUtils.GetApplicationPath() + @"Data\";
            string fileName;

            switch (reader)
            {
                case QueryReaderEnum.GetHotKeys:
                    fileName = "GetHotKeys.sql";
                    break;
                case QueryReaderEnum.GetReferenceKeys:
                    fileName = "GetReferenceKeys.sql";
                    break;
                case QueryReaderEnum.InsertReferenceHotKey:
                    fileName = "InsertReferenceHotKey.sql";
                    break;
                case QueryReaderEnum.InsertReferenceKey:
                    fileName = "InsertReferenceKey.sql";
                    break;
                default:
                    fileName = "";
                    break;
            }

            string readText = File.ReadAllText(pathName + fileName);
            return readText;
        }


    }
}
