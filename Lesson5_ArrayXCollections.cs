using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLerningEvening
{
    public class Lesson5_ArrayXCollections
    {
        private void Example1()
        {
            Console.WriteLine("This is a example 1");
            string[] array = new string[] { 
                "Kaka", "Kiki", "Koko", "Kom Kom", "Keav Keav", "Kab Kab", "Kim Kim"
            };
            string line = "";
            Console.WriteLine("____________________________");
            for (int i = 0;i < array.Length; i ++)
            {
                Console.WriteLine("Your Name is : " + array[i]);
                line += "____";
            }
            Console.WriteLine(line);
            Console.WriteLine("\n\n");
        }
        private void Example2()
        {
            Console.WriteLine("This is a example 2( jaggle array![][] )");
            Console.WriteLine("____________________________");
            string[] name = new string[] { "Kaka", "Kiki", "Koko", "Kom Kom", "Keav Keav", "Kab Kab", "Kim Kim"}, address = new string[] { "PP", "KPC", "KEB", "TK", "SR", "ST", "TK"};
            string[][] ggArray = new string[][] {name, address};
            for (int i = 0; i < ggArray.Length; i++)
            {
                if(i == 0) Console.Write("Your Fucking Name : ");
                else Console.Write("Your Fucking Address :");
                for (int j = 0; j < ggArray[i].Length; j++)
                {
                    Console.Write(ggArray[i][j] + ", ");
                }
                Console.WriteLine();
            }
            
            
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
        }
        private void Example3_Collection()
        {
            Console.WriteLine("This is a example 3 about collection");
            Console.WriteLine("____________________________");
            var Name = new List<string>
            {
                "Kaka", "Kiki", "Koko", "Kom Kom", "Keav Keav", "Kab Kab", "Kim Kim"
            };
            for (int i = 0;i< Name.Count;i++)
            {
                Console.WriteLine("Your Name is : " + Name[i]);
            }
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
        }
        private void Example4_Collection()
        {
            var AllName = new List<string>();
            string[] arryName = new string[] {}; string? allName = "";
            Console.WriteLine("This is a example 4 about collection how to add elements inside");
            Console.WriteLine("____________________________");
            Console.WriteLine("Add more element to collection");
            
            while (true)
            {
                Console.Write("Enter all the name(split by ',') : ");
                allName = Console.ReadLine();
                arryName = allName!.Split(',');
                for (int i = 0; i < arryName.Length; i++)
                {
                    AllName.Add(arryName[i]);
                    Console.WriteLine(arryName[i]);
                }
                Console.Write("Enter e or 0 for exit : "); allName = Console.ReadLine();
                if (allName == "e" || allName == "0" || allName == "E") break;

                Console.ReadKey();
                Console.Clear();
            }


            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
        }
        private void Example5_Collection()
        {
            Console.WriteLine("This is a example 5 about collection how to remove elements inside");
            Console.WriteLine("____________________________");
            var myListNumber = new List<int>(); 
            var myOddNumber = new List<int>();
            var myEvenNumber = new List<int>();

            Console.Write("Odd and Even number from 1 -> 300 is : ");
            for (int i = 1; i <= 300; i++)
            {
                myListNumber.Add(i);
            }
            for (int i = 0; i < myListNumber.Count;i++)
            {
                if (myListNumber[i]%2 != 0) myOddNumber.Add(myListNumber[i]);
                else
                {
                    myListNumber.Remove(i);
                    myEvenNumber.Add(myListNumber[i]);
                }
            }
            Console.WriteLine("\nAll Odd Number is : ");
            foreach (var odd in myOddNumber)
                Console.Write(odd + ",");
            Console.WriteLine("\nAll Even Number is : ");
            foreach (var even in myEvenNumber) 
                Console.Write(even + ",");
            Console.WriteLine("\n____________________________");
            Console.WriteLine("\n\n");
        }
        public Lesson5_ArrayXCollections()
        {
            Example1 ();
            Example2 ();
            Example3_Collection();
            //Example4_Collection();
            Example5_Collection();
        }
    }
}