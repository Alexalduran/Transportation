using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationAPI.Domain;
using TransportationAPI.Services.Interface;

namespace TransportationAPI.Services
{
    public class Boat : ITransportation
    { 
        public string Name { get; set; }
        public TType TransportType { get { return TType.Boat; } }
        public string TypeOfTransportString { get
            {
                switch (TransportType)
                {
                    case TType.Boat:
                        return "Boat";
                    case TType.Auto:
                        return "Auto";
                    case TType.Plane:
                        return "Plane";
                    case TType.Train:
                        return "Train";
                    default:
                        return null; 
                }

            } }
        public TMode TransportMode { get; set; }
        public string TypeOfTransportMode
        {
            get
            {
                switch (TransportMode)
                {
                    case TMode.Land:
                        return "Land";
                    case TMode.Sea:
                        return "Sea";
                    case TMode.Air:
                        return "Air";
                    default:
                        return null;
                }

            }
        }
        public PSource PowerSource { get; set; }
        public string TypeOfPowerSource
        {
            get
            {
                switch (PowerSource)
                {
                    case PSource.Deisel:
                        return "Deisel";
                    case PSource.Battery:
                        return "Battery";
                    case PSource.Solar:
                        return "Solar";
                    default:
                        return null;
                }

            }
        }
        public List<CapacityObj> Capacity { get; set; }

        public void Load()
        {
            //something
        }

        public void Transport()
        {
            //something
        }

        public void Unload()
        {
            //something
        }

    }

   
}
