using System;

namespace HelloWorld.Exercises 
{
    class PostView
    {
        public void Show()
        {
            //Initialization of a post
            Console.WriteLine("Welcome to StackOverFlow please input a new post.");

            //Title of the post
            Console.Write("Please input the title of your post: ");
            var title = Console.ReadLine();

            //Description of the post
            Console.WriteLine();
            Console.WriteLine("What is your post all about?");
            var description = Console.ReadLine();

            var post = new PostLogic(title, description);

            //Viewing of the post
            Console.WriteLine();
            Console.WriteLine("Would you like to view your post? Yes or no (quit)?");
            var input = Console.ReadLine();

            Console.Clear();

            if (input.ToLower() == "yes")
            {
                //votation + viewing of post
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(post.PostDisplay());
                    var vote = Console.ReadLine();

                    if (vote.ToLower() == "quit")
                        break;
                    else if(vote.ToLower() == "up")
                        post.UpVote();
                    else if(vote.ToLower() == "down")
                        post.DownVote();
                    else
                        throw new InvalidCastException("Invalid input.");                        
                }
            }
            else if (input.ToLower() == "no")
                Console.WriteLine();
            else
                throw new InvalidCastException("Invalid input.");
        }
    }
    public class PostLogic
    {
        private int _voteCount = 0;
        private string _title { get; }
        private string _description { get; }
        private DateTime _timeOfCreation { get; }

        public PostLogic(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._timeOfCreation = DateTime.Now;
        }

        public void UpVote()
        {
            _voteCount++;
        }

        public void DownVote()
        {
            _voteCount--;
        }

        public string PostDisplay()
        {
            var post = $"{_title.ToUpper()}\nPublished on: {_timeOfCreation.ToString("D")}" +
                            $"\n\n{_description}\n\n\nCurrent vote count: {_voteCount}\n" +
                            "Type up to UPVOTE, down to DOWNVOTE or quit to QUIT";
            return post;
        }
    }
}