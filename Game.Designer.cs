namespace AnotherPacman
{
    partial class Game
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
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.LightYellow;
            this.labelGameOver.Location = new System.Drawing.Point(51, 172);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(461, 85);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelScore.Location = new System.Drawing.Point(12, 589);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(109, 56);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 620);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelGameOver);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelScore;
    }
}

