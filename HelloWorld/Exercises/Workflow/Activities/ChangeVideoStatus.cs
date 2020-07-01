using System;

namespace HelloWorld.Exercises.Workflow.Activities
{
    public class ChangeVideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video status changed to 'Processed'.");
        }
    }
}