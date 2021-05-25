using System;
using System.Collections.Generic;
using System.Text;

namespace TTMS.BL
{
    public class Planning
    {
        private List<string> _plans = new List<string>();
        private List<string> _plandescription = new List<string>();
        public List<string> Plans
        {
            get { return _plans; }
        }
        public List<string> PlanDescription
        {
            get { return _plandescription; }
        }
        private DateTime Deadline { get; set; }
        public void AddPlan(string Plans) //method to add plan
        {
            //_plans.ToString();
            _plans.Add(Plans);
        }
        public void AddPlanDescription(string PlanDescription)
        {
            _plandescription.Add(PlanDescription);
        }
        public void ViewPlan()  //method to view plan from the sample list in the main method
        {
            int numbertask = 1;
            for (int i = 1; i <= Math.Abs(_plans.Count); i++)
            {
                Console.WriteLine(numbertask + "." + " " + Plans[i - 1] + "\n" + PlanDescription[i - 1]);
                numbertask++;
            }
        }
        public void UserPlanning()
        {
            Console.WriteLine("Enter the title of the plan: ");
            string InputPlan = Console.ReadLine();
            Console.WriteLine("Write a description about your plan: ");
            string InputPlanDescription = Console.ReadLine();
            Planning inputplans = new Planning();

            inputplans.AddPlan(InputPlan);

        }

    }
}

