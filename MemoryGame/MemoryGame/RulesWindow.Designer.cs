namespace MemoryGame
{
    partial class RulesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesWindow));
            this.LabelRulesAndInfo = new System.Windows.Forms.Label();
            this.textBoxRules = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelRulesAndInfo
            // 
            this.LabelRulesAndInfo.AutoSize = true;
            this.LabelRulesAndInfo.Location = new System.Drawing.Point(140, 27);
            this.LabelRulesAndInfo.Name = "LabelRulesAndInfo";
            this.LabelRulesAndInfo.Size = new System.Drawing.Size(91, 13);
            this.LabelRulesAndInfo.TabIndex = 2;
            this.LabelRulesAndInfo.Text = "Reguli si informatii";
            // 
            // textBoxRules
            // 
            this.textBoxRules.Enabled = false;
            this.textBoxRules.Location = new System.Drawing.Point(54, 102);
            this.textBoxRules.Multiline = true;
            this.textBoxRules.Name = "textBoxRules";
            this.textBoxRules.ReadOnly = true;
            this.textBoxRules.Size = new System.Drawing.Size(268, 287);
            this.textBoxRules.TabIndex = 3;
            this.textBoxRules.Text = resources.GetString("textBoxRules.Text");
            this.textBoxRules.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RulesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.textBoxRules);
            this.Controls.Add(this.LabelRulesAndInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RulesWindow";
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.RulesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelRulesAndInfo;
        private System.Windows.Forms.TextBox textBoxRules;
    }
}