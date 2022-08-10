using HomeWorkSQL4.Helpers;
using HomeWorkSQL4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSQL4.Controllers
{
    internal class TeacherController
    {
        private static List<Teacher> _TeacherDb;

        static TeacherController()
        {
            _TeacherDb = new List<Teacher>();
        }



        public List<Teacher> GetAll()
        {
            return _TeacherDb.FindAll(n => !n.IsDeleted);
        }

        public Teacher Get(int id)
        {
            return _TeacherDb.Find(n => n.Id == id && !n.IsDeleted);

        }

        public void Update(int id)
        {
            var teacher = Get(id);
            if (teacher is null)
            {
                throw new NullReferenceException();
            }

            string name = CommonMethods.GetStringInput("Name");
            string surname = CommonMethods.GetStringInput("Surname");
            teacher.Name = name;
            teacher.Surname = surname;
        }

        public void Delete(int id)
        {
            var teacher = Get(id);
            if (teacher is null)
            {
                throw new NullReferenceException();
            }
            teacher.IsDeleted = true;
        }

        public void Create()
        {
            string name = CommonMethods.GetStringInput("Name");
            string surname = CommonMethods.GetStringInput("Surname");
            Teacher teacher = new Teacher();
            teacher.Id = 5;
            teacher.Name = name;
            teacher.Surname = surname;
            teacher.IsDeleted = false;
            teacher.CreateDate = DateTime.Now;
        }
    }
}
