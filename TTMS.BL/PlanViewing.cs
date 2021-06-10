using System;
namespace TTMS.BL
{
    public class PlanViewing : Planning
    {
        static public void ViewPlan()  //method to view plan from the sample list in the main method
        {
            int numbertask = 1;
            for (int i = 1; i <= Math.Abs(_plans.Count); i++)
            {
                Console.WriteLine(numbertask + "." + " " + Plans[i - 1] + "\n" + PlanDescription[i - 1] + "\n" + "Deadline: " + Deadline[i - 1] + " day(s)");
                numbertask++;
            }
        }
    }
}


