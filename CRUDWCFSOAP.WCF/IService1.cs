﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CRUDWCFSOAP.WCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Person> GetPerson();
        [OperationContract]
        void InsertPerson(Person pobj);
        [OperationContract]
        void Updateperson(Person pobj);
        [OperationContract]
        void Deleteperson(int id);

    }
    [DataContract]
    public class Person
    {
        [DataMember]
        [Key]
        [Required]
        public int id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        public string Address { get; set; }
    }

}
