using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        int answer = 0;
        int guess = 0;
        int tries = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            answer = rnd.Next(1, 101); //Changes answer to random number (1-100)




        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            tries++;
            TryLabel.Text = ($"Tries: {tries}");
            try
            {
                guess = Convert.ToInt32(textBox.Text); //convert your answer to int
            }
            catch (Exception)
            {

            }
            if (guess == answer)
            {
                GuessButton.Visible = false;
                AnswerLabel.Text = ("You win!");
                RetryButton.Visible = true;
                label2.Visible = true;
            }
            else if (guess < answer)
            {
                AnswerLabel.Text = ("Your number was too low!");
            }
            else if (guess > answer)
            {
                AnswerLabel.Text = ("Your number was too high!");
            }

        }

        private void button2_Click(object sender, EventArgs e) //resets everything
        {
             answer = rnd.Next(1, 101);
             guess = 0;
             tries = 0;
            TryLabel.Text = ($"Tries: {tries}");
        }
    }
}
