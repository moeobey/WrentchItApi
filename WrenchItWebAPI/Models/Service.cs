using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WrenchItWebAPI.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public double EstimatedTimeToComplete { get; set; }
        public double Labor { get; set; }
      //  public string Image { get; set; }
    }
}
