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
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPerson()
        {
            throw new NotImplementedException();
        }

        public void InsertPerson(Person pobj)
        {
            PersonContext po = new PersonContext();
            po.Persons.Add(pobj);
            po.SaveChanges();
        }

        public void Updateperson(Person pobj)
        {
            throw new NotImplementedException();
        }
    }
}
