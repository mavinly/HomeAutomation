using HomeAutomation.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeAutomation.Rest.Controllers
{
    public class SensorReadingController : Controller
    {
        private IDoorSwitch _doorSwitch;

        public SensorReadingController(IDoorSwitch doorSwitch)
        {
            _doorSwitch = doorSwitch;
        }

        public SensorReadingController()
        {
            _doorSwitch = new BusinessServices.DoorSwitch();
        }

        // GET: SensorReading
        public ActionResult Index()
        {
            var model = _doorSwitch.GetReadings();

            return View(model);
        }

        // GET: SensorReading/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SensorReading/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SensorReading/Create
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

        // GET: SensorReading/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SensorReading/Edit/5
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

        // GET: SensorReading/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SensorReading/Delete/5
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
