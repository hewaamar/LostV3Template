using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        // Set up soundplayer
        SoundPlayer musicPlayer;

        // Set up randomizer
        Random randGen = new Random();

        // Set up random variable
        int randomPage = 0;

        // make option3Label invisible
        



        public Form1()
        {
            InitializeComponent();

            mainCharacterBox.Parent = imageBox;
            bossBox.Parent = imageBox;

            // Display initial message and options
            DisplayPage();

            // make option 3 invisible
            option3Label.Visible = false;
            option3Button.Visible = false; 

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            {
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 99; }
            else if (page == 4) { page = 6; }
            else if (page == 5) { page = 1; }
            else if (page == 6) { page = 8; }
            else if (page == 7) { page = 99; }
            else if (page == 8) { page = 11; }
            else if (page == 9) { page = 12; }
            else if (page == 10) { page = 99; }
            else if (page == 11) { page = 14; }
            else if (page == 120)
            {
                randomPage = randGen.Next(1, 2);

                if (randomPage == 1)
                {page = 16;}
                else if (randomPage == 2)
                {page = 17;}
            }
            else if (page == 12) { page = 8; }
            else if (page == 13) { page = 99; }
            else if (page == 14) { page = 99; }
            else if (page == 15) { page = 99; }
            else if (page == 16) { page = 99; }
            else if (page == 18) { page = 99; }
            else if (page == 19) { page = 99; }

            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();
            
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 99;}
            else if (page == 4) { page = 7; }
            else if (page == 5) { page = 99;}
            else if (page == 6) { page = 9; }
            else if (page == 7) { page = 99;}
            else if (page == 8) { page = 99;}
            else if (page == 9) { page = 99; }
            else if (page == 10) { page = 99; }
            else if (page == 11) { page = 99; }
            else if (page == 12) { page = 99; }
            else if (page == 13) { page = 99; }
            else if (page == 14) { page = 99; }
            else if (page == 15) { page = 99; }
            else if (page == 16) { page = 99; }
            else if (page == 17) { page = 99; }

            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 6)
            {
                page = 10;
            }


            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();

        }

       

        public void DisplayPage()
        {
            option3Label.Visible = false; 
            option3Button.Visible = false;
            switch (page)
            {
                case 1:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.morning_song_case1);
                    musicPlayer.Play();

                    // set background
                    imageBox.Image = Properties.Resources.bedroom;

                    // set main character image
                    mainCharacterBox.BackgroundImage = Properties.Resources.doan2;

                    // display paragraph and options
                    outputLabel.Text = "It's your first day on the job.";
                    option1Label.Text = "Show up";
                    option2Label.Text = "Sleep in";

                    // make boss invisible
                    bossBox.Visible = false;
                    break;

                case 2:
                    // play sound 
                    musicPlayer = new SoundPlayer(Properties.Resources.lobby_music_case2);
                    musicPlayer.Play();

                    // set background
                    imageBox.Image = Properties.Resources.case_2;

                    // change location of main character 
                    this.mainCharacterBox.Location = new Point(232, 200);
                    // change sizing of main character
                    this.mainCharacterBox.Size = new System.Drawing.Size(100, 100);

                    // make boss appear in box
                    bossBox.BackgroundImage = Properties.Resources.niceBoss;
                    
                    // make boss visible
                    bossBox.Visible = true;

                    // change sizing of boss
                    this.bossBox.Size = new System.Drawing.Size(100, 100);

                    // flip boss
                    //bossBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX;

                    // display text and options
                    outputLabel.Text = "Your boss is happy that you showed up! But... you forgot your uniform!";
                    option1Label.Text = "Steal an extra uniform from the back";
                    option2Label.Text = "Be honest and explain that you forgot your uniform";
                    break;
                case 3:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.samsung_alarm_case3);
                    musicPlayer.Play();

                    // set background
                    imageBox.Image = Properties.Resources.case3;

                    // make main character invisible
                    mainCharacterBox.Visible = false;

                    // display loss message
                    outputLabel.Text = "WHY WOULD YOU SLEEP IN ON THE FIRST DAY?! FIRED!!! Play again?";
                    break;
                case 4:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.suspense_music_case4);
                    musicPlayer.Play();

                    // set background
                    imageBox.Image = Properties.Resources.case4;

                    // make main character visible
                    mainCharacterBox.Visible = false;

                    // make boss invisible 
                    bossBox.Visible = false;


                    // display text and options
                    outputLabel.Text = "You go to the back to steal a uniform and accidentally uncover loads of cash.";

                    option1Label.Text = "Take the uniform and get out of there ASAP!";
                    option2Label.Text = "Take some cash and quit before someone notices";

                    break;
                case 5:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.fail_case5);
                    musicPlayer.Play();


                    outputLabel.Text = "You asked your boss for a ride on the first day?! FIRED!!! Play again?";
                    break;
                case 6:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.running_case6);
                    musicPlayer.Play();
                    // make option 3 visible
                    option3Label.Visible = true;
                    option3Button.Visible = true; 

                    outputLabel.Text = "You run but a coworker notices you leaving. Do you";
                    option1Label.Text = "a) Let them train you";
                    option2Label.Text = "b) Completely ignore them";
                    option3Label.Text = "c) Run away";
                    break;

                case 7:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.alert_case7);
                    musicPlayer.Play();

                    outputLabel.Text = "You take some cash but an alarm goes off and you're caught. FIRED!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.blender_case8);
                    musicPlayer.Play();

                    outputLabel.Text = "They start by showing you how to blend a milkshake for the next customer but you HATE going all the way to the back to get milk. One of the customers in line is your boss.";
                    option1Label.Text = "Get the milk";
                    option2Label.Text = "Water it down with the tap beside you";
                    break;
                case 9:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.heartbeat_case9);
                    musicPlayer.Play();

                    outputLabel.Text = "They tell you that they know about the money too. To survive, you got to stick together. Do you trust them?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.glassbreak_case10);
                    musicPlayer.Play();

                    outputLabel.Text = "As you RUN away you bump into a blender and spill its contents. FIRED!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;   
                case 120:
                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.fail_case5);
                    musicPlayer.Play();

                    outputLabel.Text = "Your boss is 1 of 3 customers in the line... Does that mean he will get your watered-down smoothie?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "";
                    break;

                case 11:

                    // play sound
                    musicPlayer = new SoundPlayer(Properties.Resources.happyboss_case11);
                    musicPlayer.Play();

                    outputLabel.Text = "It turns out that the customer is your boss and they love the milkshake! They offer to give you the rest of the day off. You notice that they seem urgent to have you leave Do you accept or decline?";
                    option1Label.Text = "Accept and take the day off";
                    option2Label.Text = "Decline and say you want to stay";
                    break;

                case 12:
                    outputLabel.Text = "You trust them. The next morning you get a text from your co-worker saying to lie and call in sick.";
                    option1Label.Text = "Call in sick";
                    option2Label.Text = "Go to work because they're probably trying to trick you";
                    break;
                case 13:
                    outputLabel.Text = "You walk into work next morning and all you see is a bag tied around your co-workers head. Before you can do anything, you feel a bag tie over your head too...";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "Your boss asks why you're sick.";
                    option1Label.Text = "Tell them that you twisted your ankle on the way home yesterday.";
                    option2Label.Text = "Tell them you have COVID";
                    break;
                case 15:
                    outputLabel.Text = "Your boss asks why you're sick.";
                    option1Label.Text = "Tell them that you twisted your ankle on the way home yesterday.";
                    option2Label.Text = "Tell them you have COVID";
                    break;
                case 16:
                    outputLabel.Text = "It turns out that the customer is your new boss. FIRED!!!";
                    break;
                case 17:
                    outputLabel.Text = "It turns out that the customer who got your milkshake made a complaint to your boss. FIRED!!!";
                    break;
                case 19:
                    outputLabel.Text = "The next morning when you're at work, a group of people in black suits detain you and your boss.";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }
