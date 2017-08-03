using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationAPI.Domain;
using TransportationAPI.Services.Interface;
using System.Web;

namespace TransportationAPI.Services
{
    public class TransportationService
    {
        public TransportationService()
        {
            if(HttpContext.Current.Session["TTypes"] == null)
            {
                HttpContext.Current.Session["TTypes"] = new Dictionary<string, ITransportation>(); 
            }

        }



       public Dictionary<string, ITransportation> SelectAll()
        {
            return (Dictionary<string,ITransportation>)HttpContext.Current.Session["TTypes"]; 
        }

        public void AddTransportation (ITransportation newTransportation)
        {
            //Dictionary<string, ITransportation> Transportation = (Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"];


            if (((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"]).ContainsKey(newTransportation.Name))
            {

                ((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"])[newTransportation.Name] = newTransportation;
            }
            else
            {
                ((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"]).Add(newTransportation.Name, newTransportation);

            }
        }

        public void RemoveTransportation(string transportationName)
        {
            if (((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"]).ContainsKey(transportationName))
            {
                ((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"]).Remove(transportationName);
            }
            else
            {
                throw new Exception("Name Not Found"); 
            }
        }

        public void UpdateTransportation(ITransportation updateTransportation)
        {
            if (((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"]).ContainsKey(updateTransportation.Name))
            {
                ((Dictionary<string, ITransportation>)HttpContext.Current.Session["TTypes"])[updateTransportation.Name] = updateTransportation;
            }
            else
            {
                throw new Exception("NO");
            }
        }


    }
}
