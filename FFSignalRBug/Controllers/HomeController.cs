using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FFSignalRBug.Models;
using System.Threading;
using Microsoft.AspNet.SignalR;

namespace FFSignalRBug.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(TestModel model)
        {
            // Initialize Hub context
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<TestHub>();

            // Emulate some long running process
            for (int i = 0; i < 10; i++)
            {
                string msg = "Processing " + (i + 1).ToString() + " of 10";                
                hubContext.Clients.Client(model.ConnectionID).sendMessage(msg, ((i + 1) * 10));
                Thread.Sleep(500);
            }
            

            return View();
        }
    }
}