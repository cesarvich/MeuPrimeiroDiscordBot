using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace MyFirstBot
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "omitido por seguranca da nacao",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("cesar"))
                    await e.Message.RespondAsync("\nNunca vi mais lindo :sunglasses: ");

            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}