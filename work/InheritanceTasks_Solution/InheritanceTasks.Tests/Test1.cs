namespace InheritanceTasks.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Teacher_ScreenName()
    {
        var teacher = new Teacher("Christopher", "Harrison", new DateTime(1930, 1, 1), "Computer Science");
        string result = teacher.ScreenName();

        Assert.Contains("member of staff", result);
        Assert.Contains("Computer Science", result);
    }

    [TestMethod]
    public void Check_Polymorphism()
    {
        List<Person> people = new List<Person>
        {
            new Person("James", "Brown", "test@gmail.com", new DateTime(2000, 1, 1)),
            new Student("Duy", "Pham", new DateTime(2008, 1, 1)),
            new Teacher("Tim", "Vincent", new DateTime(1960, 1, 1), "CS")
        };

        Assert.DoesNotContain("school year", people[0].ScreenName());
        Assert.Contains("school year", people[1].ScreenName());
        Assert.Contains("member of staff", people[2].ScreenName());
    }
}
