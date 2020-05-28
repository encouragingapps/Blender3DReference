using BlenderReference.Domain.Data;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BlenderReference.Domain.Models
{
    public class BlenderMenuReferenceItem
    {
        const string Arrow3d = "&#10146";
        const string ArrowCircle = "&#10162;";
        const string ArrowStandard = "&#10132;";
                    
        public int Id { get; set; }
        public string MenuDescription { get; set; }
        public string MenuNavigation { get; set; }
        public string Comments { get; set; }
        public string ImagePath { get; set; }
        public string ModeTypeId { get; set; }
        public string ModeName { get; set; }
    }
}
