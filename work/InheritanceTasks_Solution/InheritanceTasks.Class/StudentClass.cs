namespace InheritanceTasks;

public class Student: Person
{
    public string schoollYear;

    public Student(string First, string Last, DateTime DateOfBirth) : base(First, Last, DateOfBirth)
    {
        schoollYear = GetSchoolYear(Age).ToString();
    }

    private int GetSchoolYear(int age)
    {
        return age - 4;
    }
    
}