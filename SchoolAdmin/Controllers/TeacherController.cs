using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonServices.Models;
using SchoolAdmin.Models;
using SchoolAdminBusiness;
using Newtonsoft.Json;

namespace SchoolAdmin.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Teacher(string userAction)
        {
            //Based on user action the view will be rendered.
            String viewToBeReturned = userAction;

            if (userAction != null && userAction == "AssignTeacher")
                userAction = "AssignTeacher";

            else if (userAction != null && userAction == "NewTeacher")
                userAction = "NewTeacher";

            else if (userAction != null && userAction == "SearchTeacher")
                userAction = "SearchTeacher";

            return View(userAction);
        }

        [HttpPost]
        public string Search(string Name, string Subject, string Div, string Class)
        {
            //Validate input.

            SearchTeacherRequests searchRequest = new SearchTeacherRequests();
            searchRequest.Name = Name;
            searchRequest.Subject = Subject;
            searchRequest.Division = Div;
            searchRequest.Class = Class;

            Search search = new Search();
            List<Models.Student> lsStudent = search.SearchTeacher(searchRequest);
            var jsonStudent = JsonConvert.SerializeObject(lsStudent);

            return jsonStudent;
        }

        

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
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

        // GET: Teacher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teacher/Edit/5
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

        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teacher/Delete/5
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
