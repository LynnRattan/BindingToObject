using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    //ממשק מגדיר אירוע שיאפשר לאובייקט שלנו להודיע על שינויים בתכונות
    internal class Student:INotifyPropertyChanged
    {
        public string Name { get; set; }    
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }

        private DateTime currentDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime CurrentDate { get { return currentDate; } set 
            { 
                //כאשר תאריך נוכחי משתנה
                if (value != currentDate)
                { currentDate = value;
                    //גם תאריך נוכחי וגם גיל משתנים
                 OnPropertyChanged("CurrentDate"); OnPropertyChanged("Age"); } 
            } 
        }
        public int Age { get => (int)(CurrentDate - BirthDate).TotalDays / 365; }

        public Student()
        {
            CurrentDate = DateTime.Now; 
        }
        //נפעיל את האירוע ונשלח כפרמטר את הסטודנט שלנו ואת שם התכונה שבוצע בה שינוי
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
