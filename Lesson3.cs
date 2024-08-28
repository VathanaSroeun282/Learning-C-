using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLerningEvening
{
    public class Lesson3
    {
        //Using Event and method
        public void myMethod()
        {
            Console.WriteLine("This is my method");
        }
        //Recursive function
        public int SumNum (int x, int i)
        {
            if(i != 0)
            {
                i--;
                return SumNum(x,i) + 1;
            }
            return 0;
        }
        //Method to find maximum
        public int myMaximum(int x, int y)  =>  x > y ? x : y;
        //Using method in Constructor
        public Lesson3()
        {
            myMethod();
            Console.WriteLine("Maximum of (3,4) number is : " + myMaximum(3,4));
            Console.WriteLine("Sum of serinumber is (5 times): " + SumNum(3, 4));
        }
    }
}
