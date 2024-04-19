using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64632_Vladyslav_Babiak_Task_5
{
    public partial class Form2 : Form
    {
        private bool gameRunning = false;
        private int timeLeft = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (gameRunning)
            {
                CheckGuessedNumber();
            }
            else
            {
                RunGame();
            }
        }

        private void RunGame()
        {
            timer1.Start();
            generatedNumberOutput.Text = "Guess !";
            timeLeft = GameSettings.selectedDifficultyTime;
            gameRunning = true;
        }

        private void CheckGuessedNumber()
        {
            int guessedNumber = Convert.ToInt32(numberInput.Text);

            if (guessedNumber == GameSettings.randomNumber)
            {
                MessageBox.Show("You WON!");
                ShowStartForm();
            }
            else if (guessedNumber < GameSettings.randomNumber)
            {
                generatedNumberOutput.Text = "Guess Higher!";
            }
            else if (guessedNumber > GameSettings.randomNumber)
            {
                generatedNumberOutput.Text = "Guess Lower!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            timerRestOutput.Text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You LOST!");
                ShowStartForm();
            }
        }

        private void ShowStartForm()
        {
            timer1.Stop();
            Form1 startForm = new Form1();
            this.Hide();
            startForm.ShowDialog();
            this.Close();
        }

        private void timerRestOutput_Click(object sender, EventArgs e)
        {

        }

        private void numberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatedNumberOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
