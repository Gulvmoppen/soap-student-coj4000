using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfStudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly List<Student> studentlist = new List<Student>();
        public void AddStudent(int id, string name)
        {
            Student student = new Student(id, name);
            studentlist.Add(student);

        }

        public void EditStudent(string name, string newname)
        {
            foreach (Student s in studentlist)
            {
                if (s.Name == name)
                {
                    s.Name = newname;
                }
            }
        }

        public string FindStudent(int id)
        {
            string student = "";
            foreach (Student s in studentlist)
            {
                if (s.ID == id)
                {
                    student = s.Name;
                }
            }
            return student;
        }

        public List<string> GetAllStudents()
        {
            List<string> studlist = new List<string>();
            foreach (Student s in studentlist)
            {
                 studlist.Add(s.Name);
            }
            return studlist;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void RemoveStudent(string name)
        {
            foreach (Student s in studentlist)
            {
                if (s.Name.Trim() == name)
                {
                    studentlist.Remove(s);
                    break;
                }
            }
        }
    }
}
