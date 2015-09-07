using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeAutomation.BusinessServices;

namespace HomeAutomation.Web.Controllers
{
    public class DoorSwitchWebController : Controller
    {
        IDoorSwitch _doorSwitch;
        private DoorSwitchWebController()
        {

        }

        public DoorSwitchWebController(IDoorSwitch ds)
        {
            _doorSwitch = ds;
        }
        // GET: DoorSwitchWeb
        public ActionResult Index()
        {
            var model = _doorSwitch.GetReadings();
            return View(model);
        }

        // GET: DoorSwitchWeb/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoorSwitchWeb/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoorSwitchWeb/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DoorSwitchWeb/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoorSwitchWeb/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DoorSwitchWeb/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoorSwitchWeb/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
