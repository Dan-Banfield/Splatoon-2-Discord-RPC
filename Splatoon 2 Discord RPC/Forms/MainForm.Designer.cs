
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
            this.SuspendLayout();
            // 
            // nsTheme
            // 
            this.nsTheme.AccentOffset = 0;
            this.nsTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme.Colors = new Bloom[0];
            this.nsTheme.Customization = "";
            this.nsTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme.Image = null;
            this.nsTheme.Location = new System.Drawing.Point(0, 0);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 333);
            this.Controls.Add(this.nsTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splatoon 2 Discord RPC";
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme;
    }
}

