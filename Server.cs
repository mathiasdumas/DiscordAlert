using System;
namespace BotDiscord
{
	public class Server
	{

		public string ServerName { get; set; }
		public List<Channel> ListChannels { get; set; }
		public List<User> ListUsers { get; set; }

		public Server()
		{
		}

        public Server(string serverName, List<Channel> listChannels, List<User> listUsers)
        {
            ServerName = serverName;
            ListChannels = listChannels;
            ListUsers = listUsers;
        }

        public Server(List<Channel> listChannels, List<User> listUsers)
        {
            ListChannels = listChannels;
            ListUsers = listUsers;
        }
    }
}

