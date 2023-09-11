//var filePath = @"C:\Users\n-abb\OneDrive\Documents\FileCreateWrite\FileCreateWrite.txt";

//StreamReader reader = new StreamReader(filePath);

//string? line;

//while ((line = reader.ReadLine()) != null)
//{
//    Console.WriteLine(line);
//}

//reader.Close();

/**********************************/
//Student student = new Student("Paul", 30);

//Console.WriteLine(student.PrintStudentDetails());

/**********************************/


List<Person> persons = new List<Person>() {
    new () { Id = 1, Name = "Mo" },
    new () { Id = 2, Name = "Naz" }
};

List<Employee> employees = new List<Employee>() {
    new (){Id = 4, PersonId = 1, Salary = 1000 },
    new (){Id = 5, PersonId = 2, Salary = 2000 },
};

List<Payroll> payrolls = new List<Payroll>()
{
    new (){Month = 1, EmployeeId = 4, PaidValue = 1000 },
    new (){Month = 2, EmployeeId = 4, PaidValue = 1000 },
    new (){Month = 3, EmployeeId = 4, PaidValue = 1000 },
    new (){Month = 4, EmployeeId = 4, PaidValue = 1000 },
    new (){Month = 1, EmployeeId = 5, PaidValue = 2000 }
};



var result = from payroll in payrolls
             join emp in employees on payroll.EmployeeId equals emp.Id
             join person in persons on emp.PersonId equals person.Id
             group payroll by new { person.Name } into res

             select new
             {
                 Name = res.Key.Name,
                 Sum = res.Sum(s => s.PaidValue),
             };

//var result = from p in payrolls
//             join emp in employees on p.EmployeeId equals emp.Id
//             join person in persons on emp.PersonId equals person.Id
//             group p by new { p.EmployeeId } into prp

//             select new
//             {
//                 Name = persons.FirstOrDefault(p => p.Id == employees.FirstOrDefault(x => x.Id == prp.Key.EmployeeId).PersonId).Name,
//                 Sum = payrolls.Where(p => p.EmployeeId == prp.Key.EmployeeId).Sum(s => s.PaidValue),
//             };

//var payrollNames = payrolls.Join(employees, payroll => payroll.EmployeeId, e => e.Id, (pr, e) => new { pr.Month, pr.PaidValue, e.Salary, e.PersonId })
//                          .Join(persons, pr => pr.PersonId, p => p.Id, (pr, p) => new { pr.Month, pr.PaidValue, pr.Salary, p.Name }).GroupBy(p => p.Name).ToList();

foreach (var r in result)
{
    Console.WriteLine($"{r.Name} : {r.Sum}");
}

public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
}

public class Employee
{
    public int PersonId { get; set; }
    public int Salary { get; set; }

    public int Id { get; set; }
}

public class Payroll
{
    public int Month { get; set; }

    public int PaidValue { get; set; }

    public int EmployeeId { get; set; }
}

