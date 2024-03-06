namespace BotDiscord;

class Program
{
    static void Main(string[] args)
    {

        User user1 = new User("Mathias", "admin");
        User user2 = new User("Jessica", "minion");
        User user3 = new User("Cyril", "minion");

        Channel channel1 = new Channel("ça papote");

        Message message1 = new Message("tu pues du cul", user1);
        Message message2 = new Message("toi aussi tu pues du cul", user2);

        Message message3 = new Message("/Dé6", user1);

        Bot bot = new Bot("CoucouBot", "BotQuiFaitCoucou", "toi tu pues du cul");
        BotDé botDé = new BotDé();

        

        message1.OnPost += bot.FaireCoucou;
        message3.OnPost += botDé.DéRandom;

        message1.Post(channel1);
        message3.Post(channel1);

        channel1.DisplayMessage();
    }
}

