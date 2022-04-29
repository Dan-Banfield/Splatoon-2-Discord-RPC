
namespace Splatoon_2_Discord_RPC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nsTheme = new NSTheme();
            this.optionsGroupBox = new NSGroupBox();
            this.setStatusButton = new NSButton();
            this.rpcImageGroupBox = new NSGroupBox();
            this.rpcImagePanel = new System.Windows.Forms.Panel();
            this.imageTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.imageTwoRadioButton = new NSRadioButton();
            this.imageOnePictureBox = new System.Windows.Forms.PictureBox();
            this.imageOneRadioButton = new NSRadioButton();
            this.matchStatusGroupBox = new NSGroupBox();
            this.lookingForFriendsRadioButton = new NSRadioButton();
            this.matchmakingRadioButton = new NSRadioButton();
            this.inGameRadioButton = new NSRadioButton();
            this.idleRadioButton = new NSRadioButton();
            this.gameModeGroupBox = new NSGroupBox();
            this.salmonRunRadioButton = new NSRadioButton();
            this.privateBattleRadioButton = new NSRadioButton();
            this.leagueRadioButton = new NSRadioButton();
            this.rankedRadioButton = new NSRadioButton();
            this.turfWarRadioButton = new NSRadioButton();
            this.minimizeButton = new NSControlButton();
            this.closeButton = new NSControlButton();
            this.nsTheme.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.rpcImageGroupBox.SuspendLayout();
            this.rpcImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnePictureBox)).BeginInit();
            this.matchStatusGroupBox.SuspendLayout();
            this.gameModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme
            // 
            this.nsTheme.AccentOffset = 0;
            this.nsTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme.Colors = new Bloom[0];
            this.nsTheme.Controls.Add(this.optionsGroupBox);
            this.nsTheme.Controls.Add(this.minimizeButton);
            this.nsTheme.Controls.Add(this.closeButton);
            this.nsTheme.Customization = "";
            this.nsTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme.Image = null;
            this.nsTheme.Location = new System.Drawing.Point(0, 0);
            this.nsTheme.MaximumSize = new System.Drawing.Size(778, 335);
            this.nsTheme.MinimumSize = new System.Drawing.Size(719, 333);
            this.nsTheme.Movable = true;
            this.nsTheme.Name = "nsTheme";
            this.nsTheme.NoRounding = false;
            this.nsTheme.Sizable = false;
            this.nsTheme.Size = new System.Drawing.Size(778, 335);
            this.nsTheme.SmartBounds = true;
            this.nsTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme.TabIndex = 0;
            this.nsTheme.Text = "Splatoon 2 Discord RPC";
            this.nsTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme.Transparent = false;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.setStatusButton);
            this.optionsGroupBox.Controls.Add(this.rpcImageGroupBox);
            this.optionsGroupBox.Controls.Add(this.matchStatusGroupBox);
            this.optionsGroupBox.Controls.Add(this.gameModeGroupBox);
            this.optionsGroupBox.DrawSeperator = false;
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 39);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(754, 284);
            this.optionsGroupBox.SubTitle = "Choose the details RPC will display.";
            this.optionsGroupBox.TabIndex = 3;
            this.optionsGroupBox.Text = "Options";
            this.optionsGroupBox.Title = "Options";
            // 
            // setStatusButton
            // 
            this.setStatusButton.Location = new System.Drawing.Point(257, 218);
            this.setStatusButton.Name = "setStatusButton";
            this.setStatusButton.Size = new System.Drawing.Size(228, 55);
            this.setStatusButton.TabIndex = 7;
            this.setStatusButton.Text = "Set Status!";
            this.setStatusButton.Click += new System.EventHandler(this.setStatusButton_Click);
            // 
            // rpcImageGroupBox
            // 
            this.rpcImageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rpcImageGroupBox.Controls.Add(this.rpcImagePanel);
            this.rpcImageGroupBox.DrawSeperator = false;
            this.rpcImageGroupBox.Location = new System.Drawing.Point(500, 45);
            this.rpcImageGroupBox.Name = "rpcImageGroupBox";
            this.rpcImageGroupBox.Size = new System.Drawing.Size(239, 228);
            this.rpcImageGroupBox.SubTitle = "What image would you like Discord to display?";
            this.rpcImageGroupBox.TabIndex = 6;
            this.rpcImageGroupBox.Text = "Match Status";
            this.rpcImageGroupBox.Title = "RPC Image";
            // 
            // rpcImagePanel
            // 
            this.rpcImagePanel.AutoScroll = true;
            this.rpcImagePanel.Controls.Add(this.imageTwoPictureBox);
            this.rpcImagePanel.Controls.Add(this.imageTwoRadioButton);
            this.rpcImagePanel.Controls.Add(this.imageOnePictureBox);
            this.rpcImagePanel.Controls.Add(this.imageOneRadioButton);
            this.rpcImagePanel.Location = new System.Drawing.Point(12, 46);
            this.rpcImagePanel.Name = "rpcImagePanel";
            this.rpcImagePanel.Size = new System.Drawing.Size(219, 168);
            this.rpcImagePanel.TabIndex = 0;
            // 
            // imageTwoPictureBox
            // 
            this.imageTwoPictureBox.Image = global::Splatoon_2_Discord_RPC.Properties.Resources.Salmon_Run_Logo;
            this.imageTwoPictureBox.Location = new System.Drawing.Point(42, 90);
            this.imageTwoPictureBox.Name = "imageTwoPictureBox";
            this.imageTwoPictureBox.Size = new System.Drawing.Size(163, 59);
            this.imageTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageTwoPictureBox.TabIndex = 6;
            this.imageTwoPictureBox.TabStop = false;
            // 
            // imageTwoRadioButton
            // 
            this.imageTwoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageTwoRadioButton.Checked = true;
            this.imageTwoRadioButton.Location = new System.Drawing.Point(13, 108);
            this.imageTwoRadioButton.Name = "imageTwoRadioButton";
            this.imageTwoRadioButton.Size = new System.Drawing.Size(23, 23);
            this.imageTwoRadioButton.TabIndex = 5;
            // 
            // imageOnePictureBox
            // 
            this.imageOnePictureBox.Image = global::Splatoon_2_Discord_RPC.Properties.Resources.Splatoon_2_Logo;
            this.imageOnePictureBox.Location = new System.Drawing.Point(42, 12);
            this.imageOnePictureBox.Name = "imageOnePictureBox";
            this.imageOnePictureBox.Size = new System.Drawing.Size(163, 59);
            this.imageOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageOnePictureBox.TabIndex = 4;
            this.imageOnePictureBox.TabStop = false;
            // 
            // imageOneRadioButton
            // 
            this.imageOneRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageOneRadioButton.Checked = true;
            this.imageOneRadioButton.Location = new System.Drawing.Point(13, 30);
            this.imageOneRadioButton.Name = "imageOneRadioButton";
            this.imageOneRadioButton.Size = new System.Drawing.Size(23, 23);
            this.imageOneRadioButton.TabIndex = 3;
            // 
            // matchStatusGroupBox
            // 
            this.matchStatusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.matchStatusGroupBox.Controls.Add(this.lookingForFriendsRadioButton);
            this.matchStatusGroupBox.Controls.Add(this.matchmakingRadioButton);
            this.matchStatusGroupBox.Controls.Add(this.inGameRadioButton);
            this.matchStatusGroupBox.Controls.Add(this.idleRadioButton);
            this.matchStatusGroupBox.DrawSeperator = false;
            this.matchStatusGroupBox.Location = new System.Drawing.Point(257, 45);
            this.matchStatusGroupBox.Name = "matchStatusGroupBox";
            this.matchStatusGroupBox.Size = new System.Drawing.Size(228, 167);
            this.matchStatusGroupBox.SubTitle = "What\'re you doing right now?";
            this.matchStatusGroupBox.TabIndex = 5;
            this.matchStatusGroupBox.Text = "Match Status";
            this.matchStatusGroupBox.Title = "Match Status";
            // 
            // lookingForFriendsRadioButton
            // 
            this.lookingForFriendsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookingForFriendsRadioButton.Checked = false;
            this.lookingForFriendsRadioButton.Location = new System.Drawing.Point(15, 131);
            this.lookingForFriendsRadioButton.Name = "lookingForFriendsRadioButton";
            this.lookingForFriendsRadioButton.Size = new System.Drawing.Size(198, 23);
            this.lookingForFriendsRadioButton.TabIndex = 3;
            this.lookingForFriendsRadioButton.Text = "Looking For Friends";
            // 
            // matchmakingRadioButton
            // 
            this.matchmakingRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.matchmakingRadioButton.Checked = false;
            this.matchmakingRadioButton.Location = new System.Drawing.Point(15, 102);
            this.matchmakingRadioButton.Name = "matchmakingRadioButton";
            this.matchmakingRadioButton.Size = new System.Drawing.Size(198, 23);
            this.matchmakingRadioButton.TabIndex = 2;
            this.matchmakingRadioButton.Text = "Matchmaking";
            // 
            // inGameRadioButton
            // 
            this.inGameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inGameRadioButton.Checked = false;
            this.inGameRadioButton.Location = new System.Drawing.Point(15, 73);
            this.inGameRadioButton.Name = "inGameRadioButton";
            this.inGameRadioButton.Size = new System.Drawing.Size(198, 23);
            this.inGameRadioButton.TabIndex = 1;
            this.inGameRadioButton.Text = "In Game";
            // 
            // idleRadioButton
            // 
            this.idleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idleRadioButton.Checked = true;
            this.idleRadioButton.Location = new System.Drawing.Point(15, 44);
            this.idleRadioButton.Name = "idleRadioButton";
            this.idleRadioButton.Size = new System.Drawing.Size(198, 23);
            this.idleRadioButton.TabIndex = 0;
            this.idleRadioButton.Text = "Idle";
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gameModeGroupBox.Controls.Add(this.salmonRunRadioButton);
            this.gameModeGroupBox.Controls.Add(this.privateBattleRadioButton);
            this.gameModeGroupBox.Controls.Add(this.leagueRadioButton);
            this.gameModeGroupBox.Controls.Add(this.rankedRadioButton);
            this.gameModeGroupBox.Controls.Add(this.turfWarRadioButton);
            this.gameModeGroupBox.DrawSeperator = false;
            this.gameModeGroupBox.Location = new System.Drawing.Point(14, 45);
            this.gameModeGroupBox.Name = "gameModeGroupBox";
            this.gameModeGroupBox.Size = new System.Drawing.Size(228, 228);
            this.gameModeGroupBox.SubTitle = "Which game mode are you currently playing?";
            this.gameModeGroupBox.TabIndex = 4;
            this.gameModeGroupBox.Text = "Game Mode";
            this.gameModeGroupBox.Title = "Game Mode";
            // 
            // salmonRunRadioButton
            // 
            this.salmonRunRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.salmonRunRadioButton.Checked = false;
            this.salmonRunRadioButton.Location = new System.Drawing.Point(15, 172);
            this.salmonRunRadioButton.Name = "salmonRunRadioButton";
            this.salmonRunRadioButton.Size = new System.Drawing.Size(198, 23);
            this.salmonRunRadioButton.TabIndex = 4;
            this.salmonRunRadioButton.Text = "Salmon Run";
            // 
            // privateBattleRadioButton
            // 
            this.privateBattleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.privateBattleRadioButton.Checked = false;
            this.privateBattleRadioButton.Location = new System.Drawing.Point(15, 143);
            this.privateBattleRadioButton.Name = "privateBattleRadioButton";
            this.privateBattleRadioButton.Size = new System.Drawing.Size(198, 23);
            this.privateBattleRadioButton.TabIndex = 3;
            this.privateBattleRadioButton.Text = "Private Battle";
            // 
            // leagueRadioButton
            // 
            this.leagueRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.leagueRadioButton.Checked = false;
            this.leagueRadioButton.Location = new System.Drawing.Point(15, 114);
            this.leagueRadioButton.Name = "leagueRadioButton";
            this.leagueRadioButton.Size = new System.Drawing.Size(198, 23);
            this.leagueRadioButton.TabIndex = 2;
            this.leagueRadioButton.Text = "League";
            // 
            // rankedRadioButton
            // 
            this.rankedRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rankedRadioButton.Checked = false;
            this.rankedRadioButton.Location = new System.Drawing.Point(15, 85);
            this.rankedRadioButton.Name = "rankedRadioButton";
            this.rankedRadioButton.Size = new System.Drawing.Size(198, 23);
            this.rankedRadioButton.TabIndex = 1;
            this.rankedRadioButton.Text = "Ranked";
            // 
            // turfWarRadioButton
            // 
            this.turfWarRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.turfWarRadioButton.Checked = true;
            this.turfWarRadioButton.Location = new System.Drawing.Point(15, 56);
            this.turfWarRadioButton.Name = "turfWarRadioButton";
            this.turfWarRadioButton.Size = new System.Drawing.Size(198, 23);
            this.turfWarRadioButton.TabIndex = 0;
            this.turfWarRadioButton.Text = "Turf War";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.ControlButton = NSControlButton.Button.Minimize;
            this.minimizeButton.Location = new System.Drawing.Point(725, 5);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(18, 20);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "Minimize";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ControlButton = NSControlButton.Button.Close;
            this.closeButton.Location = new System.Drawing.Point(753, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.closeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 335);
            this.Controls.Add(this.nsTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(778, 335);
            this.MinimumSize = new System.Drawing.Size(719, 333);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splatoon 2 Discord RPC";
            this.nsTheme.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.rpcImageGroupBox.ResumeLayout(false);
            this.rpcImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnePictureBox)).EndInit();
            this.matchStatusGroupBox.ResumeLayout(false);
            this.gameModeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme;
        private NSControlButton closeButton;
        private NSControlButton minimizeButton;
        private NSGroupBox optionsGroupBox;
        private NSGroupBox gameModeGroupBox;
        private NSRadioButton turfWarRadioButton;
        private NSRadioButton rankedRadioButton;
        private NSRadioButton leagueRadioButton;
        private NSRadioButton privateBattleRadioButton;
        private NSRadioButton salmonRunRadioButton;
        private NSGroupBox matchStatusGroupBox;
        private NSRadioButton idleRadioButton;
        private NSRadioButton inGameRadioButton;
        private NSRadioButton matchmakingRadioButton;
        private NSGroupBox rpcImageGroupBox;
        private System.Windows.Forms.Panel rpcImagePanel;
        private NSRadioButton imageOneRadioButton;
        private System.Windows.Forms.PictureBox imageOnePictureBox;
        private NSButton setStatusButton;
        private System.Windows.Forms.PictureBox imageTwoPictureBox;
        private NSRadioButton imageTwoRadioButton;
        private NSRadioButton lookingForFriendsRadioButton;
    }
}

