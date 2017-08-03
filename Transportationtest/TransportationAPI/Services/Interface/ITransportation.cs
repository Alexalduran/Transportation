using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationAPI.Domain;

namespace TransportationAPI.Services.Interface
{
    public interface ITransportation
    {

        string Name { get; set; }

        TType TransportType { get; }
        string TypeOfTransportString { get; }

        TMode TransportMode { get; set; }
        string TypeOfTransportMode { get; }

        PSource PowerSource { get; set; }
        string TypeOfPowerSource { get; }

        List<CapacityObj> Capacity { get; set; }

        void Load();

        void Transport();

        void Unload();
    }


}
