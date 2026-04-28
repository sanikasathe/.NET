using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{
    internal class ExceptionHandling
    {
        public void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException(" You must be atleast 18 years old");
            }
            else
            {
                Console.WriteLine("you are old enough");
            }
        }
    }
}
