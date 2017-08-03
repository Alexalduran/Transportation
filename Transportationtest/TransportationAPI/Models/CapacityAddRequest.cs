using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationAPI.Models
{
    class CapacityAddRequest
    {
        public double Count { get; set; }

        public string UnitOfMeasure { get; set; }

        public string PassengerType { get; set; }
    }
}
