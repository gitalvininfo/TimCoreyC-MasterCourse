namespace ConsoleApp1
{
    public class CommisionEmployee : Employee
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal initialPay = base.GetPaycheckAmount(hoursWorked);
            return initialPay + CommissionAmount;
        }
    }


}