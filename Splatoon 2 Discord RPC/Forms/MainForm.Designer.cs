
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
            this.nsTheme = new NSTheme();
            this.closeButton = new NSControlButton();
            this.maximizeRestoreButton = new NSControlButton();
            this.minimizeButton = new NSControlButton();
            this.optionsGroupBox = new NSGroupBox();
            this.gameModeGroupBox = new NSGroupBox();
            this.turfWarRadioButton = new NSRadioButton();
            this.rankedRadioButton = new NSRadioButton();
            this.leagueRadioButton = new NSRadioButton();
            this.privateBattleRadioButton = new NSRadioButton();
            this.salmonRunRadioButton = new NSRadioButton();
            this.nsTheme.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
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
            this.nsTheme.Controls.Add(this.maximizeRestoreButton);
            this.nsTheme.Controls.Add(this.closeButton);
            this.nsTheme.Customization = "";
            this.nsTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme.Image = null;
            this.nsTheme.Location = new System.Drawing.Point(0, 0);
            this.nsTheme.MaximumSize = new System.Drawing.Size(779, 363);
            this.nsTheme.MinimumSize = new System.Drawing.Size(719, 333);
            this.nsTheme.Movable = true;
            this.nsTheme.Name = "nsTheme";
            this.nsTheme.NoRounding = false;
            this.nsTheme.Sizable = true;
            this.nsTheme.Size = new System.Drawing.Size(719, 333);
            this.nsTheme.SmartBounds = true;
            this.nsTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme.TabIndex = 0;
            this.nsTheme.Text = "Splatoon 2 Discord RPC";
            this.nsTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme.Transparent = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ControlButton = NSControlButton.Button.Close;
            this.closeButton.Location = new System.Drawing.Point(694, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.closeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            // 
            // maximizeRestoreButton
            // 
            this.maximizeRestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeRestoreButton.ControlButton = NSControlButton.Button.MaximizeRestore;
            this.maximizeRestoreButton.Location = new System.Drawing.Point(665, 5);
            this.maximizeRestoreButton.Margin = new System.Windows.Forms.Padding(0);
            this.maximizeRestoreButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.maximizeRestoreButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.maximizeRestoreButton.Name = "maximizeRestoreButton";
            this.maximizeRestoreButton.Size = new System.Drawing.Size(18, 20);
            this.maximizeRestoreButton.TabIndex = 1;
            this.maximizeRestoreButton.Text = "Maximize/Restore";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.ControlButton = NSControlButton.Button.Minimize;
            this.minimizeButton.Location = new System.Drawing.Point(636, 5);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(18, 20);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "Minimize";
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.gameModeGroupBox);
            this.optionsGroupBox.DrawSeperator = false;
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 39);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(695, 282);
            this.optionsGroupBox.SubTitle = "Choose the details RPC will display.";
            this.optionsGroupBox.TabIndex = 3;
            this.optionsGroupBox.Text = "Options";
            this.optionsGroupBox.Title = "Options";
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameModeGroupBox.Controls.Add(this.salmonRunRadioButton);
            this.gameModeGroupBox.Controls.Add(this.privateBattleRadioButton);
            this.gameModeGroupBox.Controls.Add(this.leagueRadioButton);
            this.gameModeGroupBox.Controls.Add(this.rankedRadioButton);
            this.gameModeGroupBox.Controls.Add(this.turfWarRadioButton);
            this.gameModeGroupBox.DrawSeperator = false;
            this.gameModeGroupBox.Location = new System.Drawing.Point(14, 45);
            this.gameModeGroupBox.Name = "gameModeGroupBox";
            this.gameModeGroupBox.Size = new System.Drawing.Size(228, 226);
            this.gameModeGroupBox.SubTitle = "Which game mode are you currently playing?";
            this.gameModeGroupBox.TabIndex = 4;
            this.gameModeGroupBox.Text = "Game Mode";
            this.gameModeGroupBox.Title = "Game Mode";
            // 
            // turfWarRadioButton
            // 
            this.turfWarRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.turfWarRadioButton.Checked = false;
            this.turfWarRadioButton.Location = new System.Drawing.Point(15, 55);
            this.turfWarRadioButton.Name = "turfWarRadioButton";
            this.turfWarRadioButton.Size = new System.Drawing.Size(198, 23);
            this.turfWarRadioButton.TabIndex = 0;
            this.turfWarRadioButton.Text = "Turf War";
            // 
            // rankedRadioButton
            // 
            this.rankedRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rankedRadioButton.Checked = false;
            this.rankedRadioButton.Location = new System.Drawing.Point(15, 84);
            this.rankedRadioButton.Name = "rankedRadioButton";
            this.rankedRadioButton.Size = new System.Drawing.Size(198, 23);
            this.rankedRadioButton.TabIndex = 1;
            this.rankedRadioButton.Text = "Ranked";
            // 
            // leagueRadioButton
            // 
            this.leagueRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.leagueRadioButton.Checked = false;
            this.leagueRadioButton.Location = new System.Drawing.Point(15, 113);
            this.leagueRadioButton.Name = "leagueRadioButton";
            this.leagueRadioButton.Size = new System.Drawing.Size(198, 23);
            this.leagueRadioButton.TabIndex = 2;
            this.leagueRadioButton.Text = "League";
            // 
            // privateBattleRadioButton
            // 
            this.privateBattleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.privateBattleRadioButton.Checked = false;
            this.privateBattleRadioButton.Location = new System.Drawing.Point(15, 142);
            this.privateBattleRadioButton.Name = "privateBattleRadioButton";
            this.privateBattleRadioButton.Size = new System.Drawing.Size(198, 23);
            this.privateBattleRadioButton.TabIndex = 3;
            this.privateBattleRadioButton.Text = "Private Battle";
            // 
            // salmonRunRadioButton
            // 
            this.salmonRunRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.salmonRunRadioButton.Checked = false;
            this.salmonRunRadioButton.Location = new System.Drawing.Point(15, 171);
            this.salmonRunRadioButton.Name = "salmonRunRadioButton";
            this.salmonRunRadioButton.Size = new System.Drawing.Size(198, 23);
            this.salmonRunRadioButton.TabIndex = 4;
            this.salmonRunRadioButton.Text = "Salmon Run";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 333);
            this.Controls.Add(this.nsTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(779, 363);
            this.MinimumSize = new System.Drawing.Size(719, 333);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splatoon 2 Discord RPC";
            this.nsTheme.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.gameModeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme;
        private NSControlButton closeButton;
        private NSControlButton maximizeRestoreButton;
        private NSControlButton minimizeButton;
        private NSGroupBox optionsGroupBox;
        private NSGroupBox gameModeGroupBox;
        private NSRadioButton turfWarRadioButton;
        private NSRadioButton rankedRadioButton;
        private NSRadioButton leagueRadioButton;
        private NSRadioButton privateBattleRadioButton;
        private NSRadioButton salmonRunRadioButton;
    }
}

