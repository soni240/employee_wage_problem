// See https://aka.ms/new-console-template for more information
class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public static int computeEmpWage(string company,int empRatePerHour, int numOfWorkingDay5, int maxHoursPerMonth)
    {
        int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
        while (totalEmpHrs <= maxHoursPerMonth && totalworkingDays < numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                case IS_FULL_TIME:
                    empHrs = 8;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalworkingDays + "EmpHrs :" + empHrs);
        }
        int totalEmpWage = totalEmpHrs * empRatePerHour;
        Console.WriteLine("total Emp Wage for company : " + cpmpany + " is: " + totalEmpWage);
        return totalEmpWage;
        public static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
