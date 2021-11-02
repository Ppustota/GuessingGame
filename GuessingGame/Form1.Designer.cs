
namespace GuessingGame
{
    partial class GuessingGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.JapaneseButton = new System.Windows.Forms.Button();
            this.ChineseButton = new System.Windows.Forms.Button();
            this.KoreanButton = new System.Windows.Forms.Button();
            this.ThaiButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureChange = new System.Windows.Forms.Timer(this.components);
            this.pictureMove = new System.Windows.Forms.Timer(this.components);
            this.pointsBox = new System.Windows.Forms.TextBox();
            this.playAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JapaneseButton
            // 
            this.JapaneseButton.Location = new System.Drawing.Point(1, 1);
            this.JapaneseButton.Name = "JapaneseButton";
            this.JapaneseButton.Size = new System.Drawing.Size(75, 23);
            this.JapaneseButton.TabIndex = 0;
            this.JapaneseButton.Tag = "Japanese";
            this.JapaneseButton.Text = "Japanese";
            this.JapaneseButton.UseVisualStyleBackColor = true;
            this.JapaneseButton.Click += new System.EventHandler(this.JapaneseButton_Click);
            // 
            // ChineseButton
            // 
            this.ChineseButton.Location = new System.Drawing.Point(726, 1);
            this.ChineseButton.Name = "ChineseButton";
            this.ChineseButton.Size = new System.Drawing.Size(75, 23);
            this.ChineseButton.TabIndex = 1;
            this.ChineseButton.Tag = "Chinese";
            this.ChineseButton.Text = "Chinese";
            this.ChineseButton.UseVisualStyleBackColor = true;
            this.ChineseButton.Click += new System.EventHandler(this.ChineseButton_Click);
            // 
            // KoreanButton
            // 
            this.KoreanButton.Location = new System.Drawing.Point(1, 426);
            this.KoreanButton.Name = "KoreanButton";
            this.KoreanButton.Size = new System.Drawing.Size(75, 23);
            this.KoreanButton.TabIndex = 2;
            this.KoreanButton.Tag = "Korean";
            this.KoreanButton.Text = "Korean";
            this.KoreanButton.UseVisualStyleBackColor = true;
            this.KoreanButton.Click += new System.EventHandler(this.KoreanButton_Click);
            // 
            // ThaiButton
            // 
            this.ThaiButton.Location = new System.Drawing.Point(726, 426);
            this.ThaiButton.Name = "ThaiButton";
            this.ThaiButton.Size = new System.Drawing.Size(75, 23);
            this.ThaiButton.TabIndex = 3;
            this.ThaiButton.Tag = "Thai";
            this.ThaiButton.Text = "Thai";
            this.ThaiButton.UseVisualStyleBackColor = true;
            this.ThaiButton.Click += new System.EventHandler(this.ThaiButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(250, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureChange
            // 
            this.pictureChange.Enabled = true;
            this.pictureChange.Interval = 3000;
            this.pictureChange.Tick += new System.EventHandler(this.pictureChange_Tick);
            // 
            // pictureMove
            // 
            this.pictureMove.Enabled = true;
            this.pictureMove.Tick += new System.EventHandler(this.pictureMove_Tick);
            // 
            // pointsBox
            // 
            this.pointsBox.Location = new System.Drawing.Point(296, 415);
            this.pointsBox.Name = "pointsBox";
            this.pointsBox.ReadOnly = true;
            this.pointsBox.Size = new System.Drawing.Size(152, 23);
            this.pointsBox.TabIndex = 5;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playAgainButton.Location = new System.Drawing.Point(296, 232);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(191, 55);
            this.playAgainButton.TabIndex = 6;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.pointsBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ThaiButton);
            this.Controls.Add(this.KoreanButton);
            this.Controls.Add(this.ChineseButton);
            this.Controls.Add(this.JapaneseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessingGame";
            this.Load += new System.EventHandler(this.GuessingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JapaneseButton;
        private System.Windows.Forms.Button ChineseButton;
        private System.Windows.Forms.Button KoreanButton;
        private System.Windows.Forms.Button ThaiButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer pictureChange;
        private System.Windows.Forms.Timer pictureMove;
        private System.Windows.Forms.TextBox pointsBox;
        private System.Windows.Forms.Button playAgainButton;
    }
}

