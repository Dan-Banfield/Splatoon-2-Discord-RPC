using DiscordRPC;
using System;

namespace Splatoon_2_Discord_RPC
{
    public class DiscordRPCManager
    {
        public DiscordRpcClient discordRpcClient;

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

        public bool Connected()
        {
            return discordRpcClient.IsInitialized;
        }

        public bool SetStatus(string title, string subTitle, string imageKey)
        {
            try
            {
                discordRpcClient.ClearPresence();
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
                        LargeImageKey = imageKey,
                        LargeImageText = title == "Salmon Run" ? "Salmon Run" : "Splatoon 2"
                    }
                });
                return true;
            }
            catch { return false; }
        }
    }
}
