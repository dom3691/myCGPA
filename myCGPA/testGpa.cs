using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCGPA
{
    internal class testGpa
    {
        public  static void Main ( )
        {
            Console.Write(" How Many Course Do you Offer?:  ");

            int numberOfCourses = int.Parse(Console.ReadLine());

            string[] courseName = new string[numberOfCourses];
            int[] courseUnit = new int[numberOfCourses];
            int[] courseScore = new int[numberOfCourses];
            string[] grade = new string[numberOfCourses];
            string[] Remark = new string[numberOfCourses];
            int[] gradeUnit = new int[numberOfCourses];
            int[] weightPoint = new int[numberOfCourses];

            double gpa;
            int totalWeight = 0, totalCourseUnitReg = 0, totalCourseUnitPassed = 0;

           
            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine("Enter Course Name and Course Code: e.g Mat111, Bio121, etc ");
                courseName[i]= Console.ReadLine();


                Console.WriteLine("Enter Course Unit:  e.g from 1 - 5");
                courseUnit[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Course Score:   e.g from 0-100");
                courseScore[i] = int.Parse(Console.ReadLine());

                if (courseScore[i] >= 70 && courseScore[i] <=100)
                {
                    gradeUnit[i] = 5;
                    grade[i] = "A";
                    Remark[i] = "Excellent";
                }
                else if (courseScore[i] >= 60 && courseScore[i] < 70)
                {
                    gradeUnit[i] = 4;
                    grade[i] = "B";
                    Remark[i] = " Very Good";
                }
                else if (courseScore[i] >= 50 && courseScore[i] < 59)
                {
                    gradeUnit[i] = 3;
                    grade[i] = "C";
                    Remark[i] = "Good";
                }

                else if (courseScore[i] >= 45 && courseScore[i] <= 49)
                {
                    gradeUnit[i] = 2;
                    grade[i] = "D";
                    Remark[i] = "Fair";
                }
                else if (courseScore[i] >= 40 && courseScore[i] <= 40)
                {
                    gradeUnit[i] = 1;
                    grade[i] = "E";
                    Remark[i] = "Pass";
                }
                else if (courseScore[i] < 40 && courseScore[i] >=0 )
                {
                    gradeUnit[i] = 0;
                    grade[i] = "F";
                    Remark[i] = "Fail";
                }
                weightPoint[i] = courseUnit[i] * gradeUnit[i];
            }

            gpa = ((double)totalWeight / totalCourseUnitPassed);
           

            PrintTable tableView = new PrintTable();
            tableView.view(courseName, courseUnit, grade, gradeUnit, gpa,Remark, numberOfCourses, totalWeight, weightPoint, totalCourseUnitPassed, totalCourseUnitReg);


            for (int i = 0; i < numberOfCourses; i++)
            {
                totalWeight = totalWeight + weightPoint[i];
                while (gradeUnit[i] > 0)
                {
                    totalCourseUnitPassed = totalCourseUnitPassed + gradeUnit[i];
                }
                totalCourseUnitReg = totalCourseUnitReg + courseUnit[i];
            }
            Console.WriteLine("Total Course Unit Registered is: " + totalCourseUnitReg);
            Console.WriteLine("Total Course Unit Passed is: " + totalCourseUnitPassed);
            Console.WriteLine("Total Weight Point is: " + totalWeight);

            gpa = totalWeight / totalCourseUnitReg;
            Console.WriteLine("Your GPA is: " + gpa.ToString("0.00"));




        }
    }
}
