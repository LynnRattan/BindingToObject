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
            Age = 16
           
        };
        //נקשר אותו לדף שלנו
        //כל הפקדים יקבלו גישה לנתונים שלו
        this.BindingContext = student; 
        InitializeComponent();
        

    }

   

    private void ChangeName(object sender, EventArgs e)
    {
        student.Name = "אחר";
    }

    private void ChangeAge(object sender, EventArgs e)
    {
        student.Age = 17;
    }
}

