namespace Escape_The_Maze
{
    partial class Game_Form
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
            this.Game_Loop = new System.Windows.Forms.Timer(this.components);
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_ScoreCount = new System.Windows.Forms.Label();
            this.lbl_Lives = new System.Windows.Forms.Label();
            this.pB_Life3 = new System.Windows.Forms.PictureBox();
            this.pB_Life2 = new System.Windows.Forms.PictureBox();
            this.pB_Life1 = new System.Windows.Forms.PictureBox();
            this.bar_Health = new System.Windows.Forms.ProgressBar();
            this.lbl_Health = new System.Windows.Forms.Label();
            this.lbl_DragonHealth = new System.Windows.Forms.Label();
            this.bar_Dragon = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Life1)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_Loop
            // 
            this.Game_Loop.Enabled = true;
            this.Game_Loop.Interval = 16;
            this.Game_Loop.Tick += new System.EventHandler(this.Game_Loop_Tick);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Ravie", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Score.Location = new System.Drawing.Point(1525, 101);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(157, 39);
            this.lbl_Score.TabIndex = 0;
            this.lbl_Score.Text = "Score :";
            // 
            // lbl_ScoreCount
            // 
            this.lbl_ScoreCount.AutoSize = true;
            this.lbl_ScoreCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ScoreCount.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScoreCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ScoreCount.Location = new System.Drawing.Point(1679, 93);
            this.lbl_ScoreCount.Name = "lbl_ScoreCount";
            this.lbl_ScoreCount.Size = new System.Drawing.Size(51, 50);
            this.lbl_ScoreCount.TabIndex = 1;
            this.lbl_ScoreCount.Text = "0";
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lives.Font = new System.Drawing.Font("Ravie", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Lives.Location = new System.Drawing.Point(1525, 162);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(151, 39);
            this.lbl_Lives.TabIndex = 2;
            this.lbl_Lives.Text = "Lives :";
            // 
            // pB_Life3
            // 
            this.pB_Life3.BackColor = System.Drawing.Color.Transparent;
            this.pB_Life3.Image = global::Escape_The_Maze.Properties.Resources.Heart;
            this.pB_Life3.Location = new System.Drawing.Point(1682, 163);
            this.pB_Life3.Name = "pB_Life3";
            this.pB_Life3.Size = new System.Drawing.Size(42, 38);
            this.pB_Life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Life3.TabIndex = 3;
            this.pB_Life3.TabStop = false;
            // 
            // pB_Life2
            // 
            this.pB_Life2.BackColor = System.Drawing.Color.Transparent;
            this.pB_Life2.Image = global::Escape_The_Maze.Properties.Resources.Heart;
            this.pB_Life2.Location = new System.Drawing.Point(1726, 163);
            this.pB_Life2.Name = "pB_Life2";
            this.pB_Life2.Size = new System.Drawing.Size(42, 38);
            this.pB_Life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Life2.TabIndex = 4;
            this.pB_Life2.TabStop = false;
            // 
            // pB_Life1
            // 
            this.pB_Life1.BackColor = System.Drawing.Color.Transparent;
            this.pB_Life1.Image = global::Escape_The_Maze.Properties.Resources.Heart;
            this.pB_Life1.Location = new System.Drawing.Point(1765, 163);
            this.pB_Life1.Name = "pB_Life1";
            this.pB_Life1.Size = new System.Drawing.Size(42, 38);
            this.pB_Life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Life1.TabIndex = 5;
            this.pB_Life1.TabStop = false;
            // 
            // bar_Health
            // 
            this.bar_Health.Location = new System.Drawing.Point(1709, 228);
            this.bar_Health.Name = "bar_Health";
            this.bar_Health.Size = new System.Drawing.Size(163, 25);
            this.bar_Health.TabIndex = 6;
            this.bar_Health.Value = 100;
            // 
            // lbl_Health
            // 
            this.lbl_Health.AutoSize = true;
            this.lbl_Health.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Health.Font = new System.Drawing.Font("Ravie", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Health.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Health.Location = new System.Drawing.Point(1525, 218);
            this.lbl_Health.Name = "lbl_Health";
            this.lbl_Health.Size = new System.Drawing.Size(178, 39);
            this.lbl_Health.TabIndex = 7;
            this.lbl_Health.Text = "Health :";
            // 
            // lbl_DragonHealth
            // 
            this.lbl_DragonHealth.AutoSize = true;
            this.lbl_DragonHealth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DragonHealth.Font = new System.Drawing.Font("Ravie", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DragonHealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DragonHealth.Location = new System.Drawing.Point(1510, 272);
            this.lbl_DragonHealth.Name = "lbl_DragonHealth";
            this.lbl_DragonHealth.Size = new System.Drawing.Size(184, 39);
            this.lbl_DragonHealth.TabIndex = 8;
            this.lbl_DragonHealth.Text = "Dragon :";
            // 
            // bar_Dragon
            // 
            this.bar_Dragon.Location = new System.Drawing.Point(1709, 286);
            this.bar_Dragon.Name = "bar_Dragon";
            this.bar_Dragon.Size = new System.Drawing.Size(163, 25);
            this.bar_Dragon.TabIndex = 9;
            this.bar_Dragon.Value = 100;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1879, 781);
            this.Controls.Add(this.bar_Dragon);
            this.Controls.Add(this.lbl_DragonHealth);
            this.Controls.Add(this.lbl_Health);
            this.Controls.Add(this.bar_Health);
            this.Controls.Add(this.pB_Life1);
            this.Controls.Add(this.pB_Life2);
            this.Controls.Add(this.pB_Life3);
            this.Controls.Add(this.lbl_Lives);
            this.Controls.Add(this.lbl_ScoreCount);
            this.Controls.Add(this.lbl_Score);
            this.DoubleBuffered = true;
            this.Name = "Game_Form";
            this.Text = "Escape The Maze";
            this.Load += new System.EventHandler(this.Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Life1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Game_Loop;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_ScoreCount;
        private System.Windows.Forms.Label lbl_Lives;
        private System.Windows.Forms.PictureBox pB_Life3;
        private System.Windows.Forms.PictureBox pB_Life2;
        private System.Windows.Forms.PictureBox pB_Life1;
        private System.Windows.Forms.ProgressBar bar_Health;
        private System.Windows.Forms.Label lbl_Health;
        private System.Windows.Forms.Label lbl_DragonHealth;
        private System.Windows.Forms.ProgressBar bar_Dragon;
    }
}

