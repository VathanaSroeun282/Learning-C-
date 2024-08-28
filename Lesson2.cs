using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLerningEvening
{
    //Lesson 2 is talking about the Controlstate 
    public class Lesson2
    {
        public int[] IfElseState(string? myNumber)
        {
            int[] myMeme = new int[0];
            bool check = true;
            if (myNumber != null)
            {
                string[] myArray = myNumber.Split(',');
                myMeme = new int[myArray.Length];
                if (myArray.Length > 0)
                {
                    //Convertion
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (int.TryParse(myArray[i].Trim(), out int x))
                        {
                            myMeme[i] = x;
                        }
                        else
                        {
                            Console.WriteLine($"{myArray[i]} is not a number!");
                            check = false;
                            break;
                        }
                    }

                    //Check if it not a number
                    if (check)
                    {
                        //Show all data that you have been input
                        Console.Write("Your numbers that you input are:");
                        foreach (int x in myMeme)
                        {
                            Console.Write(" " + x );
                        }

                        //Find Max and Min in that data
                        int max = myMeme[0], min = myMeme[0];
                        for (int i = 1; i < myMeme.Length; i++)
                        {
                            if (myMeme[i] > max)
                            {
                                max = myMeme[i];
                            }
                            if (myMeme[i] < min)
                            {
                                min = myMeme[i];
                            }
                        }
                        //Show it as a result of find max and min
                        Console.WriteLine($"\nBiggest number that you input is: {max}");
                        Console.WriteLine($"Smallest number that you input is: {min}");
                    }
                }
                //If it has only one number
                else
                {
                    Console.WriteLine("This is the only one number that I can't compair: " + myArray[0]);
                }
            }
            return myMeme;
        }//if else statement
        public void WhileStatement()
        {
            Console.WriteLine("This is while loop : ");
            int i = 0;
            while(i <= 13)
            { 
                Console.WriteLine($"Number : {i}");
                i++;
            }
        }
        public void SwitchStatement()
        {
            int option;
            int[] myNumber_int = new int[0];// for convert from string
            string? myNumber_S = "";//For input number 
            bool x = true;
            Console.Clear();
            while(x)
            {
                Console.WriteLine("1. Input number ");
                Console.WriteLine("2. Show your number ");
                Console.WriteLine("3. Find Max & Min number ");
                Console.WriteLine("4. Sum all number ");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your option[1->4] : ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to Input Numeber option -_-!");
                            Console.Write("Enter your Number : ");
                            myNumber_S = Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to Show your number that you input =_=!");
                            Console.WriteLine($"This is your Number : {myNumber_S}");
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to Öption find Max and Min number :)!");
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine(IfElseState(myNumber_S));
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Welcom to Option Sum all your input number :D!");
                            Console.Write("All number that your Input is : ");
                            myNumber_int = IfElseState(myNumber_S);
                            int sum = 0;
                            for (int i = 0; i < myNumber_int.Length; i++)
                            {
                                sum += myNumber_int[i];
                                Console.Write(myNumber_int[i] + "+");
                            }
                            Console.Write($"\b \b = {sum}");
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("Exit");
                            x = false;
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
