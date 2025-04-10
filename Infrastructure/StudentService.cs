using Domain;

namespace Infrastructure;

public class StudentService
{
    public List<Student> students = [];
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void Info(List<Student> students)
    {
        Console.WriteLine(string.Join("\n", students.Select(n => $"{n.Id}: {n.FirstName} {n.LastName}, Age: {n.Age}, Gender: {n.Gender}, DateOfStart: {n.DateOfStart.ToShortDateString()}, DateOfFinish: {n.DateOfFinish.ToShortDateString()}")));
        Console.WriteLine();
    }

    // Task 1
    public void MaleStudentsMethod()
    {
        var students = this.students.FindAll(n => n.Gender == Gender.Male);
        Info(students);
    }
    public void MaleStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Gender == Gender.Male
             select s).ToList();
        Info(students);
    }

    // Task 2
    public void ActiveStudentsMethod()
    {
        var students = this.students.FindAll(n => n.Status == Status.Inactive);
        Info(students);
    }

    public void ActiveStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Status == Status.Inactive
             select s).ToList();
        Info(students);
    }

    // Task 3
    public void ZeroStudentsMethod()
    {
        var students = this.students.FindAll(n => n.Age < 25);
        Info(students);
    }
    public void ZeroStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Age < 25
             select s).ToList();
        Info(students);
    }

    // Task 4
    public void Over20StudentsMethod()
    {
        var students = this.students.FindAll(n => n.Age > 20 && DateTime.Now <= n.DateOfFinish && n.Status == Status.Active);
        Info(students);
    }

    public void Over20StudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Age > 20 && DateTime.Now <= s.DateOfFinish && s.Status == Status.Active
             select s).ToList();
        Info(students);
    }

    // Task 5
    public void YoungStudentsMethod()
    {
        var students = this.students.FindAll(n => n.Age - (DateTime.Now.Year - n.DateOfStart.Year) == 16);
        Info(students);
    }

    public void YoungStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Age - (DateTime.Now.Year - s.DateOfStart.Year) == 16
             select s).ToList();
        Info(students);
    }

    // Task 6
    public void AdultStudentsMethod()
    {
        var students = this.students.FindAll(n => n.Age - (DateTime.Now.Year - n.DateOfStart.Year) >= 18);
        Info(students);
    }

    public void AdultStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Age - (DateTime.Now.Year - s.DateOfStart.Year) >= 18
             select s).ToList();
        Info(students);
    }
    // Task 7
    public void A_I_StudentsMethod()
    {
        var students = this.students.FindAll(n => n.FirstName[0] == 'A' || n.FirstName[0] == 'I');
        Info(students);
    }

    public void A_I_StudentsQuery()
    {
        var students =
            (from s in this.students
             where s.FirstName[0] == 'A' || s.FirstName[0] == 'I'
             select s).ToList();
        Info(students);
    }

    // Task 8

    public void SameNameStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.FirstName[0] == s.LastName[0]
             select s).ToList();
        Info(students);
    }
    public void SameNameStudentsMethod()
    {
        var students = this.students.FindAll(n => n.FirstName[0] == n.FirstName[0]);
        Info(students);
    }

    // Task 9
    public void BecomeAdultStudentsQuery()
    {
        var students =
            (from s in this.students
             where s.Age >= 18
             select s).ToList();
        Info(students);
    }
    public void BecomeAdultStudentsMethod()
    {
        Info(students);
    }

    // Task 10
    public void Task10Method()
    {
        var students = this.students.
        Where(
            n => n.Gender != Gender.Female &&
            n.Status == Status.Active &&
            DateTime.Now.Year - n.DateOfStart.Year >= 2 &&
            n.Age < 16)
        .ToList();
        Info(students);
    }

    public void Task10Query()
    {
        var students =
            (from s in this.students
            where 
                s.Gender != Gender.Female &&
                s.Status == Status.Active &&
                DateTime.Now.Year - s.DateOfStart.Year >= 2 &&
                s.Age < 16
            select s)
        .ToList();
        
        Info(students);
    }
}
