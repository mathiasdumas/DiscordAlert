using System;
namespace BotDiscord
{
	public class Bot : User
	{
        public string Message { get; set; }
        public Bot()
		{
		}

        public Bot(string name, string role, string message) : base(name, role)
        {
            Message = message;
        }

		public void FaireCoucou(object sender, PostArgs postArgs)
		{
            if (postArgs.Content.Contains("cul"))
            {
                Console.WriteLine(Message);
            }
        }
    }
}

