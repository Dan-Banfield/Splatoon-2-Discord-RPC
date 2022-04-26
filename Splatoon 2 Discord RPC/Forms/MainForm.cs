using System.Windows.Forms;

namespace Splatoon_2_Discord_RPC
{
    public partial class MainForm : Form
    {
        #region Properties

        private enum GameMode { TurfWar, Ranked, League, PrivateBattle, SalmonRun }
        private GameMode SelectedGameMode = GameMode.TurfWar;

        private enum MatchStatus { Idle, InGame, Matchmaking }
        private MatchStatus SelectedMatchStatus = MatchStatus.Idle;

        private enum Image { Image1 }
        private Image SelectedImage = Image.Image1;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void setStatusButton_Click(object sender, System.EventArgs e)
        {
            SetValues();

            DiscordRPCManager discordRPCManager = new DiscordRPCManager();

            if (discordRPCManager.ConnectToDiscord())
            {
                string gameMode = string.Empty;
                string status = string.Empty;

                switch (SelectedGameMode)
                {
                    case GameMode.TurfWar:
                        gameMode = "Turf War";
                        break;
                    case GameMode.Ranked:
                        gameMode = "Ranked";
                        break;
                    case GameMode.League:
                        gameMode = "League";
                        break;
                    case GameMode.PrivateBattle:
                        gameMode = "Private Battle";
                        break;
                    case GameMode.SalmonRun:
                        gameMode = "Salmon Run";
                        break;
                }

                switch (SelectedMatchStatus)
                {
                    case MatchStatus.Idle:
                        status = "Idle";
                        break;
                    case MatchStatus.InGame:
                        status = "In-Game";
                        break;
                    case MatchStatus.Matchmaking:
                        status = "Matchmaking";
                        break;
                }

                discordRPCManager.SetStatus(gameMode, status);
                return;
            }
            MessageBox.Show("Failed to connect to Discord!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Methods

        private void SetValues() 
        {
            SelectedGameMode = GetSelectedGameMode();
            SelectedMatchStatus = GetSelectedMatchStatus();
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
            return MatchStatus.Idle;
        }

        #endregion
    }
}
