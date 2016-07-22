﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolAdmin.Controllers
{
    public class AlertsController : Controller
    {
        // GET: Alerts
        public ActionResult Alerts(string userAction)
        {
            String viewToBeReturned = userAction;

            if (userAction != null && userAction == "NewAlert")
                userAction = "NewAlert";

            else if (userAction != null && userAction == "ViewAlert")
                userAction = "ViewAlert";


            return View(userAction);
        }

        // GET: Alerts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alerts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alerts/Create
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

        // GET: Alerts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alerts/Edit/5
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

        // GET: Alerts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alerts/Delete/5
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
