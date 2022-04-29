using System;
using System.Windows.Forms;
using static Splatoon_2_Discord_RPC.Generics;

namespace Splatoon_2_Discord_RPC
{
    public partial class MainForm : Form
    {
        #region Properties

        private enum GameMode { TurfWar, Ranked, League, PrivateBattle, SalmonRun }
        private GameMode SelectedGameMode = GameMode.TurfWar;

        private enum MatchStatus { Idle, InGame, Matchmaking, LookingForFriends }
        private MatchStatus SelectedMatchStatus = MatchStatus.Idle;

        private enum Image { Image1, Image2 }
        private Image SelectedImage = Image.Image1;

        private DiscordRPCManager discordRPCManager;

        #endregion

        public MainForm()
        {
            AppDomain.CurrentDomain.UnhandledException += (o, e) => { MessageBox.Show("An error has occured! Please restart the application and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); System.Diagnostics.Process.GetCurrentProcess().Kill(); };
            InitializeComponent();
        }

        #region Event Handlers

        private void setStatusButton_Click(object sender, System.EventArgs e)
        {
            SetValues();

            string gameMode = StringGameMode();
            string status = StringStatus();
            string imageKey = StringImage();

            ConnectAndSet(gameMode, status, imageKey);
        }

        #endregion

        #region Methods

        private void ConnectAndSet(string gameMode, string status, string imageKey)
        {
            if (discordRPCManager == null) discordRPCManager = new DiscordRPCManager();

            if (!discordRPCManager.Connected())
            {
                if (!discordRPCManager.ConnectToDiscord()) { MessageBoxes.ShowErrorMessage("Failed to connect to Discord!"); return; }
            }

            if (discordRPCManager.SetStatus(gameMode, status, imageKey))
            {
                MessageBoxes.ShowInformationMessage("Status set successfully!");
                return;
            }
            MessageBoxes.ShowErrorMessage("Failed to set status!");
        }

        private void SetValues() 
        {
            SelectedGameMode = GetSelectedGameMode();
            SelectedMatchStatus = GetSelectedMatchStatus();
            SelectedImage = GetSelectedImage();
        }

        private string StringGameMode()
        {
            switch (SelectedGameMode)
            {
                case GameMode.TurfWar:
                    return "Turf War";
                case GameMode.Ranked:
                    return "Ranked";
                case GameMode.League:
                    return "League";
                case GameMode.PrivateBattle:
                    return "Private Battle";
                case GameMode.SalmonRun:
                    return "Salmon Run";
            }
            return "Turf War";
        }

        private string StringStatus()
        {
            switch (SelectedMatchStatus)
            {
                case MatchStatus.Idle:
                    return "Idle";
                case MatchStatus.InGame:
                    return "In Game";
                case MatchStatus.Matchmaking:
                    return "Matchmaking";
                case MatchStatus.LookingForFriends:
                    return "Looking For Friends";
            }
            return "Idle";
        }

        private string StringImage()
        {
            switch (SelectedImage)
            {
                case Image.Image1:
                    return "image-big-splatoon2";
                case Image.Image2:
                    return "image-big-salmonrun";
            }
            return "image-big-splatoon2";
        }

        private GameMode GetSelectedGameMode()
        {
            if (turfWarRadioButton.Checked) return GameMode.TurfWar;
            if (rankedRadioButton.Checked) return GameMode.Ranked;
            if (leagueRadioButton.Checked) return GameMode.League;
            if (privateBattleRadioButton.Checked) return GameMode.PrivateBattle;
            if (salmonRunRadioButton.Checked) return GameMode.SalmonRun;
            return GameMode.TurfWar;
        }

        private MatchStatus GetSelectedMatchStatus()
        {
            if (idleRadioButton.Checked) return MatchStatus.Idle;
            if (inGameRadioButton.Checked) return MatchStatus.InGame;
            if (matchmakingRadioButton.Checked) return MatchStatus.Matchmaking;
            if (lookingForFriendsRadioButton.Checked) return MatchStatus.LookingForFriends;
            return MatchStatus.Idle;
        }

        private Image GetSelectedImage()
        {
            if (imageOneRadioButton.Checked) return Image.Image1;
            if (imageTwoRadioButton.Checked) return Image.Image2;
            return Image.Image1;
        }

        #endregion
    }
}
