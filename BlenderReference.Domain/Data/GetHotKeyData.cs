using BlenderReference.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Data
{
    public class GetHotKeyData
    {
      
        public List<BlenderQuickReferenceItem> GetData()
        {
            List<ReferenceKeyModel> data = new List<ReferenceKeyModel>();
            BlenderQuickReferenceItem quickRefItem;
            List<BlenderQuickReferenceItem> quickRefList = new List<BlenderQuickReferenceItem>();
            List<HotKeyTypeModel> listOfHotKeys;

            data = SqliteDataAccess.LoadReferenceKeys();

            foreach (ReferenceKeyModel item in data)
            {
                quickRefItem = new BlenderQuickReferenceItem();

                quickRefItem.Description = item.Description;

                switch (item.AreaTypeId)
                {
                    case 1:
                        quickRefItem.Area = Enums.AreaTypeEnum.TransformObject;
                        break;
                    case 2:
                        quickRefItem.Area = Enums.AreaTypeEnum.EditObject;
                        break;
                    case 3:
                        quickRefItem.Area = Enums.AreaTypeEnum.Tools;
                        break;
                    case 4:
                        quickRefItem.Area = Enums.AreaTypeEnum.ViewPort;
                        break;
                }

                switch (item.ModeTypeId)
                {
                    case 1:
                        quickRefItem.ModeType = Enums.ModeTypeEnum.EditMode;
                        break;
                    case 2:
                        quickRefItem.ModeType = Enums.ModeTypeEnum.ObjectMode;
                        break;
                    case 3:
                        quickRefItem.ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes;
                        break;
                    case 4:
                        quickRefItem.ModeType = Enums.ModeTypeEnum.CameraMode;
                        break;
                }

                quickRefItem.Comments = item.Comment;
                quickRefItem.CanEnterNumericValue = (item.CanEnterNumericValue==1) ? true : false;
                quickRefItem.CanGrabScaleRotate = (item.CanGrabScaleRotate == 1) ? true : false;
                quickRefItem.CanRestrictToXYZAxis = (item.CanRestrictToXYZAxis == 1) ? true : false;
                quickRefItem.HasScrollWheelFeature = (item.HasScrollWheelFeature == 1) ? true : false;

                listOfHotKeys = new List<HotKeyTypeModel>();

                listOfHotKeys = SqliteDataAccess.LoadHotKeys(item.Id);

                foreach (HotKeyTypeModel listitem in listOfHotKeys)
                {
                    quickRefItem.AddHotKey(listitem.HotKeyName);
                }


                quickRefList.Add(quickRefItem);

            }

            return quickRefList;

        }
    }
}
