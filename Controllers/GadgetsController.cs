
using JamesBondGadgetsEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesBondGadgetsEntity.Controllers
{
    public class GadgetsController : Controller
    {
        private ApplicationDbContext context;

        public GadgetsController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Gadgets
        public ActionResult Index()
        {


            return View("Index");
        }

        public ActionResult Details(int id)
        {


            return View("Details");
        }

        public ActionResult Create()
        {
            return View("GadgetForm");
        }

        public ActionResult Edit(int id)
        {

            return View("GadgetForm");
        }

        public ActionResult Delete(int id)
        {

            return View("Index");
        }

        public ActionResult ProcessCreate(GadgetModel gadgetModel)
        {
            // save to the db



            return View("Details", gadgetModel);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            // get a list of search results from the database



            return View("Index");
        }

        public ActionResult SearchForDescription(string searchPhrase)
        {
            // get a list of search results from the database


            return View("Index");
        }
    }
}