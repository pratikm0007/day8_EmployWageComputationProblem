using System;

namespace EmployWageComputationProblem
{
    public class EmployWage
    {
        /// <summary>
        /// The daily employ wage
        /// </summary>
        public int dailyEmployWage;
        public int fullDayHours = 8;
        public int empWagePerHour = 20;
        public static void CalculateEmpWage()
        {
            EmployWage obj2 = new EmployWage();

            obj2.dailyEmployWage = obj2.empWagePerHour * obj2.fullDayHours;
            Console.WriteLine("Employ Daily Wage is :{0} ", +obj2.dailyEmployWage);
            PartTimeEmployWage.findPartTimeWage();
        }
    }
}
