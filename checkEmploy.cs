using System;


namespace EmployWageComputationProblem
{
    public class checkEmploy
    {
        /// <summary>
        /// Check employs are absent or present.
        /// </summary>
        public static void EmployAbsentOrPresent()
        {
            Random random = new Random();
            int presenty = random.Next(2);

            if (presenty == 1)
            {
                Console.WriteLine("Employ is Present");
                EmployWage.CalculateEmpWage();
            }
            else if (presenty == 0)
            {
                Console.WriteLine("Employ is Absent");
                Console.WriteLine("Employ per Day Wage is : 0");
            }

        }
    }
}
