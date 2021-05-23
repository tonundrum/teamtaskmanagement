
using System;

namespace TTMS.BL
{
    public class Tasking
    {

        private string _task;
        private string _asignees;
        private int _daysbeforedue;

        public string Task { get; set; }
        public string Asignees { get; set; }
        public int Daysbeforedue { get; set; }
        public void TaskDashBoard()
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
                Console.Write("Wrong Input");
                goto AddTask;
            }



        }
    }
}
enum Priority { Low, Medium, High }

