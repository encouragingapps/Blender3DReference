using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Data;
using BlenderReference.Domain.Enums;

namespace BlenderReference.Domain.Logic
{
    public static class GetQuickReferenceItems
    {
        public static List<BlenderQuickReferenceItem> GetBlenderQuickRefData()
        {
                
            var returnData = new List<BlenderQuickReferenceItem>();
            var data = new GetHotKeyData();

            returnData = data.GetData();

            return returnData;                             
                
            }
    }
}
