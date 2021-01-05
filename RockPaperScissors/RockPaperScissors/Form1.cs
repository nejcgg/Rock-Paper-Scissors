using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var computer_rand = new Random();

            string computer_rock = "rock";
            string computer_paper = "paper";
            string computer_scissors = "scissors";

            var computer_random = new Random();

            // Making a list with rock paper scissors
            var computer_list = new List<string> { computer_paper, computer_rock, computer_scissors };

            int computer_index = computer_random.Next(computer_list.Count);

            var rand = new Random();

            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";

            var random = new Random();

            var list = new List<string> { rock, paper, scissors };

            int index = random.Next(list.Count);

            string computer_tool = computer_list[computer_index];

            string human_tool = "rock";

            // Checking results and showing a MessageBox with the results
            if (human_tool == computer_tool)
            {
                MessageBox.Show("The computer and you have picked the same tool.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (human_tool == "scissors")
                {
                    if (computer_tool == "paper")
                    {
                        MessageBox.Show("You have won because the computer has picked paper!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (computer_tool == "rock")
                    {
                        MessageBox.Show("You have lost because the computer has picked scissors.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (human_tool == "paper")
                {
                    if (computer_tool == "scissors")
                    {
                        MessageBox.Show("You have lost because the computer has picked scissors!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (computer_tool == "rock")
                    {
                        MessageBox.Show("You have won because the computer has picked rock.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (human_tool == "rock")
                {
                    if (computer_tool == "scissors")
                    {
                        MessageBox.Show("You have won because the computer has picked scissors!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (computer_tool == "paper")
                    {
                        MessageBox.Show("You have lost because the computer has picked paper.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var computer_rand = new Random();

            string computer_rock = "rock";
            string computer_paper = "paper";
            string computer_scissors = "scissors";

            var computer_random = new Random();

            var computer_list = new List<string> { computer_paper, computer_rock, computer_scissors };

            int computer_index = computer_random.Next(computer_list.Count);

            var rand = new Random();

            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";

            var random = new Random();

            // Making a list with rock paper scissors
            var list = new List<string> { rock, paper, scissors };

            int index = random.Next(list.Count);

            string computer_tool = computer_list[computer_index];

            string human_tool = "paper";

            // Checking results and showing a messagebox with the results
            if (human_tool == computer_tool)
            {
                MessageBox.Show("The computer and you have picked the same tool.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (human_tool == "scissors")
                {
                    if (computer_tool == "paper")
                    {
                        MessageBox.Show("You have won because the computer has picked paper!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (computer_tool == "rock")
                    {
                        MessageBox.Show("You have lost because the computer has picked scissors.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (human_tool == "paper")
                {
                    if (computer_tool == "scissors")
                    {
                        MessageBox.Show("You have lost because the computer has picked scissors!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (computer_tool == "rock")
                    {
                        MessageBox.Show("You have won because the computer has picked rock.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (human_tool == "rock")
                {
                    if (computer_tool == "scissors")
                    {
                        MessageBox.Show("You have won because the computer has picked scissors!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (computer_tool == "paper")
                    {
                        MessageBox.Show("You have won because the computer has picked paper.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var computer_rand = new Random();

            string computer_rock = "rock";
            string computer_paper = "paper";
            string computer_scissors = "scissors";

            var computer_random = new Random();

            // Making a list with rock paper scissors
            var computer_list = new List<string> { computer_paper, computer_rock, computer_scissors };

            int computer_index = computer_random.Next(computer_list.Count);

            var rand = new Random();

            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";

            var random = new Random();

            var list = new List<string> { rock, paper, scissors };

            int index = random.Next(list.Count);

            string computer_tool = computer_list[computer_index];

            string human_tool = "scissors";

            // Checking results and showing a messagebox with the results
            if (human_tool == computer_tool)
            {
                MessageBox.Show("The computer and you have picked the same tool.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (human_tool == "scissors")
                {
                    if (computer_tool == "paper")
                    {
                        MessageBox.Show("You have won because the computer has picked paper!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (computer_tool == "rock")
                    {
                        MessageBox.Show("You have lost because the computer has picked scissors.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (human_tool == "paper")
                {
                    if (computer_tool == "scissors")
                    {
                        MessageBox.Show("You have lost because the computer has picked scissors!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (computer_tool == "rock")
                    {
                        MessageBox.Show("You have won because the computer has picked rock.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (human_tool == "rock")
                {
                    if (computer_tool == "scissors")
                    {
                        MessageBox.Show("You have won because the computer has picked scissors!", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (computer_tool == "paper")
                    {
                        MessageBox.Show("You have won because the computer has picked paper.", "Rock Paper Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
