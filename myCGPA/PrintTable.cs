using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myCGPA
{
    public class PrintTable
    {
        
        internal void view(string[] courseName, int[] courseUnit, string[] grade, int[] gradeUnit, double gpa, string[] Remark, int numberOfCourses, int totalWeight, int[] weightPoint, int totalCourseUnitPassed, int totalCourseUnitReg)
        {
            Console.WriteLine("------------------------------------FIND YOUR CGRADES BELOW:----------------------------------");

            Console.WriteLine("|----------------|---------------|---------|---------------|---------------|------------|");
            Console.WriteLine("| COURSE & CODE  |  COURSE UNIT  |  GRADE  |   GRADE UNIT  |  WEIGHT PT.   |   REMARK   |");
            Console.WriteLine("|----------------|---------------|---------|---------------|---------------|------------|");

            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine("|{0,13} | {1,13} | {2,9} | {3,13} | {4,13} | {5,13}|", courseName[i], courseUnit[i], grade[i], gradeUnit[i], weightPoint[i], Remark[i]);

            }

            Console.WriteLine("|----------------|---------------|---------|---------------|---------------|------------|");


            

        }

    }
}
