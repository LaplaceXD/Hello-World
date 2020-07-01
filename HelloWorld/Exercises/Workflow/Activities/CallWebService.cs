using System;

namespace HelloWorld.Exercises.Workflow.Activities
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service... Video is ready for encoding.");
        }
    }
}