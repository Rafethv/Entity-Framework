using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSQL4.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}- {Name} {Surname}";
        }
    }
}
