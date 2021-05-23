using System;
using System.Collections.Generic;

namespace teamtaskmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManagementEmail("ejsoriano11@gmail.com", "thepassword");
            var Plans = new List<string>(10);
        }
        static void TaskManagementEmail(string email, string password)
        {
            int count = 0;
            while (count < 4)
            {
                if (count == 3)
                {
                    Console.WriteLine("Maximum attempts exceeded");
                    return;

                }
                else
                {
                    Console.WriteLine("Welcome to Asona Team Task Management System");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Enter your email: ");
                    string EmailInput = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    string passwordInput = Console.ReadLine();
                    if (EmailInput.Equals(email) && passwordInput.Equals(password))
                    {
                        LoginCorrect("A", "B");
                    }
                    else
                    {
                        LoginIncorrect();
                        count++;
                    }

                }

            }
            static void LoginCorrect(string createplan, string viewplan)
            {
                List<string> Plans = new List<string>(10)
                        {"Plan 1","Plan 2",
                        "Plan 3"};
            Start1:
                Console.WriteLine("Welcome Elton to your task manager!");
                Console.WriteLine("-----------------------------------------------------------");
                var CurrentDate = DateTime.Now;
                Console.WriteLine("Today is: {0}",CurrentDate);
                Console.WriteLine("A - Create Plan \t B - My Plans \t C - Logout");
                string Option = Console.ReadLine();
                if (Option.Equals("A") || Option.Equals("a"))
                {
                    Console.WriteLine("Enter the title of the plan: ");
                    String title = Console.ReadLine();
                    Console.WriteLine("Write a description about your plan: ");
                    String description = Console.ReadLine();
                    Console.WriteLine("Enter a task: ");
                    String task = Console.ReadLine();
                    Console.WriteLine("Please enter the email of the asignees of this task: ");
                    String asignees = Console.ReadLine();
                    Console.WriteLine("How many days to make the task: ");
                    string deadlineTask = Console.ReadLine();
                    Console.WriteLine("When is the deadline of the plan (MM/dd/yyyy): ");
                    string deadlinePlan = Console.ReadLine();
                  /*  string pattern = "MM/dd/yyyy"; 
                    DateTime deadlinePlan = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                  */

                    


                    Console.WriteLine("Title of your task: " + title);
                    Console.WriteLine("Description: " + description);
                    Console.WriteLine("Asignees: " + asignees);
                  //  Console.WriteLine("Deadline:{0} ",deadlinePlan);
                    Plans.Add(title);
                    goto Start1;
                }
                else if (Option.Equals("B") || Option.Equals("b"))
                {
                    Console.WriteLine("Your tasks: ");

                    {
                        int numbertask = 1;
                        foreach (string item in Plans)
                        {
                            Console.WriteLine(numbertask + "." + item);
                            numbertask++;
                        }


                    }

                    goto Start1;


                }
                else if (Option.Equals("C") || Option.Equals("c"))
                {

                    return;

                }
                else
                {
                    InputIncorrect();
                    goto Start1;

                }
            }
        }
        static void LoginIncorrect()
        {
            Console.WriteLine("Wrong username or password");
        }
        static void InputIncorrect()
        {
            Console.WriteLine("Wrong input");
        }
    }
}

