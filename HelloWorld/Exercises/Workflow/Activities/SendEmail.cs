using System;

namespace HelloWorld.Exercises.Workflow.Activities
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to client... Video started processing.");
        }
    }
}