using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Test
{
    [TestClass()]
    public class SqliteDbTests
    {
        [TestMethod()]
        public void GetAllReferenceKeys()
        {
            _ = new List<ReferenceKeyModel>();
            List<ReferenceKeyModel> keys = SqliteDataAccess.LoadReferenceKeys();

        }
    }
}
