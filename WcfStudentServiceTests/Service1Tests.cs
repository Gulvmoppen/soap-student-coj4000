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
            //Arrange
            Service1 service = new Service1();
            //Act
            service.AddStudent("Bob");
        }
        [TestMethod()]
        public void EditStudentTestSucces()
        {
            //Arrange
            Service1 service = new Service1();
            //Act
            service.AddStudent("123");
            service.EditStudent("123", "Bob");
        }

        [TestMethod()]
        public void FindStudentTestSucces()
        {
            //Arrange
            Service1 service = new Service1();
            //Act
            service.AddStudent("Bob");
            service.FindStudent("Bob");
        }

        [TestMethod()]
        public void GetAllStudentsTestSucces()
        {
            //Arrange
            Service1 service = new Service1();
            //Act
            service.AddStudent("Bob");
            service.AddStudent("Joe");
            service.GetAllStudents();
        }

      
        [TestMethod()]
        public void RemoveStudentTestSucces()
        {
            //Arrange
            Service1 service = new Service1();
            //Act
            service.AddStudent("Joe");
            service.RemoveStudent("Joe");
        }
    }
}