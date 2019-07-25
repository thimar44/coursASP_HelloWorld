using cours_asp_helloworld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cours_asp_helloworld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            String urlListeClient = HtmlHelper.GenerateLink(Request.RequestContext, RouteTable.Routes, "liste CLients", null, "ListeClients", "Home", new RouteValueDictionary {}, null);
            ViewBag.urlListeClient = urlListeClient;
            ViewData["Nom"] = "Thibaud";
            ViewBag.prenom = "MARCOUX";
            return View();
        }

        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult ChercheClient(string id)
        {
            ViewData["Nom"] = id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
        }
    }
}