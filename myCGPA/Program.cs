using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace myCGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string firstCourse, secondCourse, thirdCourse, fourthCourse, fifthCourse;

                Console.Write("Insert the First Course: ");
                //firstCourse = Console.ReadLine();
               // bool course = true;
            
                while (true)
                {
                    firstCourse = Console.ReadLine();
                      if (firstCourse == "" || firstCourse.Length != 6)
                      {
                         Console.WriteLine("Please Input your course code of 6 characters");
                         continue;
                      }
                      break;
                
                }
            Console.Write("Insert the Second Course: ");

            while (true )
            {
                secondCourse = Console.ReadLine();
                if (secondCourse == "" || secondCourse.Length != 6)
                {
                    Console.WriteLine("Please Input your course code of 6 characters");
                    continue;
                }
                break ;
            }

                          
        Console.Write("Insert the Third Course: ");
            while (true)
            {
                thirdCourse = Console.ReadLine();
                if (thirdCourse == "" || thirdCourse.Length != 6)
                {
                    Console.WriteLine("Please Input your course code of 6 charcters");
                    continue;
                }
                break;
            }
                
        Console.Write("Insert the Fourth Course: ");
            while (true)

            {
                fourthCourse = Console.ReadLine();
                if (fourthCourse == "" || fourthCourse.Length != 6)
                {
                    Console.WriteLine("Please Input your course code of 6 charcters");
                    continue ;
                }
                break;
            }
        Console.Write("Insert the Fifth Course: ");
            while (true)

            {
                fifthCourse = Console.ReadLine();
                if (fifthCourse == "" || fifthCourse.Length != 6)
                {
                    Console.WriteLine("Please Input your course code of 6 characters");
                    continue;
                }
                break;
            }


            int courseUnit1, courseUnit2, courseUnit3, courseUnit4, courseUnit5; //gradeUnit1, gradeUnit2, gradeUnit3, gradeUnit4, gradeUnit5;
            
            
        Console.Write("Enter Credit unit of First Course: ");

        while (true)
            {
                
               bool unit1 = int.TryParse(Console.ReadLine(), out courseUnit1 );
                if (unit1 == false || courseUnit1 <=0 || courseUnit1 > 5)
                {
                    Console.WriteLine("Wrong input.. Input only numbers 1-5");
                    continue;
                }
                break;
        }

            Console.Write("Enter Credit unit of Second Course: ");

            while (true)
            {
                bool unit2 = int.TryParse(Console.ReadLine(), out courseUnit2 );
                if (unit2 == false || courseUnit2 <=0 || courseUnit2 > 5)
                {
                    Console.WriteLine("Wrong Input.. Input only numbers 1-5");
                    continue;
                }
                break;

            }

            Console.Write("Enter Credit unit for Third Course: ");
            while (true)
            {
                bool unit3 = int.TryParse(Console.ReadLine(), out courseUnit3 );
                if (unit3 == false || courseUnit3 <=0 || courseUnit3 > 5)
                {
                    Console.WriteLine("Wrong Input... Input Only numbers 1-5");
                    continue;
                }
                break;
            }

            Console.Write("Enter Credit Unit of Fourth Course: ");
            while (true)
            {
                bool unit4 = int.TryParse(Console.ReadLine(), out courseUnit4 );
                if (unit4 == false || courseUnit4 <=0 || courseUnit4 > 5)
                {
                    Console.WriteLine(" Wrong Input... Input only numbers 1-5");
                    continue; 

                }
                break;
            }

            Console.Write("Enter Credit Unit of Fifth Course: ");
            while (true)
            {
                bool unit5 = int.TryParse(Console.ReadLine(), out courseUnit5 );
                if (unit5 == false || courseUnit5 <=0 || courseUnit5 > 5)
                {
                    Console.WriteLine("Wrong Input...Input only Numbers 1-5");
                    continue; 
                    }
                break ;
            }

            int firstScore, secondScore, thirdScore, fourthScore, fifthScore;

            Console.Write("Input Your First Score: ");
            
            while (true)
            {
                bool score1 = int.TryParse(Console.ReadLine(), out firstScore);
                if (score1 == false || firstScore >100 || firstScore <0)
                {
                    Console.WriteLine("Input values only from 1-100");
                    continue;
                }
                break;

            }

            Console.Write("Input Your Second Score: ");
            
            while (true)
            {
                bool score2 = int.TryParse(Console.ReadLine(), out secondScore);
                if (score2 == false || secondScore >100 || secondScore <0)
                {
                    Console.WriteLine("Input Value only from 1-100");
                    continue ;
                }
                break;
            }

            Console.Write("Input Your Third Score: ");
                while (true)
            {
                bool score3 = int.TryParse(Console.ReadLine(), out thirdScore);
                if (score3 == false || thirdScore >100 || thirdScore <0)
            {
                    Console.WriteLine("Input a Value only from 1-100");
                    continue;
            }
                break;
            }

            Console.Write("Input Your Fourth Score: ");
            while (true)
            {
                bool score4 = int.TryParse(Console.ReadLine(), out fourthScore);
                if (score4 == false || fourthScore > 100 || fourthScore < 0)
                {
                    Console.WriteLine("Input a Value only from 1-100");
                    continue;
                }
                break;
            }

            Console.Write("Input Your Fifth Score: ");
            while (true)
            {
                bool score5 = int.TryParse(Console.ReadLine(), out fifthScore);
                if (score5 == false || fifthScore > 100 || fifthScore< 0)
                {
                    Console.WriteLine("Input a Value only from 1-100");
                    continue;
                }
                break;
            }

            int gradeUnit1 = firstScore >= 70 ? 5 : firstScore >= 60 && firstScore < 70 ? 4 : firstScore >= 50 && firstScore < 60 ? 3 : firstScore >= 45 && firstScore < 50 ? 2 : firstScore >= 40 && firstScore < 45 ? 1 : 0;
            int gradeUnit2 = secondScore >= 70 ? 5 : secondScore >= 60 && secondScore< 70 ? 4 : secondScore >= 50 && secondScore < 60 ? 3 : secondScore >= 45 && secondScore < 50 ? 2 : secondScore >= 40 && secondScore < 45 ? 1 : 0;
            int gradeUnit3 = thirdScore >= 70 ? 5 : thirdScore >= 60 && thirdScore < 70 ? 4 : thirdScore >= 50 && thirdScore < 60 ? 3 : thirdScore >= 45 && thirdScore < 50 ? 2 : thirdScore >= 40 && thirdScore < 45 ? 1 : 0;
            int gradeUnit4 = fourthScore  >= 70 ? 5 : fourthScore >= 60 && fourthScore < 70 ? 4 : fourthScore >= 50 && fourthScore < 60 ? 3 : fourthScore >= 45 && fourthScore < 50 ? 2 : fourthScore >= 40 && fourthScore < 45 ? 1 : 0;
            int gradeUnit5 = fifthScore >= 70 ? 5 : fifthScore >= 60 && fifthScore < 70 ? 4 : fifthScore >= 50 && fifthScore < 60 ? 3 : fifthScore >= 45 && fifthScore < 50 ? 2 : fifthScore >= 40 && fifthScore < 45 ? 1 : 0; 

            string grade1 = firstScore >= 70 ? "A"  : firstScore >= 60 && firstScore < 70 ? "B" : firstScore >= 50 && firstScore < 60 ? "C" : firstScore >= 45 && firstScore < 50 ? "D" : firstScore >= 40 && firstScore < 45 ? "E" : "F";
            string grade2 = secondScore >= 70 ? "A"  : secondScore >= 60 && secondScore < 70 ? "B" : secondScore >= 50 && secondScore < 60 ? "C" : secondScore >= 45 && secondScore < 50 ? "D" : secondScore >= 40 && secondScore < 45 ? "E" : "F";
            string grade3 = thirdScore >= 70 ? "A" : thirdScore >= 60 && thirdScore < 70 ? "B" : thirdScore >= 50 && thirdScore < 60 ? "C" : thirdScore >= 45 && thirdScore < 50 ? "D" : thirdScore >= 40 && thirdScore < 45 ? "E" : "F";
            string grade4 = fourthScore >= 70 ? "A" : fourthScore >= 60 && fourthScore < 70 ? "B" : fourthScore >= 50 && fourthScore < 60 ? "C" : fourthScore >= 45 && fourthScore < 50 ? "D" : fourthScore >= 40 && fourthScore < 45 ? "E" : "F";
            string grade5 = fifthScore >= 70 ? "A": fifthScore >= 60 && fifthScore < 70 ? "B" : fifthScore >= 50 && fifthScore < 60 ? "C" : fifthScore >= 45 && fifthScore < 50 ? "D" : fifthScore >= 40 && fifthScore < 45 ? "E" : "F";

            string remarks1 = firstScore >= 70 ? "Excellent" : firstScore >= 60 && firstScore < 70 ? "Very Good" : firstScore >= 50 && firstScore < 60 ? "Good" : firstScore >= 45 && firstScore < 50 ? "Fair" : firstScore >= 40 && firstScore < 45 ? "Pass" : "Fail";
            string remarks2 = secondScore >= 70 ? "Excellent" : secondScore >= 60 && secondScore < 70 ? "Very Good" : secondScore >= 50 && secondScore < 60 ? "Good" : secondScore >= 45 && secondScore < 50 ? "Fair" : secondScore >= 40 && secondScore < 45 ? "Pass" : "Fail";
            string remarks3= thirdScore >= 70 ? "Excellent" : thirdScore >= 60 && thirdScore < 70 ? "Very Good" : thirdScore >= 50 && thirdScore < 60 ? "Good" : thirdScore >= 45 && thirdScore < 50 ? "Fair" : thirdScore >= 40 && thirdScore < 45 ? "Pass" : "Fail";
            string remarks4 = fourthScore >= 70 ? "Excellent" : fourthScore >= 60 && fourthScore < 70 ? "Very Good" : fourthScore >= 50 && fourthScore < 60 ? "Good" : fourthScore >= 45 && fourthScore < 50 ? "Fair" : fourthScore >= 40 && fourthScore < 45 ? "Pass" : "Fail";
            string remarks5 = fifthScore >= 70 ? "Excellent" : fifthScore >= 60 && fifthScore < 70 ? "Very Good" : fifthScore >= 50 && fifthScore < 60 ? "Good" : fifthScore >= 45 && fifthScore < 50 ? "Fair" : fifthScore >= 40 && fifthScore < 45 ? "Pass" : "Fail";

            Console.WriteLine("\n");
            double totalUnitRegistered = courseUnit1 + courseUnit2 + courseUnit3 + courseUnit4 + courseUnit5;
            Console.WriteLine("TOTAL COURSE UNIT REGISTERED IS:  " + totalUnitRegistered);
          double totalWeightPoint = (courseUnit1 * gradeUnit1) + (courseUnit2 * gradeUnit2) + (courseUnit3 * gradeUnit3) + (courseUnit4 * gradeUnit4) + (courseUnit5 * gradeUnit5);
            Console.WriteLine("TOTAL WEIGHT POINT IS:  " + totalWeightPoint);

            Console.WriteLine("\n");

            Console.WriteLine("Your CGPA is:  " + totalWeightPoint / totalUnitRegistered);


  
            Console.WriteLine("\n");
Console.WriteLine("------------------------------------FIND YOUR CGRADES BELOW:----------------------------------");

Console.WriteLine("|----------------|---------------|---------|---------------|---------------|------------|");
Console.WriteLine("| COURSE & CODE  |  COURSE UNIT  |  GRADE  |   GRADE UNIT  |  WEIGHT PT.   |   REMARK   |");
Console.WriteLine("|----------------|---------------|---------|---------------|---------------|------------|");
Console.Write ("|" + firstCourse); Console.Write("          |" + courseUnit1 );  Console.Write("              |" + grade1); Console.Write("         |" + gradeUnit1); Console.Write("              |" + (courseUnit1 * gradeUnit1)); Console.WriteLine("             |" + remarks1);
Console.Write ("|" + secondCourse); Console.Write("          |" + courseUnit2 );  Console.Write("              |" + grade2); Console.Write("         |" + gradeUnit2); Console.Write("              |" + (courseUnit2 * gradeUnit2)); Console.WriteLine("             |" + remarks2);
Console.Write ("|" + thirdCourse); Console.Write("          |" + courseUnit3 );  Console.Write("              |" + grade3); Console.Write("         |" + gradeUnit3); Console.Write("              |" + (courseUnit3 * gradeUnit3)); Console.WriteLine("             |" + remarks3);
Console.Write ("|" + fourthCourse); Console.Write("          |" + courseUnit4 );  Console.Write("              |" + grade4); Console.Write("         |" + gradeUnit4); Console.Write("              |" + (courseUnit4 * gradeUnit4)); Console.WriteLine("             |" + remarks4);
Console.Write ("|" + fifthCourse); Console.Write("          |" + courseUnit5 );  Console.Write("              |" + grade5); Console.Write("         |" + gradeUnit5); Console.Write("              |" + (courseUnit5 * gradeUnit5)); Console.WriteLine("             |" + remarks5);



        }
    }
}
