// See https://aka.ms/new-console-template for more information
public class EmpWageBuilderObject
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private string company;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHourPerMonth;
    private int totalEmpWage;

    public EmpWageBuilderObject(string company, int empRateHour, int numOfWorkingDays, int maxHoursPerMonth
        {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHourPerMonth = maxHoursPerMonth;
    }
    public void computeEmpWage()
    {
        int empHrs = 0; totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                    case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);

        }
        totalEmpWage = totalEmpHrs * this.empRatePerHour;
        Console.WriteLine("Total emp wage for company : " + company + " is : " + totalEmpWage);
    }
    public string toString()
    {
        return "total emp wage for company : " + this.company + " is: " + this.totalEmpWage;
    }
}
