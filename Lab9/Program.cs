using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentName = new List<string>() { "Adam White", "Bryan White", "Ben Price", "Bethany White", "Carlos Ringer" };
            List<string> homeTown = new List<string>() { "Detroit", "Livonia", "Novi", "Macomb", "Redford" };
            List<string> favoriteFood = new List<string>() { "Fried Chicken", "Tuna Salad", "Pizza", "Beer", "Nachos" };
            List<string> favoriteColor = new List<string>() {"Red", "Blue", "Yellow", "Green", "Orange" };
            int userInput;
            bool run = true;
            bool run2 = true;
            bool run3 = true;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Which student would you like to know about?");




                //while (run)
                //{
                Console.WriteLine("Please choose a number 1-5.");
                foreach (string name in studentName)
                {
                    Console.WriteLine(name);
                }
                try
                {

                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < 6 && userInput > 0)
                        run = false;

                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("\n" +
                        "Invalid answer!\n" +
                        "");
                }
                //}
                while (run3 = true)
                {
                    Console.WriteLine($"\n" +
                    $"If you would like to know {studentName[i]}'s favorite food, hometown,\n" +
                    $"or favorite color, please enter 'hometown', 'favorite food', or \n" +
                    $"'favorite color' now.\n" +
                    $"");
                    Console.WriteLine("\n" +
                        "Or you can just enter 'no' if you are done.\n" +
                        "");


                    string studentInfo2 = Console.ReadLine().ToLower();


                    if (studentInfo2 == "hometown")
                    {
                        Console.WriteLine($"\n" +
                            $"{studentName[i]}'s {studentInfo2} is {homeTown[i]}\n" +
                            $"");
                        

                    }
                    else if (studentInfo2 == "favorite food")
                    {
                        Console.WriteLine($"\n" +
                            $"{studentName[i]}'s {studentInfo2} is {favoriteFood[i]}\n" +
                            $"");
                        
                    }
                    else if (studentInfo2 == "favorite color")
                    {
                        Console.WriteLine($"/n" +
                            $"{studentName[i]}'s {studentInfo2} is {favoriteFood[i]}/n" +
                            $"");
                        
                    }
                    else if (studentInfo2 == "no")
                    {
                        Console.WriteLine("\n" +
                            "Thank you for your interest in our students! Have a great day\n" +
                            "");

                        run3 = false;
                    }
                    else
                    {
                        Console.WriteLine("\n" +
                            "That was not a valid response! Please enter 'hometown', 'favorite food', 'favorite color', or 'no'.\n" +
                            "");

                    }

                    Console.WriteLine("\n" +
                        "Would you like to know more about this student?\n" +
                        "");
                    string keepGoing = Console.ReadLine();

                    if (keepGoing == "no")
                    {
                        Console.WriteLine("\n" +
                            "Thank you for your interest in our students! Have a great day\n" +
                            "");
                        run3 = false;
                    }
                }
                    
            }
                
            
                 
                

                        
                }



            
             


            



        }

        //public static int GetUserInfo(int selection)
        //{
        //    int userInfo = selection;
        //    if (userInfo < 1 || userInfo > 5)
        //    {
        //        Console.WriteLine("That is not a number 1-5!");
        //    }
        //    else
        //    {
        //        return userInfo;
        //    }


        //}
    }

