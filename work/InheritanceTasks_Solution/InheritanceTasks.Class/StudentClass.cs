namespace InheritanceTasks;

public class Student: Person
{
    public string schoollYear{ get; set; }

    public Student(string First, string Last, DateTime DateOfBirth) : base(First, Last, DateOfBirth)
    {
        schoollYear = GetSchoolYear(Age).ToString();
    }

    private int GetSchoolYear(int age)
    {
        return age - 4;
    }

    public override string ScreenName()
    {
        string s = base.ScreenName();
        return $"{s} and school year is {schoollYear}";
    }
}