using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportationAPI.Domain;
using TransportationAPI.Models;
using TransportationAPI.Services;
using TransportationAPI.Services.Interface;

namespace Transportationtest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public JsonResult DeleteTransportation(string transportationName)
        {
            TransportationService ts = new TransportationService();
            ts.RemoveTransportation(transportationName);

            return Json(ts.SelectAll());
        }


        [HttpPost]

        public JsonResult AddTransportation(TransportationAddRequestModel model)
        {
            TransportationService ts = new TransportationService();

            switch (model.TransportType)
            {
                case "Boat":
                    ITransportation newBoat = new Boat();
                    newBoat.Name = model.Name;
                    newBoat.TransportMode = model.TransportMode;
                    newBoat.PowerSource = model.PowerSource;
                    newBoat.Capacity = model.Capacity;
                    ts.AddTransportation(newBoat);
                    break;

                case "Plane":
                    ITransportation newPlane = new Plane();
                    newPlane.Name = model.Name;
                    newPlane.TransportMode = model.TransportMode;
                    newPlane.PowerSource = model.PowerSource;
                    newPlane.Capacity = model.Capacity;
                    ts.AddTransportation(newPlane);
                    break;

                case "Auto":
                    ITransportation newAuto = new Auto();
                    newAuto.Name = model.Name;
                    newAuto.TransportMode = model.TransportMode;
                    newAuto.PowerSource = model.PowerSource;
                    newAuto.Capacity = model.Capacity;
                    ts.AddTransportation(newAuto);
                    break;

                case "Train":
                    ITransportation newTrain = new Boat();
                    newTrain.Name = model.Name;
                    newTrain.TransportMode = model.TransportMode;
                    newTrain.PowerSource = model.PowerSource;
                    newTrain.Capacity = model.Capacity;
                    ts.AddTransportation(newTrain);
                    break;
            }

            return Json(ts.SelectAll());
        }
    }
}