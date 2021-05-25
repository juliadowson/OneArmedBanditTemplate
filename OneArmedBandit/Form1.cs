using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();

        // int value for score initialized to 10
        int scoreValue = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int picture1;
            int picture2; 
            int picture3;

            picture1 = randGen.Next(1, 4);
            picture2 = randGen.Next(1, 4);
            picture3 = randGen.Next(1, 4);

            // check value of reel 1 with a switch statement and set appropriate image
            switch (picture1)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement and set appropriate image
            switch (picture2)
            {
                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image
            switch (picture3)
            {
                case 1:
                    pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------
           

            // Use compound if statement to check if all reels are equal.
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.  
            if (picture1 == picture2 && picture1 == picture3)
            {
                outputLabel.Text = "WINNER!";
                scoreValue = scoreValue + 3;
                scoreDisplay.Text = $"{scoreValue}";
                //scoreValue = Convert.ToInt32(scoreDisplay.Text);
                
            }
            else
            {
                outputLabel.Text = "Play again?";
                scoreValue = scoreValue - 1;
                scoreDisplay.Text = $"{scoreValue}";
                //scoreDisplay.Text = scoreValue;

            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (scoreValue == 0)
            {
                spinButton.Enabled = false;
                outputLabel.Text = "YOU LOSE!";
                spinButton.BackColor = Color.Red;
            }

            // display updated score

        }
    }
}
