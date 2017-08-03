using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationAPI.Domain;

namespace TransportationAPI.Models
{
    public class TransportationAddRequestModel
    {

        public string Name { get; set; }

        public string TransportType { get; set; }

        public TMode TransportMode { get; set; }

        public PSource PowerSource { get; set; }

        public List<CapacityObj> Capacity { get; set; }

    }
}
