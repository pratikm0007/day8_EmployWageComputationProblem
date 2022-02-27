using System;

namespace EmployWageComputationProblem
{
    public class WagesCondition
    {
        /// <summary>
        /// Wages condition
        /// </summary>
        public int hrs = 101;
        public int dayHrs = 20 * 8;
        public int calculateWages1;
        public int calculateWages2;
        public static void calWageTillCondition()
        {
            WagesCondition obj1 = new WagesCondition();
            EmployWage obj2 = new EmployWage();

            for (int count = 1; count < obj1.hrs; count++)
            {

                obj1.calculateWages1 = count * obj2.empWagePerHour;
                Console.WriteLine("Total Working Hour wage for a Month is : {0}", +obj1.calculateWages1);
                if (count < obj1.dayHrs)
                {
                    obj1.calculateWages2 = count * obj2.empWagePerHour;
                    Console.WriteLine("Total Working Day wage for a Month is : {0}", +obj1.calculateWages2);

                }

            }
        }
    }
}
