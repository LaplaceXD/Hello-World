using System;

namespace HelloWorld.Exercises.Workflow.Activities
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video...");
        }
    }
}