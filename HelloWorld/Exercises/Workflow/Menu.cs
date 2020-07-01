using System;
using HelloWorld.Exercises.Workflow.Activities;

namespace HelloWorld.Exercises.Workflow
{
    public class Menu
    {
        public Menu()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            Console.WriteLine("Welcome to workflow creator v1.0.".ToUpper());
            Console.WriteLine();
            Console.WriteLine("Would you like to create a new workflow? Type in 'yes' or 'no'.");
            var input = Console.ReadLine();

            if(input.ToLower() == "yes")
                WorkflowMainMenu();
            else if(input.ToLower() == "no")
                Console.WriteLine();
            else
                throw new InvalidOperationException("Input out of range.");                
        }

        private void WorkflowMainMenu()
        {
            Console.Clear();
            var workflow = new Workflow();
            Console.WriteLine("You have created a new workflow!");
            Console.WriteLine();

            Console.WriteLine("Add some activities to your workflow by inputing the appropriate number.");
            Console.WriteLine("1. Upload a video.\n2. Call web service.\n3. Send an email.\n4. Change video status.\n");

            var counter = 0;
            while (true)
            {
                Console.Write("Activity number: ");

                var input = Console.ReadLine();
                var message = InputLogic(workflow, input, counter);

                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine();

                Console.WriteLine("Would you like to add another activity? Type in 'yes' or 'no'.");
                var inputTwo = Console.ReadLine();

                if (inputTwo.Trim().ToLower() == "yes")
                    Console.Clear();
                else if (inputTwo.Trim().ToLower() == "no")
                {
                    Console.Clear();
                    break;
                }
                else
                    throw new InvalidOperationException("Input out of range.");

                counter++;
                Console.WriteLine("Add some activities to your workflow by inputing the appropriate number.");
                Console.WriteLine("1. Upload a video.\n2. Call web service.\n3. Send an email.\n4. Change video status.\nOr type 'clear' to clear your workflow.\n");
            }
            WorkflowExecute(workflow);
        }

        private void WorkflowExecute(Workflow workflow)
        {
            var workflowEngine = new WorkflowEngine();
            Console.WriteLine("Would you like to execute the activities in your workflow?");
            Console.WriteLine("Type in 'yes' or 'no'.");
            var input = Console.ReadLine();

            if (input.Trim().ToLower() == "yes")
            {
                Console.Clear();
                Console.WriteLine("Executing activities\n");
                workflowEngine.Run(workflow);
                
                Console.WriteLine();
                Console.WriteLine("Workflow activities executed.");
                Console.Write("Press enter...");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Start another workflow? Type in 'yes' or 'no'.");
                var inputTwo = Console.ReadLine();
                ReturnToMainMenu(inputTwo);

            }
            else if (input.Trim().ToLower() == "no")
            {
                Console.Clear();
                Console.WriteLine("Go back to Main Menu? Type in 'yes' or 'no'.");
                var inputThree = Console.ReadLine();
                ReturnToMainMenu(inputThree);
            }
            else
                throw new InvalidOperationException("Input out of range.");
        }
        private string InputLogic(Workflow workflow, string input, int counter)
        {
            if (input.Trim() == "1")
            {
                workflow.AddActivity(new UploadVideo());
                return "Upload a video added.";
            }
            else if (input.Trim() == "2")
            {
                workflow.AddActivity(new CallWebService());
                return "Call web service added.";
            }
            else if (input.Trim() == "3")
            {
                workflow.AddActivity(new SendEmail());
                return "Send email added.";
            }
            else if (input.Trim() == "4")
            {
                workflow.AddActivity(new ChangeVideoStatus());
                return "Change video status added.";
            }
            else if (input.ToLower().Trim() == "clear" && counter >= 1) 
            {
                workflow.ClearActivities();
                return "Workflow cleared.";
            }
            else
                throw new InvalidOperationException("Input out of range.");
        }

        private void ReturnToMainMenu(string input)
        {
            if (input.Trim().ToLower() == "yes")
            {
                Console.Clear();
                MainMenu();
            }
            else if (input.Trim().ToLower() == "no")
            {
                Console.Clear();
                Console.WriteLine("Closing program...");
            }
            else
                throw new InvalidOperationException("Input out of range.");
        }
    }
}