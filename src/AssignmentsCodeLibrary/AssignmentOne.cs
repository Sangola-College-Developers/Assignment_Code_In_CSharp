using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AssignmentsCodeLibrary
{
    /// <summary>
    /// Provides all methods needs for Asignment one..
    /// </summary>
    public class AssignmentOne
    {
        #region Question one => Using Conditional Operator.. 
        
        /// <summary>
        /// To check entered number is positive or negative
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns boolean -> True if number is Positive else False</returns>
        public bool IsPositive1(int number)
        {
            return (number > 0);
        }

        /// <summary>
                /// To check entered number is Even or Odd
                /// </summary>
                /// <param name="number"></param>
                /// <returns>Returns boolean -> True if number is Even else False</returns>
        public bool IsEven1(int number)
        {
            return (number % 2==0);

        }

        /// <summary>
        /// To check entered year is Leap year or not..
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Returns boolean -> True if year is Leap else False</returns>
        public bool IsLeap1(int year)
        {
            return (year % 4 == 0);
        }

        /// <summary>
        /// To Find maximum numbers between given two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns int : - Maximum number between provided two numbers..</returns>
        public int MaxInTwoNumber1(int number1, int number2)
        {
            return (number1 > number2 ? number1 : number2);            
        }

        /// <summary>
        /// To Find minimum numbers between given two numbers...
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns int : - Minimum number between provided two numbers..</returns>
        public int MinInTwoNumber1(int number1, int number2)
        {
            return (number1 < number2 ? number1 : number2);
        }

        /// <summary>
        /// To Find Maximum number between given three numbers...
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns>Returns int : - Maximum number between provided three numbers..</returns>
        public int MaxInThreeNumber1(int number1, int number2, int number3)
        {
            return (number1 > number2 ? (number1 > number3 ? number1 : number3):
                                        (number2 > number3 ? number2 : number3)) ;
        }

        /// <summary>
        /// To Find Minimum number between given three numbers...
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns>Returns int : - Minimum number between provided three numbers..</returns>
        public int MinInThreeNumber1(int number1, int number2, int number3)
        {
            return (number1 < number2 ? (number1 < number3 ? number1 : number3) :
                                        (number2 < number3 ? number2 : number3));
        }
        #endregion

        #region Question Two => Using IF Statement
        /// <summary>
        /// To check entered number is positive or negative
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns boolean -> True if number is Positive else False</returns>
        public bool IsPositive2(int number)
        {
            if(number > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// To check entered number is Even or Odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns boolean -> True if number is Even else False</returns>
        public bool IsEven2(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// To check entered year is Leap year or not..
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Returns boolean -> True if year is Leap else False</returns>
        public bool IsLeap2(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// To Find maximum numbers between given two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns int : - Maximum number between provided two numbers..</returns>
        public int MaxInTwoNumber2(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number1;
            }
            return number2;
        }

        /// <summary>
        /// To Find minimum numbers between given two numbers...
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns int : - Minimum number between provided two numbers..</returns>
        public int MinInTwoNumber2(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            return number2;
        }

        /// <summary>
        /// To Find Maximum number between given three numbers...
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns>Returns int : - Maximum number between provided three numbers..</returns>
        public int MaxInThreeNumber2(int number1, int number2, int number3)
        {
            if(number1 > number2)
            {
                if (number1 > number3)
                    return number1;
                return number3;
            }
            else
            {
                if (number2 > number3)
                    return number2;
                return number3;
            }
        }

        /// <summary>
        /// To Find Minimum number between given three numbers...
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns>Returns int : - Minimum number between provided three numbers..</returns>
        public int MinInThreeNumber2(int number1, int number2, int number3)
        {
            if (number1 < number2)
            {
                if (number1 < number3)
                    return number1;
                return number3;
            }
            else
            {
                if (number2 < number3)
                    return number2;
                return number3;
            }
        }
        /// <summary>
        /// To check entered number is positive or negative or zero
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns string -> 'Positive' if number is Positive, 'Negative' if number is Negative, 'ZERO' if number is 0</returns>
        public string IsPositiveOrNegativeOrZero(int number)
        {
            if (number > 0)
                return "Positive";
            else if (number < 0)
                return "Negative";
            else
                return "ZERO";
        }
        #endregion
        public float CalculatePercentage(int sub1Marks, int sub2Marks, int sub3Marks, int sub4Marks, int sub5Marks, int sub6Marks)
        {
            return ((sub1Marks + sub2Marks + sub3Marks + sub4Marks + sub5Marks + sub6Marks) / 6);
        }
        /// <summary>
        /// grade of student according to percentage
        /// </summary>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public string CalculateGrade(float percentage)
        {
            if (percentage < 40)
            {
                return "Fail";
            }
            else if (percentage < 50)
            {
                return "Third";
            }
            else if (percentage < 60)
            {
                return "Second";

            }
            else if (percentage < 70)
            {
                return "First";
            }
            return "Distinction";
        }

    }
}
