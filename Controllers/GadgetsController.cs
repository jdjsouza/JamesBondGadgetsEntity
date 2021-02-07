
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
        // GET: Gadgets
        public ActionResult Index()
        {


            return View("Index", gadgets);
        }

        public ActionResult Details(int id)
        {


            return View("Details", gadget);
        }

        public ActionResult Create()
        {
            return View("GadgetForm");
        }

        public ActionResult Edit(int id)
        {

            return View("GadgetForm", gadgets);
        }

        public ActionResult Delete(int id)
        {

            return View("Index", gadgets);
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



            return View("Index", searchResults);
        }

        public ActionResult SearchForDescription(string searchPhrase)
        {
            // get a list of search results from the database


            return View("Index", searchResults);
        }
    }
}