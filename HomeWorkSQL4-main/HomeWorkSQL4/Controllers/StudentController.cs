using HomeWorkSQL4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkSQL4.Helpers; 


namespace HomeWorkSQL4.Controllers
{
    internal class StudentController
    {
        private static List<Student> _studentDb; 

        static StudentController()
        {
            _studentDb = new List<Student>();
        }


        public List<Student> GetAll()
        {
            return _studentDb.FindAll(n => !n.IsDeleted);
        }

        public Student Get(int id)
        {
            return _studentDb.Find(n => n.Id == id && !n.IsDeleted);

        }

        public void Update(int id)
        {
            var student = Get(id);
            if (student is null)
            {
                throw new NullReferenceException();
            }

            string name = CommonMethods.GetStringInput("Name");
            string surname = CommonMethods.GetStringInput("Surname");
            student.Name = name;
            student.Surname = surname;
        }

        public void Delete(int id)
        {
            var student = Get(id);
            if (student is null)
            {
                throw new NullReferenceException();
            }
            student.IsDeleted = true;
        }

        public void Create()
        {
            string name = CommonMethods.GetStringInput("Name");
            string surname = CommonMethods.GetStringInput("Surname");
            Student student = new Student();
            student.Id = 5;
            student.Name = name;
            student.Surname = surname;
            student.IsDeleted = false;
            student.CreateDate=DateTime.Now;
        }
    }
}
