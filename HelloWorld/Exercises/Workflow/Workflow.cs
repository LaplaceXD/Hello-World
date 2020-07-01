using System;
using System.Collections.Generic;
using HelloWorld.Exercises.Workflow.Activities;

namespace HelloWorld.Exercises.Workflow
{
    public class Workflow
    {
        private readonly IList<IActivity> _activityList;

        public Workflow()
        {
            _activityList = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            if(activity == null)
                throw new ArgumentNullException("Can't place a null activity.");
        
            _activityList.Add(activity);
        }

        public void ClearActivities()
        {
            _activityList.Clear();
        }

        public void GetElements(IList<IActivity> activityList)
        {
            if(activityList == null)
                throw new ArgumentNullException("Can't place a null list");

            foreach (var activity in _activityList)
                activityList.Add(activity);
        }
    }
}