using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Models
{
    public class WalkthroughModelCollection
    {

        public WalkthroughModelCollection()
        {
            DataList = new List<List<WalkthroughModel>>();
        }

        public List<List<WalkthroughModel>> DataList { get; set; }
        
    
    }
}
