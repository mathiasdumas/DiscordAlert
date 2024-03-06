using System;
namespace BotDiscord
{
	public class PostArgs : EventArgs
	{
		public string Content { get; set; }
        public User User { get; set; }

        public PostArgs()
		{
		}

        public PostArgs(string content, User user)
        {
            Content = content;
            User = user;
        }
    }
}

