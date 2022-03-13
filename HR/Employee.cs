namespace BethanysPieShopHRM.HR
{
    public class Employee : IEmployee, IComparable
    {
        // Fields
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        private static double taxRate = 0.15;

        private DateTime birthDay;

        #region
        public int Id
        { get { return id; } set { id = value; } }
        public string FirstName
        { get { return firstName; } set { firstName = value; } }

        public string LastName
        { get { return lastName; } set { lastName = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public int NumberOfHoursWorked
        { get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; } }

        public double Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                    wage = 0;
                else
                    wage = value;
            }

        }

        public double? HourlyRate
        { get { return hourlyRate; } set { hourlyRate = value; } }


        public DateTime BirthDay
        { get { return birthDay; } set { birthDay = value; } }

        #endregion

        #region
        public Employee(int id, string first, string last, string em, DateTime bd, double? rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate ?? 10;

        }


        // Methods
        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;

            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\n");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"YOU'VE DONE A GREAT JOB, {FirstName}");
        }

        public int CompareTo(object obj)
        {
            var otherEmployee = (Employee)obj;
            if (Id > otherEmployee.Id)
                return 1;
            else if (Id < otherEmployee.Id)
                return -1;
            else
                return 0;
        }
        #endregion
    }

}
