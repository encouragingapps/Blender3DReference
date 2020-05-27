using System;
using System.Collections.Generic;
using System.Text;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Data;
using BlenderReference.Domain.Enums;


namespace BlenderReference.Domain.Logic
{
    public class GetMenuReferenceItems
    {
        public static List<BlenderMenuReferenceItem> GetBlenderMenuData()
        {
            var returnData = new List<BlenderMenuReferenceItem>();
            var data = new GetMenuData();

            returnData = data.GetData();

            return returnData;
        }
    }
}
