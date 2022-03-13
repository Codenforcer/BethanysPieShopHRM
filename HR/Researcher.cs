namespace BethanysPieShopHRM.HR
{
    public class Researcher : Employee
    {
        public Researcher(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {

        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste!");
        }
    }

    // This class inherients from the above class.
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {

        }
    }

}
