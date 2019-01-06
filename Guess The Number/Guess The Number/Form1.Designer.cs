namespace Guess_The_Number
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TryLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.RetryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(177, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess The Number Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TryLabel
            // 
            this.TryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TryLabel.AutoSize = true;
            this.TryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TryLabel.Location = new System.Drawing.Point(91, 258);
            this.TryLabel.Name = "TryLabel";
            this.TryLabel.Size = new System.Drawing.Size(69, 25);
            this.TryLabel.TabIndex = 1;
            this.TryLabel.Text = "Tries: 0";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(204, 143);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(100, 52);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(204, 211);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 3;
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(219, 258);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(75, 23);
            this.GuessButton.TabIndex = 4;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RetryButton.Location = new System.Drawing.Point(219, 258);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(75, 23);
            this.RetryButton.TabIndex = 5;
            this.RetryButton.Text = "Play again";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Visible = false;
            this.RetryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(177, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Do you want to play again?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.TryLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(523, 489);
            this.MinimumSize = new System.Drawing.Size(523, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TryLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Label label2;
    }
}

