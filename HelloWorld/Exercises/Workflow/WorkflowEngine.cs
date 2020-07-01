using System;
using System.Collections.Generic;
using HelloWorld.Exercises.Workflow.Activities;

namespace HelloWorld.Exercises.Workflow
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> activityList = new List<IActivity>();
        public void Run(Workflow workflow)
        {
            if(workflow == null)
                throw new ArgumentNullException("Workflow can't be null.");

            workflow.GetElements(activityList);
            foreach(var activity in activityList)
                activity.Execute();
        }
    }
}