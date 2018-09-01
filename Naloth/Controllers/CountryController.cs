using Naloth.DAL.Repositories;
using Naloth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Naloth.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            var model = new CountryModel();

            var repo = new CountryRepository();
            var country = repo.GetCountry("Nederland");

            model.Name = country.Name; // Gaat fout als het land niet bestaat!
            return View(model);

        }
    }
}