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
        public ActionResult InsetPerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsetPerson(Person obj)
        {
            Service1Client o = new Service1Client();
            o.InsertPerson(obj);
            return View();
        }
        public ActionResult UpdatePerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdatePerson(Person obj)
        {
            Service1Client o = new Service1Client();
            o.Updateperson(obj);
            return View();
        }
        public ActionResult DeletePerson()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DeletePerson(int id)
        {
            Service1Client o = new Service1Client();
            o.Deleteperson(id);
            return View();
        }
    }
}