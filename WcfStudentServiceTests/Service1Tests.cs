using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfStudentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfStudentService.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void AddStudentTestSuccess()
        {
           Service1 service = new Service1();
            //Assert
            service.AddStudent("Bob");
        }
       
        [TestMethod()]
        public void EditStudentTestSucces()
        {
            Service1 service = new Service1();
            service.AddStudent("123");
            service.EditStudent("123", "Bob");
        }

        [TestMethod()]
        public void FindStudentTestSucces()
        {
            Service1 service = new Service1();
            service.AddStudent("Bob");
            service.FindStudent("Bob");
        }

        [TestMethod()]
        public void GetAllStudentsTestSucces()
        {
            Service1 service = new Service1();
            service.AddStudent("Bob");
            service.AddStudent("Joe");
            service.GetAllStudents();
        }

      
        [TestMethod()]
        public void RemoveStudentTestSucces()
        {
            Service1 service = new Service1();
            service.AddStudent("Joe");
            service.RemoveStudent("Joe");
        }
    }
}