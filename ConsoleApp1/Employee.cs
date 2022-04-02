namespace ConsoleApp1
{
    public class Employee : Person
    {
        public decimal HourlyRate { get; set; }
        
        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }


}