using BlenderReference.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Data
{
    public class GetWalkthroughData
    {

        public List<WalkthroughModel> GetWalkthroughScenarios()
        {
            List<WalkthroughModel> data = new List<WalkthroughModel>();
            data = SqliteDataAccess.LoadWalkthroughScenarios();
            return data;
        }

        public List<WalkthroughModel> GetWalkthroughDetail(int Id)
        {
            List<WalkthroughModel> data = new List<WalkthroughModel>();
            data = SqliteDataAccess.LoadWalkthroughDetail(Id);
            return data;
        }

        //public List<WalkthroughModel> GetData()
        //{
        //    List<WalkthroughModel> data = new List<WalkthroughModel>();
        //    WalkthroughModel walkthroughItem;
        //    List<WalkthroughModel> walkthroughList = new List<WalkthroughModel>();

        //    data = SqliteDataAccess.LoadWalkthroughs();

        //    foreach (WalkthroughModel item in data)
        //    {
        //        walkthroughItem = new WalkthroughModel();

        //        walkthroughItem.Id = item.Id;
        //        walkthroughItem.WalkthroughScenarioId = item.WalkthroughScenarioId;
        //        walkthroughItem.WalkthroughName = item.WalkthroughName;
        //        walkthroughItem.Step = item.Step;
        //        walkthroughItem.StepDescription = item.StepDescription;

        //        walkthroughList.Add(walkthroughItem);
        //    }

        //    return walkthroughList;

        //}
    }
}
