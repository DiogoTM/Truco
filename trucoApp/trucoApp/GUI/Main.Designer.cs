namespace trucoApp.GUI
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnECard1 = new System.Windows.Forms.Button();
            this.btnECard2 = new System.Windows.Forms.Button();
            this.btnECard3 = new System.Windows.Forms.Button();
            this.btnMyCard3 = new System.Windows.Forms.Button();
            this.btnMyCard2 = new System.Windows.Forms.Button();
            this.btnMyCard1 = new System.Windows.Forms.Button();
            this.picZap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(508, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnECard1
            // 
            this.btnECard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnECard1.Location = new System.Drawing.Point(41, 12);
            this.btnECard1.Name = "btnECard1";
            this.btnECard1.Size = new System.Drawing.Size(75, 114);
            this.btnECard1.TabIndex = 3;
            this.btnECard1.UseVisualStyleBackColor = true;
            // 
            // btnECard2
            // 
            this.btnECard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnECard2.Location = new System.Drawing.Point(147, 12);
            this.btnECard2.Name = "btnECard2";
            this.btnECard2.Size = new System.Drawing.Size(75, 114);
            this.btnECard2.TabIndex = 4;
            this.btnECard2.UseVisualStyleBackColor = true;
            // 
            // btnECard3
            // 
            this.btnECard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnECard3.Location = new System.Drawing.Point(260, 12);
            this.btnECard3.Name = "btnECard3";
            this.btnECard3.Size = new System.Drawing.Size(75, 114);
            this.btnECard3.TabIndex = 5;
            this.btnECard3.UseVisualStyleBackColor = true;
            // 
            // btnMyCard3
            // 
            this.btnMyCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyCard3.Location = new System.Drawing.Point(260, 296);
            this.btnMyCard3.Name = "btnMyCard3";
            this.btnMyCard3.Size = new System.Drawing.Size(75, 114);
            this.btnMyCard3.TabIndex = 8;
            this.btnMyCard3.UseVisualStyleBackColor = true;
            // 
            // btnMyCard2
            // 
            this.btnMyCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyCard2.Location = new System.Drawing.Point(147, 296);
            this.btnMyCard2.Name = "btnMyCard2";
            this.btnMyCard2.Size = new System.Drawing.Size(75, 114);
            this.btnMyCard2.TabIndex = 7;
            this.btnMyCard2.UseVisualStyleBackColor = true;
            // 
            // btnMyCard1
            // 
            this.btnMyCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyCard1.Location = new System.Drawing.Point(41, 296);
            this.btnMyCard1.Name = "btnMyCard1";
            this.btnMyCard1.Size = new System.Drawing.Size(75, 114);
            this.btnMyCard1.TabIndex = 6;
            this.btnMyCard1.UseVisualStyleBackColor = true;
            // 
            // picZap
            // 
            this.picZap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picZap.Location = new System.Drawing.Point(390, 151);
            this.picZap.Name = "picZap";
            this.picZap.Size = new System.Drawing.Size(75, 114);
            this.picZap.TabIndex = 9;
            this.picZap.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picZap);
            this.Controls.Add(this.btnMyCard3);
            this.Controls.Add(this.btnMyCard2);
            this.Controls.Add(this.btnMyCard1);
            this.Controls.Add(this.btnECard3);
            this.Controls.Add(this.btnECard2);
            this.Controls.Add(this.btnECard1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnECard1;
        private System.Windows.Forms.Button btnECard2;
        private System.Windows.Forms.Button btnECard3;
        private System.Windows.Forms.Button btnMyCard3;
        private System.Windows.Forms.Button btnMyCard2;
        private System.Windows.Forms.Button btnMyCard1;
        private System.Windows.Forms.PictureBox picZap;
    }
}