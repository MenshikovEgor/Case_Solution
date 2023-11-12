using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        String playerChoice = "";
        String ComputerChoise = "";
        int round = 1;
        int wins = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            getRndmNumb();

            if (ComputerChoise == playerChoice)
            {
                tie();
            }
            if (ComputerChoise == "Paper")
            {
                lose();
            }
            if (ComputerChoise == "Scissors")
            {
                win();
            }
            round++;
            RoundTXT.Text = "Rounds: " + round;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            getRndmNumb();

            if (ComputerChoise == playerChoice)
            {
                tie();
            }
            if (ComputerChoise == "Scissors")
            {
                lose();
            }
            if (ComputerChoise == "Rock")
            {
                win();
            }
            round++;
            RoundTXT.Text = "Сыграно: " + round;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            getRndmNumb();

            if (ComputerChoise == playerChoice)
            {
                tie();
            }
            if (ComputerChoise == "Rock")
            {
                lose();
            }
            if (ComputerChoise == "Paper")
            {
                win();
            }
            round++;
            RoundTXT.Text = "Сыграно: " + round;
        }


        void getRndmNumb()
        {
            Random random = new Random();

            int rndmNumb = random.Next(1, 4);

            if (rndmNumb == 1)
            {
                ComputerChoise = "Rock";
            }
            else if (rndmNumb == 2)
            {
                ComputerChoise = "Paper";
            }
            else if (rndmNumb == 3)
            {
                ComputerChoise = "Scissors";
            }
        }

        void lose()
        {
            MessageBox.Show("Вы проиграли!");
        }
        void win()
        {
            MessageBox.Show("Вы выиграли!");
            wins++;
            winsTXT.Text = "Победы: " + wins;
        }
        void tie()
        {
            MessageBox.Show("Ничья!");
        }

        private void RoundTXT_Click(object sender, EventArgs e)
        {

        }
    }
}
