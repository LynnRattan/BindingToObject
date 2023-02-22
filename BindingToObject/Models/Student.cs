using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    internal class Student
    {
        public string Name { get; set; }    
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }

        private DateTime currentDate;
        public DateTime CurrentDate { get { return currentDate; } set { currentDate = value; } }
        public int Age { get => (int)(CurrentDate - BirthDate).TotalDays / 365; }

        public Student()
        {
            CurrentDate = DateTime.Now; 
        }


    }
}
