using DiscordRPC;
using System;

namespace Splatoon_2_Discord_RPC
{
    public class DiscordRPCManager
    {
        private DiscordRpcClient discordRpcClient;

        private const string APPLICATION_ID = "968592663559413901";

        public DiscordRPCManager()
        {
            discordRpcClient = new DiscordRpcClient(APPLICATION_ID);
        }

        private void InitializeClient()
        {
            discordRpcClient.Initialize();
        }

        public bool ConnectToDiscord()
        {
            try
            {
                InitializeClient();
                return true;
            }
            catch { return false; }
        }

        public void SetStatus(string title, string subTitle)
        {
            discordRpcClient.SetPresence(new RichPresence() 
            {
                Details = title,
                State = subTitle,

                Timestamps = new Timestamps() 
                {
                    Start = DateTime.UtcNow
                },

                Assets = new Assets() 
                {
                    LargeImageKey = "image-big-splatoon2",
                    LargeImageText = "Splatoon 2"
                }
            });
        }
    }
}
