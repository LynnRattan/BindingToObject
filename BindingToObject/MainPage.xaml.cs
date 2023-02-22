using BindingToObject.Models;

namespace BindingToObject;


public partial class MainPage : ContentPage
{
    //נגדיר תכונה של תלמיד 
     Student student { get; set; }
    public MainPage()
	{
        //בפעולה הבונה נגדיר תלמיד חדש
        student = new Student()
        {
            Name = "Roni",
            BirthDate = new DateTime(2006, 2, 19),
            Image="roni.jpg"
        };
        //נקשר אותו לדף שלנו
        //כל הפקדים יקבלו גישה לנתונים שלו
        this.BindingContext = student; 
        InitializeComponent();
        

    }

    private void ageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        student.CurrentDate = new DateTime((int)e.NewValue, student.BirthDate.Month, student.BirthDate.Day);
    }
}

