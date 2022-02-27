using System;

namespace EmployWageComputationProblem
{
    public class PartTimeEmployWage
    {
        /// <summary>
        /// Calculate Part Time Employ wage
        /// </summary>
        public int isPartTimeEmployWage;
        public int isPartTimeHrs = 8;
        public static void findPartTimeWage()
        {
            EmployWage obj2 = new EmployWage();
            PartTimeEmployWage obj3 = new PartTimeEmployWage();

            obj3.isPartTimeEmployWage = obj2.empWagePerHour * obj3.isPartTimeHrs;
            Console.WriteLine("Part Time Employ Wage is : {0}", +obj3.isPartTimeEmployWage);
            MonthlyWage.findMonthlyWage();
        }
    }
}
