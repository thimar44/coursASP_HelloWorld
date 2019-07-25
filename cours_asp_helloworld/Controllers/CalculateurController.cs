using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cours_asp_helloworld.Controllers
{
    public class CalculateurController : Controller
    {
        // GET: Calculateur
        public string Ajouter(int valeur1, int valeur2)
        {
            int resultat = valeur1 + valeur2;
            return resultat.ToString();
        }
    }
}