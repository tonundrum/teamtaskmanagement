using System;
using System.Collections.Generic;
using System.Text;

namespace TTMS.BL
{
    public class Planning
    {
        private List<string> _plans = new List<string>();
        private List<Planning> _plandescription = new List<Planning>();
        public List<string> Plans
        {
            get { return _plans; }
        }
        private string PlanDescription { get; set; }
        private DateTime Deadline { get; set; }
        public void AddPlan(string Plans) //method to add plan
        {
            //_plans.ToString();
            _plans.Add(Plans);

        }
        public void ViewPlan()  //method to view plan from the sample list in the main method
        {
            int numbertask = 1;
            foreach (string plan in _plans)
            {

                Console.WriteLine(numbertask + "." + plan);
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

