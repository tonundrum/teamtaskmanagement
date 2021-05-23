using System;
using System.Collections.Generic;
using TTMS.BL;

namespace TTMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
           User user = new User();
           user.Email = "ejsoriano11@gmail.com";
           user.Password = "thepassword";
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
             Console.WriteLine("--------------------------------------------------------------");
             Console.WriteLine("----------Welcome to Asona Team Task Management System--------");
             Console.WriteLine("--------------------------------------------------------------");
             Console.WriteLine("\nEnter your email: ");
             string EmailInput = Console.ReadLine();
             Console.WriteLine("\nEnter your password: ");
             string PasswordInput = Console.ReadLine();
             if (EmailInput.Equals(user.Email) && PasswordInput.Equals(user.Password))
             {
             LoginCorrect();
             }
             else
             {
             Console.WriteLine("Wrong email and password");
             count++;
            }
        }
    }
 }
        static void LoginCorrect()
        {
            Planning plan = new Planning();
            Tasking task = new Tasking();
            plan.AddPlan("Plan 1");
            plan.AddPlan("Plan 2");
            plan.AddPlan("Plan 3");

            Start:
            Console.WriteLine("=========================================================");
            Console.WriteLine("========= Elton, welcome to your task manager! ==========");
            Console.WriteLine("=========================================================");
            var CurrentDate = DateTime.Now;
            Console.WriteLine("====" + CurrentDate + "================================");
            
           
            Console.WriteLine("\n========================================================");
            Console.WriteLine("= A - Create Plan   ==  B - My Plans   ==  C - Logout  =");
            Console.WriteLine("========================================================");
            string option = Console.ReadLine();


             if (option.Equals("A") || option.Equals("a"))
                {
                    Console.WriteLine("Enter the title of the plan: ");
                    string InputPlan = Console.ReadLine();
                    Console.WriteLine("Write a description about your plan: ");
                    string InputPlanDescription = Console.ReadLine();
                    Planning inputplans = new Planning();

                    inputplans.AddPlan(InputPlan);
                    //plan.UserPlanning();
                    task.TaskDashBoard();

                    goto Start;
                }
                else if (option.Equals("B") || option.Equals("b"))
                {
                    plan.ViewPlan();
                    goto Start;
                }
                else if (option.Equals("C") || option.Equals("c"))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Input!");
                    goto Start;
                }
            }
        }
    }



