using BlenderReference.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Data
{
    public class GetMenuData
    {
      
        public List<BlenderMenuReferenceItem> GetData()
        {
            List<BlenderMenuReferenceItem> data = new List<BlenderMenuReferenceItem>();
            BlenderMenuReferenceItem quickMenuItem;
            List<BlenderMenuReferenceItem> quickMenuList = new List<BlenderMenuReferenceItem>();
       
            data = SqliteDataAccess.LoadReferenceMenu();

            foreach (BlenderMenuReferenceItem item in data)
            {
                quickMenuItem = new BlenderMenuReferenceItem();

                quickMenuItem.Id = item.Id;
                quickMenuItem.MenuDescription = item.MenuDescription;
                quickMenuItem.MenuNavigation = item.MenuNavigation;
                quickMenuItem.ImagePath = item.ImagePath;
                quickMenuItem.Comments = item.Comments;

                quickMenuList.Add(quickMenuItem);
            }
                           
            return quickMenuList;

        }
    }
}
