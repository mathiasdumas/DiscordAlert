using System;
namespace BotDiscord
{
	public class BotDé : Bot
	{

		public BotDé()
		{
		}

		public void DéRandom(object sender, PostArgs postArgs)
		{
			Random rdn = new Random();
			int aleatoire;

			if (postArgs.Content.Contains("/Dé6"))
			{
                aleatoire = rdn.Next(1, 7);
				Console.WriteLine(aleatoire);
            }
			if (postArgs.Content.Contains("/Dé100"))
			{
				aleatoire = rdn.Next(0, 101);
				Console.WriteLine(aleatoire);
			}
		}
	}
}

