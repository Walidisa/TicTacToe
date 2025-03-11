namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            resetButton = new Button();
            nextRound = new Button();
            textBoxXWins = new TextBox();
            textBoxOWins = new TextBox();
            playerX = new Label();
            playerO = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 40F);
            button1.Location = new Point(592, 97);
            button1.Name = "button1";
            button1.Size = new Size(167, 148);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 40F);
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(765, 97);
            button2.Name = "button2";
            button2.Size = new Size(167, 148);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 40F);
            button3.Location = new Point(938, 97);
            button3.Name = "button3";
            button3.Size = new Size(167, 148);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 40F);
            button4.Location = new Point(592, 251);
            button4.Name = "button4";
            button4.Size = new Size(167, 148);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 40F);
            button5.Location = new Point(765, 251);
            button5.Name = "button5";
            button5.Size = new Size(167, 148);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 40F);
            button6.Location = new Point(938, 251);
            button6.Name = "button6";
            button6.Size = new Size(167, 148);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 40F);
            button7.Location = new Point(592, 405);
            button7.Name = "button7";
            button7.Size = new Size(167, 148);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 40F);
            button8.Location = new Point(765, 405);
            button8.Name = "button8";
            button8.Size = new Size(167, 148);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 40F);
            button9.Location = new Point(938, 405);
            button9.Name = "button9";
            button9.Size = new Size(167, 148);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(255, 192, 128);
            resetButton.Image = (Image)resources.GetObject("resetButton.Image");
            resetButton.Location = new Point(29, 21);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(135, 99);
            resetButton.TabIndex = 3;
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // nextRound
            // 
            nextRound.BackColor = Color.FromArgb(255, 192, 128);
            nextRound.Font = new Font("Segoe UI", 16.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextRound.ForeColor = SystemColors.Desktop;
            nextRound.Location = new Point(49, 196);
            nextRound.Name = "nextRound";
            nextRound.Size = new Size(338, 99);
            nextRound.TabIndex = 3;
            nextRound.Text = "Next Round";
            nextRound.UseVisualStyleBackColor = false;
            nextRound.Click += nextRound_Click;
            // 
            // textBoxXWins
            // 
            textBoxXWins.BackColor = Color.FromArgb(255, 224, 192);
            textBoxXWins.Font = new Font("Segoe UI", 20F);
            textBoxXWins.Location = new Point(284, 337);
            textBoxXWins.Name = "textBoxXWins";
            textBoxXWins.ReadOnly = true;
            textBoxXWins.Size = new Size(103, 78);
            textBoxXWins.TabIndex = 4;
            textBoxXWins.Text = "0";
            textBoxXWins.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxOWins
            // 
            textBoxOWins.BackColor = Color.FromArgb(255, 224, 192);
            textBoxOWins.Font = new Font("Segoe UI", 20F);
            textBoxOWins.Location = new Point(284, 466);
            textBoxOWins.Name = "textBoxOWins";
            textBoxOWins.ReadOnly = true;
            textBoxOWins.Size = new Size(103, 78);
            textBoxOWins.TabIndex = 4;
            textBoxOWins.Text = "0";
            textBoxOWins.TextAlign = HorizontalAlignment.Center;
            // 
            // playerX
            // 
            playerX.AutoSize = true;
            playerX.BackColor = Color.FromArgb(255, 192, 128);
            playerX.Font = new Font("Segoe UI", 20F);
            playerX.Location = new Point(49, 343);
            playerX.Name = "playerX";
            playerX.Size = new Size(220, 72);
            playerX.TabIndex = 5;
            playerX.Text = "Player X";
            // 
            // playerO
            // 
            playerO.AutoSize = true;
            playerO.BackColor = Color.FromArgb(255, 192, 128);
            playerO.Font = new Font("Segoe UI", 20F);
            playerO.Location = new Point(49, 466);
            playerO.Name = "playerO";
            playerO.Size = new Size(229, 72);
            playerO.TabIndex = 5;
            playerO.Text = "Player O";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1197, 615);
            Controls.Add(playerO);
            Controls.Add(playerX);
            Controls.Add(textBoxOWins);
            Controls.Add(textBoxXWins);
            Controls.Add(nextRound);
            Controls.Add(resetButton);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button resetButton;
        private Button nextRound;
        private TextBox textBoxXWins;
        private TextBox textBoxOWins;
        private Label playerX;
        private Label playerO;
    }
}
