using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Choose_your_own_adventure
{
    public partial class Form1 : Form
    {
        //global variables
        int page = 1;
        int number;
        SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.A_Tone_His_Self_1266414414__1_);

        Random randGen = new Random();
        

        public Form1()
        {
            InitializeComponent();
            //display starting messages
            outputLabel.Text = " Welcome to clash royale.\nYour oppenet places a ballon on the bridge, do you....";
            optionLabel1.Text = "play ice golem";
            optionLabel2.Text = "play hunter";
            optionLabel3.Text = "";
            //startup settings
            button3.Enabled = false;
            button3.Visible = false;
            //button2.BackgroundImage.Height.Equals(93);
            //button2.BackgroundImage.Width.Equals(76);
            //sound 
            SoundPlayer player = new SoundPlayer(Properties.Resources.A_Tone_His_Self_1266414414__1_);
            player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 101; }
            else if (page == 4) { page = 101; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 101; }
            else if (page == 7) { page = 8; }
            else if (page == 8) { page = 101; }
            else if (page == 9) { page = 10; }
            else if (page == 10) { page = 101; }
            else if (page == 11) { page = 13; }
            else if (page == 12) { page = 101; }
            else if (page == 13) { page = 15; } 
            else if (page == 14) { page = 101; }
            else if (page == 15) { page = 101; }
            else if (page == 16) { page = 18; }
            else if (page == 17) { page = 101; }
            else if (page == 18) { page = 20; }
            else if (page == 19) { page = 101; }
            else if (page == 20) { page = 101; }
            DisplayPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 1; }
            else if (page == 5) { page = 7; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 9; }
            else if (page == 8) { page = 1; }
            else if (page == 9) { page = 11; }
            else if (page == 10) { page = 1; }
            else if (page == 11) { page = 12; }
            else if (page == 12) { page = 1; }
            else if (page == 13)
            {
                number = randGen.Next(1, 11);
                if (number > 4)
                {
                    page = 16;
                }
                else
                {
                    page = 17;
                }
            }

            else if (page == 14) { page = 1; }
            else if (page == 15) { page = 1; }
            else if (page == 16) { page = 17; }
            else if (page == 17) { page = 1; }
            else if (page == 18) { page = 19; }
            else if (page == 19) { page = 1; }
            else if (page == 20) { page = 1; }
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = " Welcome to clash royale.\nYour oppenet places a ballon on the bridge, do you....";
                    optionLabel1.Text = "Play ice golem";
                    optionLabel2.Text = "Play hunter";
                    optionLabel3.Text = "";
                    pictureBox1.Image = Properties.Resources.clash_royale_balloon;
                    button3.Enabled = false;
                    button3.Visible = false;
                    break;
                case 2:
                    outputLabel.Text = "The hunter kills the ballon\nYour hunter moves forwards do you ";
                    optionLabel1.Text = "Support it with wall breakers";
                    optionLabel2.Text = "Support it with miner";

                    pictureBox1.Image = Properties.Resources.images;
                    SoundPlayer player = new SoundPlayer();
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 3:
                    outputLabel.Text = "Ice golem does not traget air untis.\nThe balloon takeys your tower you lose.\nPlay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";

                    pictureBox1.Image = Properties.Resources.cryingcr;
                    
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    
                    break;
                case 4:
                    outputLabel.Text = "Your miner gets easily countered.\nYou lose play again";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;


                    pictureBox1.Image = Properties.Resources.cryingcr;
                    break;
               
                case 5:
                    outputLabel.Text = "They both connect with the tower for big damage\nThe opponent places a mini pekka oppsite lane do you";
                    optionLabel1.Text = "Kite it with ice goelm";
                    optionLabel2.Text = "Fireball it";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.mini_pekka;
                    break;
                case 6:
                    outputLabel.Text = "You miss the fireball and the mini pekka takes your tower.\nPlay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 7:
                    outputLabel.Text = "It gets taken out by your towers\nYou have an elixer advantage do you";
                    optionLabel1.Text = "Send a miner to thier tower";
                    optionLabel2.Text = "Wait for them to make a move";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.miner;
                    break;
                case 8:
                    outputLabel.Text = "Never leak elixer if you have the advantage.\nThey take your tower you lose\nPLay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 9:
                    outputLabel.Text = "Your miner gets lots of chip damage\nThey counter it late with a magic archer\nThey add baloon to the push do you,";
                    optionLabel1.Text = "Fireball and add spear gobs";
                    optionLabel2.Text = "Play hunter";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.magic_archer;
                    break;

                case 10:
                    outputLabel.Text = " Your hunter kills the ballon but their magic archer kills your hunter.\n They add a mini pekka and take your tower.\nPLay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 11:
                    //enable button and make it visble 
                    button3.Enabled = true;
                    button3.Visible = true;
                    //noraml code
                    outputLabel.Text = " It kills the push\n They push unexpecdly with mini pekka in the opposite lane do you";
                    optionLabel1.Text = "Leave it and push oppsoite lane";
                    optionLabel2.Text = "Quickly use your sceletons to kill it and wall breaker to support your spear goblins";
                    optionLabel3.Text = "Counter it with hunter";
                    pictureBox1.Image = Properties.Resources.wallbreakers;
                    break;
                case 12:
                    outputLabel.Text = "You lose your tower and they kill your push. \nPlay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 13:
                    outputLabel.Text = "It kills pekka and you push takes the tower.\n You now have an elxir advantage do you,";
                    optionLabel1.Text = "Send wall breakers to attack"; 
                    optionLabel2.Text = "Go all in";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.wallbreakers;
                    // percent
                    //int number;
                    //number = randGen.Next(1, 11);
                    //if (number > 0)
                    //{
                    //    page = 16;
                    //}
                    //else
                    //{
                    //    page = 17;
                    //}


                    break;
                case 14:
                    outputLabel.Text = "It kill your hunter.\n Now ahead in elxir they push and you cant defend.\n PLay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 15:
                    outputLabel.Text = "Your opponent counters your pushes and takes your tower because you over commited.\n Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 16:
                    outputLabel.Text = "They miss thier log and it works. \n They play baloon but you dont have hunter in hand do you,";
                    optionLabel1.Text = "Counter with spear goblins";
                    optionLabel2.Text = "Hit it with a well timed fireball";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.clash_royale_balloon;
                    break;
                case 17:
                    outputLabel.Text = "They take it out easily with a zap.\n The ballon taskes your tower.Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 18:
                    outputLabel.Text = "You succesfully defend the baloon.\n They drop a gaint and a magic archer on the bridge";
                    optionLabel1.Text = "Leave the push and take the other tower";
                    optionLabel2.Text = "Use a hunter to defeend and counter push";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.gaint_baloon;
                    break;
                case 19:
                    outputLabel.Text = "They take out your crown tower and you lose.\n Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    pictureBox1.Image = Properties.Resources.cryingcr;
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;

                    break;
                case 20:
                    outputLabel.Text = "You take thier crown tower.\n Winner!\n Would you like to play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    optionLabel3.Text = "";
                    button3.Enabled = false;
                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.winner_cr;

                    break;
                case 101:
                    outputLabel.Text = "Thanks For Playing";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    optionLabel3.Text = "";
                    Refresh();
                        Thread.Sleep(1500);
                        Application.Exit();
                    break;
                default:
                    break;
                 
            }


        }

        private void optionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Enabled = true;
            page = 14;
            DisplayPage();
               
                
        }

        private void optionLabel2_Click(object sender, EventArgs e)
        {

        }

        private void optionLabel3_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
