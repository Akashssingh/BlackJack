
namespace G19BlackJack
{
    partial class mainWin
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
            this.mainWinTitle = new System.Windows.Forms.Label();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.projectTitle = new System.Windows.Forms.Label();
            this.deckCB = new System.Windows.Forms.ComboBox();
            this.mainWinSeedLabel = new System.Windows.Forms.Label();
            this.mainWinSeed = new System.Windows.Forms.TextBox();
            this.newPlayerButton = new System.Windows.Forms.Button();
            this.modeSelectLabel = new System.Windows.Forms.Label();
            this.h17RadioBtn = new System.Windows.Forms.RadioButton();
            this.s17RadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mainWinTitle
            // 
            this.mainWinTitle.AutoSize = true;
            this.mainWinTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainWinTitle.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWinTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainWinTitle.Location = new System.Drawing.Point(93, 62);
            this.mainWinTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainWinTitle.Name = "mainWinTitle";
            this.mainWinTitle.Size = new System.Drawing.Size(560, 25);
            this.mainWinTitle.TabIndex = 0;
            this.mainWinTitle.Text = "Welcome to BlackJack. May the Lady Luck be on your side!";
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.listBoxLabel.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listBoxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxLabel.Location = new System.Drawing.Point(42, 142);
            this.listBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(240, 25);
            this.listBoxLabel.TabIndex = 1;
            this.listBoxLabel.Text = "Please Select # of Decks";
            // 
            // projectTitle
            // 
            this.projectTitle.AutoSize = true;
            this.projectTitle.BackColor = System.Drawing.Color.Transparent;
            this.projectTitle.Font = new System.Drawing.Font("Ink Free", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.projectTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectTitle.Location = new System.Drawing.Point(138, 22);
            this.projectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(451, 30);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Software Sys Dev Project 2 - Group 19";
            // 
            // deckCB
            // 
            this.deckCB.AllowDrop = true;
            this.deckCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deckCB.FormattingEnabled = true;
            this.deckCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.deckCB.Location = new System.Drawing.Point(306, 137);
            this.deckCB.Margin = new System.Windows.Forms.Padding(2);
            this.deckCB.Name = "deckCB";
            this.deckCB.Size = new System.Drawing.Size(140, 33);
            this.deckCB.TabIndex = 3;
            this.deckCB.Text = "# of Decks";
            // 
            // mainWinSeedLabel
            // 
            this.mainWinSeedLabel.AutoSize = true;
            this.mainWinSeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainWinSeedLabel.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mainWinSeedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainWinSeedLabel.Location = new System.Drawing.Point(151, 192);
            this.mainWinSeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainWinSeedLabel.Name = "mainWinSeedLabel";
            this.mainWinSeedLabel.Size = new System.Drawing.Size(131, 25);
            this.mainWinSeedLabel.TabIndex = 7;
            this.mainWinSeedLabel.Text = "Provide Seed";
            // 
            // mainWinSeed
            // 
            this.mainWinSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mainWinSeed.Location = new System.Drawing.Point(306, 187);
            this.mainWinSeed.Margin = new System.Windows.Forms.Padding(2);
            this.mainWinSeed.Name = "mainWinSeed";
            this.mainWinSeed.Size = new System.Drawing.Size(68, 30);
            this.mainWinSeed.TabIndex = 8;
            this.mainWinSeed.Text = "999";
            this.mainWinSeed.TextChanged += new System.EventHandler(this.mainWinSeed_TextChanged);
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.BackColor = System.Drawing.Color.SeaGreen;
            this.newPlayerButton.Font = new System.Drawing.Font("Ink Free", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newPlayerButton.Location = new System.Drawing.Point(268, 331);
            this.newPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(207, 51);
            this.newPlayerButton.TabIndex = 9;
            this.newPlayerButton.Text = "New Player";
            this.newPlayerButton.UseVisualStyleBackColor = false;
            this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click);
            // 
            // modeSelectLabel
            // 
            this.modeSelectLabel.AutoSize = true;
            this.modeSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.modeSelectLabel.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.modeSelectLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modeSelectLabel.Location = new System.Drawing.Point(32, 249);
            this.modeSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeSelectLabel.Name = "modeSelectLabel";
            this.modeSelectLabel.Size = new System.Drawing.Size(250, 25);
            this.modeSelectLabel.TabIndex = 4;
            this.modeSelectLabel.Text = "Please select dealer mode\r\n";
            // 
            // h17RadioBtn
            // 
            this.h17RadioBtn.AutoSize = true;
            this.h17RadioBtn.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.h17RadioBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.h17RadioBtn.Location = new System.Drawing.Point(306, 235);
            this.h17RadioBtn.Name = "h17RadioBtn";
            this.h17RadioBtn.Size = new System.Drawing.Size(71, 29);
            this.h17RadioBtn.TabIndex = 12;
            this.h17RadioBtn.TabStop = true;
            this.h17RadioBtn.Text = "H17";
            this.h17RadioBtn.UseVisualStyleBackColor = true;
            // 
            // s17RadioBtn
            // 
            this.s17RadioBtn.AutoSize = true;
            this.s17RadioBtn.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.s17RadioBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.s17RadioBtn.Location = new System.Drawing.Point(306, 262);
            this.s17RadioBtn.Name = "s17RadioBtn";
            this.s17RadioBtn.Size = new System.Drawing.Size(68, 29);
            this.s17RadioBtn.TabIndex = 13;
            this.s17RadioBtn.TabStop = true;
            this.s17RadioBtn.Text = "S17";
            this.s17RadioBtn.UseVisualStyleBackColor = true;
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(82)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(751, 424);
            this.Controls.Add(this.s17RadioBtn);
            this.Controls.Add(this.h17RadioBtn);
            this.Controls.Add(this.newPlayerButton);
            this.Controls.Add(this.mainWinSeed);
            this.Controls.Add(this.mainWinSeedLabel);
            this.Controls.Add(this.modeSelectLabel);
            this.Controls.Add(this.deckCB);
            this.Controls.Add(this.projectTitle);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.mainWinTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainWinTitle;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Label mainWinSeedLabel;
        private System.Windows.Forms.TextBox mainWinSeed;
        private System.Windows.Forms.Button newPlayerButton;
        private System.Windows.Forms.Label modeSelectLabel;
        private System.Windows.Forms.ComboBox deckCB;
        private System.Windows.Forms.RadioButton h17RadioBtn;
        private System.Windows.Forms.RadioButton s17RadioBtn;
    }
}

