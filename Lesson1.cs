using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpLerningEvening
{
    public class Lesson1
    {
        //1 .Data type : 
        public Lesson1()
        {
            // int, long | float, double | bool | char, String 
            int numType = 100;
            long myLong = 1000;
            float myFloat = 300.48f;
            double myDouble = 400.42f;
            bool myBool = false;
            char myChar = 'a';
            String myString = "myString";
            Console.WriteLine("This  is intager number : " +  numType);
            Console.WriteLine($"This is long    number : {myLong}");
            Console.WriteLine($"This is Float   number : {myFloat}");
            Console.WriteLine($"This is Double  number : {myDouble}");
            Console.WriteLine($"This is Boolean        : {myBool}");
            Console.WriteLine($"This is charactor char : {myChar}");
            Console.WriteLine($"This is String         : {myString}");
        }
        public void UsingString()
        {
            //Access String by : index, indexOf(), SubString()
            string myString = "myString";
            Console.WriteLine("Using Index : ",myString[0]);
            
            string myStringG = "John Doe";
            
            //Location of D
            int indexOfD = myStringG.IndexOf('D');

            //Get Last name
            string LastName = myStringG.Substring(indexOfD);
            Console.WriteLine("Your Full  Name : " + myStringG);
            Console.WriteLine("Your First Name : " + myStringG.Substring(0,indexOfD-1));
            Console.WriteLine("Your Last  Name : " + LastName);
        }
        public void UsingImplicitConverson()
        {
            //Using big data type to get value from another small datatype like long can contain number that int contain
            int myInt = 209483;
            long myLong = myInt;
            Console.WriteLine($"Int : {myInt}\nLong : {myLong}");
            //Using Base class equle to Derive class always ok
            //...
        }
        public void UsingExplicitConversions()
        {
            //Convert from big data type to small data type
            long myLong = 20944774383;
            int myInt =(int) myLong;
            Console.WriteLine($"Int : {myInt}\nLong : {myLong}");
        }
    }
    // UsingTypeConversionsExceptionsAtRunTime
    public class Animal
    {
        public void Eat() => Console.WriteLine("Eating");
        public override string ToString() => "I am an animal!";
    }
    public class Reptile : Animal { }
    public class Mammal  : Animal { }
    public class UnSafeCast
    {
        public UnSafeCast()
        {
            try
            {
                Test(new Mammal());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Press any key to exit|");
            Console.ReadKey();
        }
        static void Test(Animal a)
        {
            Reptile r = (Reptile) a;
        }
    }
}
