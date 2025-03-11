namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean turn = true; // true = X turn; false = O turn
        int turn_count = 0;
        int x_wins = 0;
        int o_wins = 0;
        Boolean win = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Disable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void turnChange(int buttonin)
        {
            turn_count++;
            if (turn == true)
            {
                if (buttonin == 1)
                {
                    button1.Text = "X";
                    button1.Enabled = false;
                }
                if (buttonin == 2)
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                }
                if (buttonin == 3)
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                }
                if (buttonin == 4)
                {
                    button4.Text = "X";
                    button4.Enabled = false;
                }
                if (buttonin == 5)
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                }
                if (buttonin == 6)
                {
                    button6.Text = "X";
                    button6.Enabled = false;
                }
                if (buttonin == 7)
                {
                    button7.Text = "X";
                    button7.Enabled = false;
                }
                if (buttonin == 8)
                {
                    button8.Text = "X";
                    button8.Enabled = false;
                }
                if (buttonin == 9)
                {
                    button9.Text = "X";
                    button9.Enabled = false;
                }

                turn = false;
            }
            else
            {
                if (buttonin == 1)
                {
                    button1.Text = "O";
                    button1.Enabled = false;
                }
                if (buttonin == 2)
                {
                    button2.Text = "O";
                    button2.Enabled = false;
                }
                if (buttonin == 3)
                {
                    button3.Text = "O";
                    button3.Enabled = false;
                }
                if (buttonin == 4)
                {
                    button4.Text = "O";
                    button4.Enabled = false;
                }
                if (buttonin == 5)
                {
                    button5.Text = "O";
                    button5.Enabled = false;
                }
                if (buttonin == 6)
                {
                    button6.Text = "O";
                    button6.Enabled = false;
                }
                if (buttonin == 7)
                {
                    button7.Text = "O";
                    button7.Enabled = false;
                }
                if (buttonin == 8)
                {
                    button8.Text = "O";
                    button8.Enabled = false;
                }
                if (buttonin == 9)
                {
                    button9.Text = "O";
                    button9.Enabled = false;
                }
                turn = true;
            }
            if (turn_count == 9)
            {
                MessageBox.Show("Draw!");
                Disable(); // Disable all buttons
            }
        }

        public void wins()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                x_wins++;
                textBoxXWins.Text = "X wins: " + x_wins;
                textBoxXWins.Text = x_wins.ToString(); // Update TextBox with x_wins
                Disable(); // Disable all buttons
                win = true;
            }
            // O wins
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button3.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button1.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                o_wins++;
                textBoxOWins.Text = "O wins: " + o_wins;
                textBoxOWins.Text = o_wins.ToString(); // Update TextBox with o_wins
                Disable(); // Disable all buttons
                win = true;
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            turn = true;
            turn_count = 0;
            x_wins = 0;
            o_wins = 0;
            textBoxXWins.Text = x_wins.ToString();
            textBoxOWins.Text = o_wins.ToString();
        }
        private void nextRound_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            turn = true;
            turn_count = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            turnChange(1);
            wins();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            turnChange(2);
            wins();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            turnChange(3);
            wins();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turnChange(4);
            wins();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            turnChange(5);
            wins();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            turnChange(6);
            wins();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            turnChange(7);
            wins();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            turnChange(8);
            wins();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            turnChange(9);
            wins();
        }


    }
}
