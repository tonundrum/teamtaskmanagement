using System;
using System.Collections.Generic;
using System.Text;

namespace TTMS.BL
{
    public class Planning
    {
        static public List<string> _plans = new List<string>();
        static private List<string> _plandescription = new List<string>();
        static private List<int> _deadline = new List<int>();
        static public List<string> Plans
        {
            get { return _plans; }
        }
        static public List<string> PlanDescription
        {
            get { return _plandescription; }
        }
        static public List<int> Deadline
        {
            get { return _deadline; }
        }
        static public void AddPlan(string Plans) //method to add plan
        {
            //_plans.ToString();
            _plans.Add(Plans);
        }
        static public void AddPlanDescription(string PlanDescription)
        {
            _plandescription.Add(PlanDescription);
        }
        static public void AddDeadline(int Deadline)
        {
            _deadline.Add(Deadline);
        }


    }
}

