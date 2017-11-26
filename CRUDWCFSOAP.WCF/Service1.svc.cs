using CRUDWCFSOAP.WCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CRUDWCFSOAP.WCF
{
    public class Service1 : IService1
    {
        public void Deleteperson(int id)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.id == id
                     select per).First();
            po.Persons.Remove(c);
            po.SaveChanges();
        }

        public IEnumerable<Person> GetPerson()
        {
            List<Person> li = new List<Person>();
            PersonContext po = new PersonContext();
            li = po.Persons.ToList();
            return li;
        }

        public void InsertPerson(Person pobj)
        {
            PersonContext po = new PersonContext();
            po.Persons.Add(pobj);
            po.SaveChanges();
        }

        public void Updateperson(Person pobj)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.id == pobj.id
                     select per).First();
            c.Address = pobj.Address;
            c.Name = pobj.Name;
            po.SaveChanges();

        }
    }
}
