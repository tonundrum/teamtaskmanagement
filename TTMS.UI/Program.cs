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
            
            Planning.AddPlan("Plan 1");
            Planning.AddPlanDescription("Plan Description 1");
            Planning.AddDeadline(3);
            Planning.AddPlan("Plan 2");
            Planning.AddPlanDescription("Plan Description 2");
            Planning.AddDeadline(7);
            Planning.AddPlan("Plan 3");
            Planning.AddPlanDescription("Plan Description 3");
            Planning.AddDeadline(4);
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
                    UserPlanning();
                    TaskDashBoard();

                    goto Start;
                }
                else if (option.Equals("B") || option.Equals("b"))
                {
                    PlanViewing.ViewPlan();
                    
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

        static public void UserPlanning()
        {
            Console.WriteLine("Enter the title of the plan: ");
            string InputPlan = Console.ReadLine();
            Console.WriteLine("Write a description about your plan: ");
            string InputPlanDescription = Console.ReadLine();
        DeadlinePlan:
            Console.WriteLine("Days before the deadline of the plan: ");
            string inputtedDate = Console.ReadLine();
            int num = -1;
            if (!Int32.TryParse(inputtedDate, out num))
            {
                Console.WriteLine("Wrong Input");
                goto DeadlinePlan;
            }

            Planning inputplans = new Planning();
            Planning.AddPlan(InputPlan);
            Planning.AddPlanDescription(InputPlanDescription);
            Planning.AddDeadline(num);
        }
        static void TaskDashBoard()
        {
        AddTask:
            Console.WriteLine("Enter a task: ");
            String task = Console.ReadLine();
            Console.WriteLine("Please enter the email of the asignees of this task: ");
            String asignees = Console.ReadLine();
        DaysTask:
            Console.WriteLine("How many days to make the task: ");
            string deadlineTask = Console.ReadLine(); //get the input
            int num = -1;
            if (!Int32.TryParse(deadlineTask, out num))
            {
                Console.WriteLine("Wrong Input");
                goto DaysTask;
            }
            Console.WriteLine("== Do you still want to add another task? /n Y-Yes or N-No ==");
            string addtaskchoice = Console.ReadLine();

            if (addtaskchoice.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                goto AddTask;
            }
            else if (addtaskchoice.Equals("N", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            else
            {
                Console.WriteLine("Wrong Input");
                goto AddTask;
            }
        }
    }
    }



