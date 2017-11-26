using CRUDWCFSOAP.WEB.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDWCFSOAP.WEB.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult GetPersons()
        {
            Service1Client o = new Service1Client();
            List<Person> li = o.GetPerson().ToList();
            ViewBag.List = li;
            return View();
        }
        public ActionResult InsetPerson(Person obj)
        {
            return View();
        }
        public ActionResult UpdatePerson(Person obj)
        {
            return View();
        }
        public ActionResult DeletePerson(int id)
        {
            return View();
        }
    }
}