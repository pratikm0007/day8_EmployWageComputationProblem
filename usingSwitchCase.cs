using System;

namespace EmployWageComputationProblem
{
    public class usingSwitchCase
    {
        /// <summary>
        /// Uses the switch case.
        /// </summary>
        public static void useSwitchCase()
        {
            Random random = new Random();
            int presenty = random.Next(2);
            switch (presenty)
            {
                case 1:
                    Console.WriteLine("Employ is Present");
                    EmployWage.CalculateEmpWage();
                    break;
                default:
                    Console.WriteLine("Employ is Absent");
                    Console.WriteLine("Employ per Day Wage is : 0");
                    break;
            }
        }
    }
}
