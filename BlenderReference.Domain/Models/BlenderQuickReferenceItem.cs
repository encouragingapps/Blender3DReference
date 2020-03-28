using System;
using System.Collections.Generic;
using BlenderReference.Domain.Enums;

namespace BlenderReference.Domain.Models
{
    public class BlenderQuickReferenceItem
    {
        public string Description { get; set; }
        public List<string> HotKeys { get; set; }
        public ModeTypeEnum ModeType { get; set; }
        public bool? CanGrabScaleRotate { get; set; }
        public bool? CanRestrictToXYZAxis { get; set; }
        public bool? CanEnterNumericValue { get; set; }
        public bool? HasScrollWheelFeature { get; set; }
        public string Comments { get; set; }

        public BlenderQuickReferenceItem() {
            HotKeys = new List<string>();
        }
        
        public AreaTypeEnum Area { get; set; }

        public string ConcatHotKeys()
        {            
            return string.Join("+", HotKeys); 
        }

        public void AddHotKey(String ThisKey)
        {
            HotKeys.Add(ThisKey);
        }

    }
}
