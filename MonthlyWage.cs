using System;

namespace EmployWageComputationProblem
{
    public class MonthlyWage
    {
        /// <summary>
        /// Calculate Monthly wage
        /// </summary>
        public const int WorkingDayPerMonth = 20;
        public static void findMonthlyWage()
        {
            EmployWage obj2 = new EmployWage();
            int WagesOfMonth = WorkingDayPerMonth * obj2.dailyEmployWage;
            Console.WriteLine("Wages for a Month is {0}", +WagesOfMonth);
            WagesCondition.calWageTillCondition();

        }
    }
}
