using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLerningEvening
{
    public class Lesson4
    {
        public string? Name {  get; set; }
        public int Age {  get; set; }
        public void EnterValue()
        {
            try
            {
                string? age;
                Console.WriteLine("Enter your name : ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter your age  : ");
                age = Console.ReadLine();
                if (!string.IsNullOrEmpty(Name) && Int32.TryParse(age, out int Agee))
                {
                    Age = Agee;
                    Console.WriteLine("Your Fucking name is : " + Name);
                }
                else
                {
                    Console.WriteLine("Your Name or age are invalid or empty!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally { Console.WriteLine("This is a final code!"); }
        }
        public Lesson4()
        {
            EnterValue();
        }
    }
    
}
