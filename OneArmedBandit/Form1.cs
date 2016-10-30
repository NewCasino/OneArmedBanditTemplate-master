///Satvir Uppal
///October 29 2016 @ 9:45 PM
///DONE IN 20MINS
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
        int score = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int reel1Value = randGen.Next(1, 4);
            int reel2Value = randGen.Next(1, 4);
            int reel3Value = randGen.Next(1, 4);

            // check value of reel 1 with a switch statement and set appropriate image

            switch (reel1Value)
            {
                case 1:
                    reel1.Image = Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel1.Image = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel1.Image = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement and set appropriate image

            switch (reel2Value)
            {
                case 1:
                    reel2.Image = Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel2.Image = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel2.Image = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image

            switch (reel3Value)
            {
                case 1:
                    reel3.Image = Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel3.Image = Properties.Resources.cherry_100x125;
                        break;
                case 3:
                    reel3.Image = Properties.Resources.diamond_100x125;
                    break;
            }


            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal.
            if (reel1Value == reel2Value && reel3Value == reel1Value && reel3Value == reel2Value)
            {
                outputLabel.Text = "WINNER";
                score += 3;
                scoreDisplay.Text = score + "";
            } 
            else
            {
                outputLabel.Text = "PLAY AGAIN";
                score--;
                scoreDisplay.Text = score + "";
            }
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         


            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score == 0)
            {
                outputLabel.Text = "LOSER";
                spinButton.Enabled = false;
                spinButton.BackColor = Color.Gray;
            }

            // display updated score

        }
    }
}
