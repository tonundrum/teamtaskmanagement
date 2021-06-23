
using System;
using System.Collections.Generic;

namespace TTMS.BL
{
    public class Tasking : Planning
    {


        static public List<string> _task = new List<string>();
        static private List<string> _asignees = new List<string>();
        static private List<int> _deadlinetask = new List<int>();
        static public List<string> Tasks
        {
            get { return _task; }
        }
        static public List<string> Asignees
        {
            get { return _asignees; }
        }
        static public List<int> DeadlineTask
        {
            get { return _deadlinetask; }
        }
        static public void AddTask(string Tasks)
        {
            _task.Add(Tasks);
        }
        static public void AddAssignee(string Assignees)
        {
            _asignees.Add(Assignees);
        }
        static public void AddDeadlineTask(int DeadlineTask)
        {
            _deadlinetask.Add(DeadlineTask);
        }

    }
}


