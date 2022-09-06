using AssignmentsCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssignmentOne assignmentOne = new AssignmentOne();
            int number = 20;
            int year = 2020;
            int number1 = 208, number2 = 60, number3 = 45;
            int positiveNumber = 10, negativeNumber = -20, zero = 0;
            #region Question one => Using Conditional operator.. 
            Console.WriteLine("Question one => Using Conditional operator started..");
            Console.WriteLine($"{number} : IsPositive: {assignmentOne.IsPositive1(number)}");
            Console.WriteLine($"{number} : IsEven : {assignmentOne.IsEven1(number)}");
            Console.WriteLine($"{year} : IsLeap : {assignmentOne.IsLeap1(year)}");
            Console.WriteLine($"Maximum number between {number1} and {number2} is : {assignmentOne.MaxInTwoNumber1(number1,number2)}");
            Console.WriteLine($"Minimum number between {number1} and {number2} is : {assignmentOne.MinInTwoNumber1(number1, number2)}");
            Console.WriteLine($"Maximum number between {number1} and {number2} and {number3} is : {assignmentOne.MaxInThreeNumber1(number1, number2, number3)}");
            Console.WriteLine($"Minimum number between {number1} and {number2} and {number3} is : {assignmentOne.MinInThreeNumber1(number1, number2, number3)}");
            Console.WriteLine("Question one => Using Conditional operator Ended..");
            #endregion

            #region Question Two => Using IF.. 
            
            Console.WriteLine("\n\nQuestion one => Using IF statement started..");
            Console.WriteLine($"{number} : IsPositive: {assignmentOne.IsPositive2(number)}");
            Console.WriteLine($"{number} : IsEven : {assignmentOne.IsEven2(number)}");
            Console.WriteLine($"{year} : IsLeap : {assignmentOne.IsLeap2(year)}");
            Console.WriteLine($"Maximum number between {number1} and {number2} is : {assignmentOne.MaxInTwoNumber2(number1, number2)}");
            Console.WriteLine($"Minimum number between {number1} and {number2} is : {assignmentOne.MinInTwoNumber2(number1, number2)}");
            Console.WriteLine($"Maximum number between {number1} and {number2} and {number3} is : {assignmentOne.MaxInThreeNumber2(number1, number2, number3)}");
            Console.WriteLine($"Minimum number between {number1} and {number2} and {number3} is : {assignmentOne.MinInThreeNumber2(number1, number2, number3)}");
            Console.WriteLine($"{positiveNumber} is  {assignmentOne.IsPositiveOrNegativeOrZero(positiveNumber)}");
            Console.WriteLine($"{negativeNumber} is  {assignmentOne.IsPositiveOrNegativeOrZero(negativeNumber)}");
            Console.WriteLine($"{zero} is  {assignmentOne.IsPositiveOrNegativeOrZero(zero)}");
            Console.WriteLine("Question one => Using IF statement Ended..");
            #endregion


            #region Question Three..
            float percentage = assignmentOne.CalculatePercentage(80, 80, 80, 80, 80, 78);
            Console.WriteLine($"Percentage : {percentage}");
            string grade = assignmentOne.CalculateGrade(percentage);
            Console.WriteLine($"Grade : {grade}");

            #endregion
            Console.ReadLine();


        }
    }
}
