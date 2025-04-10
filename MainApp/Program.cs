using Domain;
using Infrastructure;

StudentService service = new StudentService();
var students = new List<Student>
{
    new Student(1, "Zulfiqor","Alimamatov", 20, Gender.Male, Status.Active, DateTime.Parse("2022-09-01"), DateTime.Parse("2026-07-01")),
    new Student(2, "Ahmad","Odinaev", 21, Gender.Male, Status.Active, DateTime.Parse("2021-09-01"), DateTime.Parse("2025-07-01")),
    new Student(3, "Sara","Soliev", 19, Gender.Female, Status.Inactive, DateTime.Parse("2023-09-01"), DateTime.Parse("2027-07-01")),
    new Student(4, "John","Johnson", 20, Gender.Male, Status.Active, DateTime.Parse("2020-09-01"), DateTime.Parse("2024-07-01")),
    new Student(5, "Emily","Klark", 20, Gender.Female, Status.Inactive, DateTime.Parse("2022-09-01"), DateTime.Parse("2026-07-01")),
    new Student(6, "Michael","Mike", 23, Gender.Male, Status.Active, DateTime.Parse("2019-09-01"), DateTime.Parse("2023-07-01")),
    new Student(7, "Sophia","Salamandra", 20, Gender.Female, Status.Inactive, DateTime.Parse("2024-09-01"), DateTime.Parse("2028-07-01")),
    new Student(8, "David","Dovud", 21, Gender.Male, Status.Active, DateTime.Parse("2021-09-01"), DateTime.Parse("2025-07-01")),
    new Student(9, "Emma","Stone", 20, Gender.Female, Status.Inactive, DateTime.Parse("2022-09-01"), DateTime.Parse("2026-07-01")),
    new Student(10, "Liam","Kirk", 22, Gender.Male, Status.Active, DateTime.Parse("2020-09-01"), DateTime.Parse("2024-07-01"))
};
foreach (var student in students)
{
    service.AddStudent(student);
}

// Method syntax

service.MaleStudentsMethod();
service.MaleStudentsQuery();

service.ActiveStudentsMethod();
service.ActiveStudentsQuery();

service.ZeroStudentsMethod();
service.ZeroStudentsQuery();

service.Over20StudentsMethod();
service.Over20StudentsQuery();

service.YoungStudentsMethod();
service.YoungStudentsQuery();

service.AdultStudentsMethod();
service.AdultStudentsQuery();

service.A_I_StudentsMethod();
service.A_I_StudentsQuery();

service.SameNameStudentsQuery();
service.SameNameStudentsMethod();

service.BecomeAdultStudentsQuery();
service.BecomeAdultStudentsMethod();

service.Task10Method();
service.Task10Query();