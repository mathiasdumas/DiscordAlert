using System;
namespace BotDiscord
{
	public class User
	{
		public string Name { get; set; }
		public string Role { get; set; }

		public User()
		{
		}

        public User(string name, string role)
        {
            Name = name;
            Role = role;

        }
    }
}

