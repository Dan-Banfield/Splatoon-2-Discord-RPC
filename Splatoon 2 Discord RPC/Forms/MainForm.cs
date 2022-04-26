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
            MessageBox.Show($"{SelectedGameMode} {SelectedMatchStatus} {SelectedImage}");
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
