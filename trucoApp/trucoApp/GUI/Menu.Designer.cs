namespace trucoApp.GUI
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.btnNew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnDifficulty = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(52, 42);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(299, 32);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Continue Game";
            this.toolTip1.SetToolTip(this.button2, "Not ready yet, sorry =/");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(52, 118);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(299, 32);
            this.btnPlayer.TabIndex = 4;
            this.btnPlayer.Text = "Player Info";
            this.toolTip1.SetToolTip(this.btnPlayer, "Not ready yet, sorry =/\r\n");
            this.btnPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDifficulty
            // 
            this.btnDifficulty.Location = new System.Drawing.Point(52, 156);
            this.btnDifficulty.Name = "btnDifficulty";
            this.btnDifficulty.Size = new System.Drawing.Size(299, 32);
            this.btnDifficulty.TabIndex = 5;
            this.btnDifficulty.Text = "Difficulty: Easy";
            this.btnDifficulty.UseVisualStyleBackColor = true;
            this.btnDifficulty.Click += new System.EventHandler(this.btnDifficulty_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(52, 194);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(299, 32);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(52, 232);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(299, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Game";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Not Ready yet, sorry =/";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(398, 306);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDifficulty);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnDifficulty;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBack;
    }
}