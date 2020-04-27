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
        public string Description { get; set; }
        public int ModeTypeId { get; set; }
        public int AreaTypeId { get; set; }
        public int CanGrabScaleRotate { get; set; }
        public int CanRestrictToXYZAxis { get; set; }
        public int CanEnterNumericValue { get; set; }
        public int HasScrollWheelFeature { get; set; }
        public string Comment { get; set; }
    }
}
