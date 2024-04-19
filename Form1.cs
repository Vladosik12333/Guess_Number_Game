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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            SetGameSettings();
            OpenGameForm();
        }


        private void SetGameSettings()
        {
            int minSelectedNumber = Convert.ToInt32(minInput.Text);
            int maxSelectedNumber = Convert.ToInt32(maxInput.Text);
            string selectedDifficulty = difficultyList.SelectedItem.ToString();

            Random random = new Random();
            int randomNumber = random.Next(minSelectedNumber, maxSelectedNumber);

            GameSettings.randomNumber = randomNumber;

            switch (selectedDifficulty)
            {
                case "Easy":
                    GameSettings.selectedDifficultyTime = 70;
                    break;
                case "Medium":
                    GameSettings.selectedDifficultyTime = 50;
                    break;
                case "Hard":
                    GameSettings.selectedDifficultyTime = 30;
                    break;
                default:
                    GameSettings.selectedDifficultyTime = 70;
                    break;
            }

        }

        private void OpenGameForm()
        {
            Form2 gameForm = new Form2();
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }
    }
}
