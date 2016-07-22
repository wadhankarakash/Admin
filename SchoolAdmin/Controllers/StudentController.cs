using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolAdmin.Models;
using SchoolAdminBusiness;
using CommonServices.Models;
using Newtonsoft.Json;

namespace SchoolAdmin.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student(string userAction)
        {

            //Based on user action the view will be rendered.
            String viewToBeReturned = userAction;

            if (userAction != null && userAction == "NewStudent")            
                 userAction = "NewStudent";

            else if (userAction != null && userAction == "SearchStudent")
                userAction = "SearchStudent";

            else if (userAction != null && userAction == "ViewStudent")
                userAction = "ViewStudent";

            return View(userAction);
        }

        [HttpPost]
        public string Search(string Name,string Class,string Div,string RegNumber)
        {
            //Validate input.

            SearchStudentRequests searchRequest = new SearchStudentRequests();
            searchRequest.Name = Name;
            searchRequest.Class = Class;
            searchRequest.Division = Div;
            searchRequest.RegNumber = RegNumber;

            Search search = new Search();
            List<Models.Student> lsStudent = search.SearchStudent(searchRequest);
            var jsonStudent = JsonConvert.SerializeObject(lsStudent);
            
            return jsonStudent;
        }

        [HttpPost]
        public ActionResult SendAlert(string RegNumber)
        {
            return View("NewAlert");
        }



        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
