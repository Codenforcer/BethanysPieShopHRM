// See https://aka.ms/new-console-template for more information

using BethanysPieShopHRM.HR;

Employee bethany = new StoreManager(55156, "Bethany", "Smith", "bethany@hotmail.com", new DateTime(1979, 1, 16), 25);
Manager mary = new Manager(748, "Mary", "Jones", "mary@hotmail.com", new DateTime(1965, 1, 16), 30);
JuniorResearcher bobjunior = new JuniorResearcher(11231, "Bob", "Spencer", "bobs@hotmail.com", new DateTime(1988, 1, 23), 17);
Employee kevin = new StoreManager(81131, "Kevin", "Marks", "kevin@hotmail.com", new DateTime(1953, 12, 12), 10);
Employee kate = new StoreManager(100, "Kate", "Gregg", "kate@hotmail.com", new DateTime(1993, 8, 8), 10);

List<Employee> employees = new List<Employee>();
employees.Add(bethany);
employees.Add(kevin);
employees.Add(kate);
employees.Add(mary);
employees.Add(bobjunior);

employees.Sort();

foreach (var employee in employees)
{
    employee.DisplayEmployeeDetails();
}





Console.ReadLine();
