using System;
using System.Collections.Generic;
using HomeWorkSQL4.Controllers;
using HomeWorkSQL4.Helpers;

namespace HomeWorkSQL4
{
    internal class Program
    {
       private static TeacherController _teachers;
        private static StudentController _student ;
        public Program()
        {
            _teachers= new TeacherController();
            _student = new StudentController();

        }
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Welcome");
        TryAgain:
            Console.WriteLine("Press 1 for get all teachers \n" +
                              "press 2 for get all students \n" +
                              "press 3 for create teacher \n" +
                              "press 4 for create student \n" +
                              "press 5 for delete teacher \n" +
                              "press 6 for delete student");
            string input = CommonMethods.GetStringInput("answer");
            switch (input)
            {
                case "1":
                    Console.Clear();
                    
                    Print(_teachers.GetAll());

                        goto TryAgain;
                case "2":
                    Console.Clear();

                    Print(_student.GetAll());
                    goto TryAgain;
                case "3":
                    Console.Clear();
                    _teachers.Create();
                    goto TryAgain;
                case "4":
                    Console.Clear();
                    _student.Create();
                    goto TryAgain;
                case "5":
                    Console.Clear();
                    DeleteTeacher();
                    goto TryAgain;
                case "6":
                    DeleteStudent();
                    Console.Clear();
                    goto TryAgain;
                case "0":
                    Console.Clear();
                    Console.WriteLine("BYE BYE :)");
                    break;
                    
                default:
                    Console.WriteLine("Something went wrong.SIUUUUUUU!");
                    goto TryAgain;
            }


        }
        

        private static void Print<T>(List<T> Humanbeing) 
        {
            foreach (var item in Humanbeing)
            {
                Console.WriteLine(item.ToString()); 
            }
        }


        private static void DeleteTeacher()
        {
        TryAgain:
            Print(_teachers.GetAll());
            int id = CommonMethods.GetIntInput("id");
            try
            {
                _teachers.Delete(id);
            }
            catch (Exception)
            {

                Console.WriteLine("Teacher doesnt exist");
                goto TryAgain;
            }

        }


            private static void DeleteStudent()
        {
            TryAgain:
            Print(_student.GetAll());
            int id = CommonMethods.GetIntInput("id");
            try
            {
                _student.Delete(id);
            }
            catch (Exception)
            {

                Console.WriteLine("Student doesnt exist");
                goto TryAgain;
            }
        }
    }
}
