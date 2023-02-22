using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    internal class Student:INotifyPropertyChanged
    {
        public string Name { get; set; }    
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }

        private DateTime currentDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime CurrentDate { get { return currentDate; } set 
            { 
                if (value != currentDate)
                { currentDate = value;
                 OnPropertyChanged("CurrentDate"); OnPropertyChanged("Age"); } 
            } 
        }
        public int Age { get => (int)(CurrentDate - BirthDate).TotalDays / 365; }

        public Student()
        {
            CurrentDate = DateTime.Now; 
        }
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
