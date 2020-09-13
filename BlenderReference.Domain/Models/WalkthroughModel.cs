using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Models
{
    public class WalkthroughModel
    {
        public int Id { get; set; }
        public string WalkthroughName { get; set; }
        public int WalkthroughScenarioId { get; set; }
        public string Step { get; set; }
        public string StepDescription { get; set; }    
    }
}
