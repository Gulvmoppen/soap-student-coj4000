using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfStudentService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
       

        public Student()
        {
            
        }
        public Student(string name)
        {
            Name = name;
           
        }
        

    }
}