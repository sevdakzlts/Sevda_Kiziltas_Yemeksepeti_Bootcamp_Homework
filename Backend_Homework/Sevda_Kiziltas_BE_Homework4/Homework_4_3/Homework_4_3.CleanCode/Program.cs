using System;
using System.IO;

namespace Homework_4_3.CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boolean comparisons and value assignments

            bool GetResult(int value) => (value == 1);

            #endregion Boolean comparisons and value assignments

            #region Ternary if

            string Result(int value) => value == 1 ? "Value is equals 1" : "Value is not equals 1";

            #endregion Ternary if

            #region Strongly Type

            const string AdminRole = "Admin";
            string UserRole = "Premium";
            if (UserRole == AdminRole)
            {
                return ;
            }


            #endregion Strongly Type


            #region Complex Conditions

            int BirthDate = 1997;
            bool IsAdult = (DateTime.Now.Year - BirthDate) >= 18;

            #endregion Complex Conditions
        }

        //Rule of Seven
        public void GetTotalNumber(int number1, int number2)
        {
            int totalNumber = number1 + number2;
            int minimumNumber = 0;
            if (totalNumber>= minimumNumber)
                return;
            
        }

        //Avoid Too Many Parameters and Fail Fast
        public Student StudentInformation(Student student)
        {
            if (student == null)
                throw new FileNotFoundException();
            
            return student;
        }
    }

    internal class Student
    {
         string Name;
         private string City;
    }
}
