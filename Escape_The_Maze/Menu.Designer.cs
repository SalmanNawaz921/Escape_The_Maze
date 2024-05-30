namespace Escape_The_Maze
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
            this.btn_Guide = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_PLAY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Guide
            // 
            this.btn_Guide.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guide.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guide.ForeColor = System.Drawing.Color.Red;
            this.btn_Guide.Location = new System.Drawing.Point(206, 259);
            this.btn_Guide.Name = "btn_Guide";
            this.btn_Guide.Size = new System.Drawing.Size(105, 57);
            this.btn_Guide.TabIndex = 2;
            this.btn_Guide.Text = "GUIDE";
            this.btn_Guide.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(206, 333);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(105, 51);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_PLAY
            // 
            this.btn_PLAY.BackColor = System.Drawing.Color.Transparent;
            this.btn_PLAY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PLAY.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PLAY.ForeColor = System.Drawing.Color.Red;
            this.btn_PLAY.Location = new System.Drawing.Point(206, 196);
            this.btn_PLAY.Name = "btn_PLAY";
            this.btn_PLAY.Size = new System.Drawing.Size(105, 53);
            this.btn_PLAY.TabIndex = 1;
            this.btn_PLAY.Text = "PLAY";
            this.btn_PLAY.UseVisualStyleBackColor = false;
            this.btn_PLAY.Click += new System.EventHandler(this.btn_PLAY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 55F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCAPE THE MAZE";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Escape_The_Maze.Properties.Resources.MainMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 553);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Guide);
            this.Controls.Add(this.btn_PLAY);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_PLAY;
        private System.Windows.Forms.Button btn_Guide;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
    }
}