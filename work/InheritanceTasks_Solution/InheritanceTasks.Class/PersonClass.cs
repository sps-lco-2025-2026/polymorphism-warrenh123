using System.Runtime.InteropServices;

namespace InheritanceTasks;

public class Person
{
    public string firstName{ get; set;} 
    public string lastName { get; set; }
    public string email { get; set; } = "";
    public DateTime dateOfBirth { get; set; }

    public int Age => CalulateAge();

   public bool Valid
    {
        get
        {
            return ValidateAge();
        }
    }

    public bool Adult
    {
        get
        {
            return ValidateAdult();
        }
    }

    public string ChineseSign
    {
        get
        {
            return GetChineseSign();
        }
    }

    public bool Birthday
    {
        get
        {
            return IsBirthday();
        }
    }

    public string ScreenName
    {
        get
        {
            return $"{firstName} {lastName} born on {dateOfBirth}";
        }
    }

    public Person(string First, string Last, string Email, DateTime DateOfBirth)
    {
        firstName = First ;
        lastName = Last;
        email = Email;
        dateOfBirth = DateOfBirth;
    }
    public Person(string First, string Last, DateTime DateOfBirth): this(First, Last, "", DateOfBirth){}

    public int CalulateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;

        if(dateOfBirth.Date < today.AddYears(-age))
        {
            age--;
        }
        return age;
    }

    private bool ValidateAge()
    {
        if(dateOfBirth > DateTime.Today)
        {
            return false;
        }
        if(dateOfBirth < new DateTime(DateTime.Today.Year - 150, 1,1))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private bool ValidateAdult()
    {
        if(CalulateAge() >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private string GetChineseSign()
    {
        List<string> signs = new List<string> 
        {"Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"};
        int i = (dateOfBirth.Year - 4) % 12; //offset of 4

        if(i < 0)
        {
            i += 12;
        }
        return signs[i];
    }

    private bool IsBirthday()
    {
        if(DateTime.Today == dateOfBirth)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
