namespace MemoryGame
{
    partial class ScoreWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreWindow));
            this.labelScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LABELNUME = new System.Windows.Forms.Label();
            this.scoreee = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.button2_exit = new System.Windows.Forms.Button();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(211, 93);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(22, 13);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            
            // 
            // LABELNUME
            // 
            this.LABELNUME.AutoSize = true;
            this.LABELNUME.Location = new System.Drawing.Point(112, 65);
            this.LABELNUME.Name = "LABELNUME";
            this.LABELNUME.Size = new System.Drawing.Size(39, 13);
            this.LABELNUME.TabIndex = 2;
            this.LABELNUME.Text = "NUME";
            // 
            // scoreee
            // 
            this.scoreee.AutoSize = true;
            this.scoreee.Location = new System.Drawing.Point(201, 65);
            this.scoreee.Name = "scoreee";
            this.scoreee.Size = new System.Drawing.Size(44, 13);
            this.scoreee.TabIndex = 3;
            this.scoreee.Text = "SCORE";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(112, 93);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(19, 13);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "....";
            // 
            // button2_exit
            // 
            this.button2_exit.Location = new System.Drawing.Point(144, 241);
            this.button2_exit.Name = "button2_exit";
            this.button2_exit.Size = new System.Drawing.Size(75, 23);
            this.button2_exit.TabIndex = 5;
            this.button2_exit.Text = "Exit";
            this.button2_exit.UseVisualStyleBackColor = true;
            this.button2_exit.Click += new System.EventHandler(this.button2_exit_Click);
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Location = new System.Drawing.Point(144, 271);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayAgain.TabIndex = 6;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // ScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(380, 399);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.button2_exit);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.scoreee);
            this.Controls.Add(this.LABELNUME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoreWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreWindow";
            this.Load += new System.EventHandler(this.ScoreWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABELNUME;
        private System.Windows.Forms.Label scoreee;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button button2_exit;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}