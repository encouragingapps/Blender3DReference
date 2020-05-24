using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Models
{
    public class ReferenceKeyHotKeyModel
    {        
        public int Id { get; set; }
        public int HotKeyTypeId { get; set; }
        public int ReferenceKeyId { get; set; }
        public int OrderId { get; set; }
    }
}
