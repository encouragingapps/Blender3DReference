using System;
using System.Collections.Generic;
using System.Text;
using BlenderReference.Domain;

namespace BlenderReference.Domain.Data
{
    //TODO: Update this to use SQLite
    
    public class BuildHotKeyData
    {
        public List<BlenderQuickReferenceItem> QuickRefItems { get; set; }

        public BuildHotKeyData()
        {
            QuickRefItems = new List<BlenderQuickReferenceItem>();

            BlenderQuickReferenceItem newItem;

            #region "Viewport"
            newItem = new BlenderQuickReferenceItem
            {
                Description = "Zoom",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = true,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("Middle Mouse");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Panning Left/Right",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("Shift");
            newItem.AddHotKey("Middle Mouse");
            QuickRefItems.Add(newItem);
            #endregion

            #region "Object Mode"

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Grab",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = true,
                CanRestrictToXYZAxis = true,
                CanEnterNumericValue = true,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };
            newItem.AddHotKey("G");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Scale",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = true,
                CanRestrictToXYZAxis = true,
                CanEnterNumericValue = true,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform                
            };
            newItem.AddHotKey("S");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Rotate",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = true,
                CanRestrictToXYZAxis = true,
                CanEnterNumericValue = true,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };
            newItem.AddHotKey("R");
            QuickRefItems.Add(newItem);
            #endregion

            #region "Edit Mode"
            newItem = new BlenderQuickReferenceItem
            {
                Description = "Extrude",
                ModeType = Enums.ModeTypeEnum.EditMode,
                CanGrabScaleRotate = true,
                CanRestrictToXYZAxis = true,
                CanEnterNumericValue = true,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.EditObject
            };
            newItem.AddHotKey("E");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Splice",
                ModeType = Enums.ModeTypeEnum.EditMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = true,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.EditObject
            };
            newItem.AddHotKey("Ctrl");
            newItem.AddHotKey("R");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Bevel",
                ModeType = Enums.ModeTypeEnum.EditMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = true,
                Area = Enums.AreaTypeEnum.EditObject
            };
            newItem.AddHotKey("Ctrl");
            newItem.AddHotKey("B");
            QuickRefItems.Add(newItem);

            #endregion

            #region "Tools"
            newItem = new BlenderQuickReferenceItem
            {
                Description = "Toggle between Object/Edit modes",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.Tools
            };
            newItem.AddHotKey("Tab");
            QuickRefItems.Add(newItem);
            #endregion

          



        }
    }
}
