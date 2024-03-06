using System;
namespace BotDiscord
{
	public class Message
	{
		public string Content { get; set; }
		public User User { get; set; }
		public event EventHandler<PostArgs> OnPost;



		public Message()
		{
		}

        public Message(string content, User user)
        {
            Content = content;
            User = user;
        }

		public void Post(Channel channel)
		{
			PostArgs postArgs = new PostArgs(Content, User);
			Console.WriteLine(Content);
            OnPost?.Invoke (this, postArgs);
        }
    }
}

