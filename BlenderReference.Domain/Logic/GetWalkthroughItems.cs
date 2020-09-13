using System;
using System.Collections.Generic;
using System.Text;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Data;
using BlenderReference.Domain.Enums;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BlenderReference.Domain.Logic
{
    public class GetWalkthroughItems
    {
        //public static WalkthroughModelCollection GetBlenderWalkthroughData()
        //{
        //    var returnData = new List<WalkthroughModel>();
        //    var data = new GetWalkthroughData();
        //    var output = new WalkthroughModelCollection();

        //    returnData = data.GetData();

        //    var listofScenarioIds = returnData.Select(x => x.Id).Distinct().ToList();

        //    foreach(int item in listofScenarioIds)
        //        {
        //            output.DataList.Add(returnData.Where(x => x.Id == item).ToList());                
        //        }
            
        //    return output;
        //}

        public static List<WalkthroughModel> GetWalkthroughScenarios()
        {           
            var data = new GetWalkthroughData();                   
            return data.GetWalkthroughScenarios();
        }

        public static List<WalkthroughModel> GetWalkthroughDetail(int Id)
        {
            var data = new GetWalkthroughData();
            return data.GetWalkthroughDetail(Id);
        }

    }
}
