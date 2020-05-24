using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Models
{
    /// <summary>
    /// Model needed to transfer 
    /// Reference Key data from Sqlite
    /// format to C#
    /// </summary>
    public class ReferenceKeyModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string HotKeyName { get; set; }
        public string ModeName { get; set; }
        public int ModeTypeId { get; set; }
        public string AreaName { get; set; }
        public int AreaTypeId { get; set; }
        public int CanGrabScaleRotate { get; set; }
        public int CanRestrictToXYZAxis { get; set; }
        public int CanEnterNumericValue { get; set; }
        public int HasScrollWheelFeature { get; set; }
        public string Comment { get; set; }
    }
}
