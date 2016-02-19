using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsBot
{
    public class ThisIsBot
    {
        private DiscordClient bot;

        //executed when bot is created
        public ThisIsBot()
        {
            bot = new DiscordClient();

            bot.MessageReceived += Bot_MessageReceived;

            bot.Connect("thisisbot@thisisdelicious.net", "break71");

            bot.Wait();
        }

        //executed when message is received
        private void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;

            if (e.Message.Text.ToLower().Contains("is moonbot") || e.Message.Text.ToLower().Contains("moonbot do"))
            {
                e.Channel.SendMessage("!moonbot");
            }

            if (e.Message.Text.ToLower() == "!moonbot")
            {
                e.Channel.SendMessage("is a bot for Moonsquads created by ThisIsDelicious.\n" +
                    "**General:**\n" +
                    "`!moonbot`\n" +
                    "\n" +
                    "**Games:**\n" +
                    "`!minecraft`\n" +
                    "`!gta5`\n" +
                    "\n" +
                    "Visit: `http://www.moonsquads.com/`");
            }

            if (e.Message.Text.ToLower() == "!minecraft")
            {
                e.Channel.SendMessage("- **Minecraft**\n" +
                    "**Server 1**\n" +
                    "-----------------------------\n" +
                    "Connect to: `mc.moonsquads.com`\n" +
                    "Leader: Sinister Rectus\n" +
                    "\n" +
                    "Version: 1.8.x\n" +
                    "Max players: 12\n" +
                    "Mode: survival\n" +
                    "Visit: http://mc.moonsquads.com/");
            }

            if (e.Message.Text.ToLower() == "!gta5")
            {
                e.Channel.SendMessage("- **Grand Theft Auto V**\n" +
                    "-----------------------------\n" +
                    "Crew: Moonsquads [MOSQ]\n" +
                    "Leader: moonsquad\n" +
                    "http://socialclub.rockstargames.com/crew/moonsquads");
            }
        }
    }
}