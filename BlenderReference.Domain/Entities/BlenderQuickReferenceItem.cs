using System;
using System.Collections.Generic;
using BlenderReference.Domain.Enums;

namespace BlenderReference.Domain
{
    public class BlenderQuickReferenceItem
    {
        public List<string> HotKeys { get; set; }        
        public ModeTypeEnum ModeType { get; set; }
        public bool CanGrabScaleRotate { get; set; }
        public string Area { get; set; }

        public string ConcatHotKeys()
        {            
            return string.Join("+", HotKeys); 
        }

    }
}
