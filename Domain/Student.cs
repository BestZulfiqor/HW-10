namespace Domain;

public class Student(int id, string firstName, string LastName, int Age, Gender gender, Status status, DateTime dateOfstart, DateTime dateOfFinish)
{
    public int Id { get; set; } = id;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = LastName;
    public int Age { get; set; } = Age;
    public Gender Gender { get; set; } = gender;
    public Status Status {get; set; } = status;
    public DateTime DateOfStart { get; set; } = dateOfstart;
    public DateTime DateOfFinish { get; set; } = dateOfFinish;
}

public enum Gender
{
    Male = 1,
    Female
}
public enum Status{
    Active = 1,
    Inactive
}