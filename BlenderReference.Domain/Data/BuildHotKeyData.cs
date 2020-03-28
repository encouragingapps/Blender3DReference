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

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Top Ortho View",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("NumPad 7");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Bottom Ortho View",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("Ctrl");
            newItem.AddHotKey("NumPad 7");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Front Ortho View",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("NumPad 1");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Back Ortho View",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("Ctrl");
            newItem.AddHotKey("NumPad 1");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Right Ortho View",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("NumPad 3");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Left Ortho View",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.ViewPort
            };
            newItem.AddHotKey("Ctrl");
            newItem.AddHotKey("NumPad 3");
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
                Description = "Resets Location to 0",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                CanEnterNumericValue = false,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };
            newItem.AddHotKey("Alt");
            newItem.AddHotKey("G");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Resets Rotation to 0",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                CanEnterNumericValue = false,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };
            newItem.AddHotKey("Alt");
            newItem.AddHotKey("R");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Resets Scale to 0",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                CanEnterNumericValue = false,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };
            newItem.AddHotKey("Alt");
            newItem.AddHotKey("S");
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

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Delete",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                CanEnterNumericValue = false,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };

            newItem.AddHotKey("X");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Duplicate Object",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                CanEnterNumericValue = false,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform
            };
            newItem.AddHotKey("Shift");
            newItem.AddHotKey("D");
            QuickRefItems.Add(newItem);


            newItem.AddHotKey("M");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Add Objects to Collection",
                ModeType = Enums.ModeTypeEnum.ObjectMode,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                CanEnterNumericValue = false,
                HasScrollWheelFeature = false,
                Area = Enums.AreaTypeEnum.Transform,
                Comments = "This will put them under a collection object " +
                "in the outlier panel"
            };
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

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Add Object",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.Tools,
                Comments = "Use operator panel after the object " +
                "is created to modify it. " +
                "You only get one opprotunity to change it."
            };
            newItem.AddHotKey("Shift");
            newItem.AddHotKey("A");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Toogle Property Panel",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.Tools,
                Comments = "Use this to adjust object properties"
            };
            newItem.AddHotKey("N");            
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Pie Menu",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.Tools,
                Comments = "This displays a shortcut menu " +
                "for the different render modes."
            };
            newItem.AddHotKey("Z");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Toggle Toolbox Panel",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.Tools,
                Comments = "Shortcut Menu Items for Common Tasks."
            };
            newItem.AddHotKey("N");
            QuickRefItems.Add(newItem);

            newItem = new BlenderQuickReferenceItem
            {
                Description = "Box Select",
                ModeType = Enums.ModeTypeEnum.BothEditAndObjectModes,
                CanGrabScaleRotate = false,
                CanRestrictToXYZAxis = false,
                HasScrollWheelFeature = false,
                CanEnterNumericValue = false,
                Area = Enums.AreaTypeEnum.Tools,
                Comments = "Drag the mouse to box select object."
            };
            newItem.AddHotKey("B");
            QuickRefItems.Add(newItem);

            #endregion





        }
    }
}
