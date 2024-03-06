using System;
namespace BotDiscord
{
	public class Channel
	{
		public string ChannelName { get; set; }
        public List<Message> ListMessages { get; set; }


        public Channel(string channelName)
        {
            ChannelName = channelName;
            ListMessages = new List<Message>();
        }

        public void DisplayMessage()
        {
            foreach (Message message in ListMessages)
            {
                Console.WriteLine(message.Content);
            }
        }
    }
}

