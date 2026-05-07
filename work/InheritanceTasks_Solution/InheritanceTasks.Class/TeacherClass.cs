namespace InheritanceTasks;
public class Teacher : Person
{
    protected string Subject{ get; set; }

    public Teacher(string First, string Last, DateTime DateOfBirth, string subject): base(First, Last,  DateOfBirth)
    {
        Subject = subject;
    }

    public override string ScreenName()
    {
        string s = base.ScreenName();
        return $"{s} and this is a member of staff that teaches {Subject}";
    }
}