﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lifemanager
{
    public partial class Form4 : Form
    {
        int TimerTime = 3000;
        public Form4()
        {
            InitializeComponent();

            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double temp = int.Parse(label1.Text);
            temp--;
            label1.Text = temp.ToString();

            StreamWriter playerOneLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneLifeTotal.txt");

            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label1.Text);
            temp++;
            label1.Text = temp.ToString();

            StreamWriter playerOneLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneLifeTotal.txt");

            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label1.Text);
            temp -= 5;
            label1.Text = temp.ToString();


            StreamWriter playerOneLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneLifeTotal.txt");

            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label1.Text);
            temp += 5;
            label1.Text = temp.ToString();

            StreamWriter playerOneLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneLifeTotal.txt");

            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label1.Text);
            temp -= 10;
            label1.Text = temp.ToString();


            StreamWriter playerOneLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneLifeTotal.txt");

            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label1.Text);
            temp += 10;
            label1.Text = temp.ToString();

            StreamWriter playerOneLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneLifeTotal.txt");

            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(LeftInfectCounter.Text);
            temp++;
            LeftInfectCounter.Text = temp.ToString();

            StreamWriter playerOneInfect = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneInfect.txt");

            playerOneInfect.Write(LeftInfectCounter.Text);
            playerOneInfect.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(LeftInfectCounter.Text);
            temp--;
            LeftInfectCounter.Text = temp.ToString();

            StreamWriter playerOneInfect = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneInfect.txt");

            playerOneInfect.Write(LeftInfectCounter.Text);
            playerOneInfect.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(RightInfectCounter.Text);
            temp++;
            RightInfectCounter.Text = temp.ToString();

            StreamWriter playerTwoInfect = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoInfect.txt");

            playerTwoInfect.Write(RightInfectCounter.Text);
            playerTwoInfect.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(RightInfectCounter.Text);
            temp--;
            RightInfectCounter.Text = temp.ToString();

            StreamWriter playerTwoInfect = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoInfect.txt");

            playerTwoInfect.Write(RightInfectCounter.Text);
            playerTwoInfect.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label2.Text);
            temp--;
            label2.Text = temp.ToString();

            StreamWriter playerTwoLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoLifeTotal.txt");

            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label2.Text);
            temp++;
            label2.Text = temp.ToString();

            StreamWriter playerTwoLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoLifeTotal.txt");

            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label2.Text);
            temp -= 5;
            label2.Text = temp.ToString();

            StreamWriter playerTwoLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoLifeTotal.txt");

            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label2.Text);
            temp += 5;
            label2.Text = temp.ToString();

            StreamWriter playerTwoLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoLifeTotal.txt");

            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label2.Text);
            temp -= 10;
            label2.Text = temp.ToString();

            StreamWriter playerTwoLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoLifeTotal.txt");

            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(label2.Text);
            temp += 10;
            label2.Text = temp.ToString();

            StreamWriter playerTwoLifeTotal = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoLifeTotal.txt");

            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerText.Text = TimeSpan.FromSeconds(double.Parse(TimerTime.ToString())).ToString();
            TimerTime--;
            StreamWriter TimerDoc = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\Timer.txt");
            TimerDoc.Write(TimerText.Text);
            TimerDoc.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(LeftGamesWon.Text);
            temp++;
            LeftGamesWon.Text = temp.ToString();

            StreamWriter playerOneWins = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneWins.txt");

            playerOneWins.Write(LeftGamesWon.Text);
            playerOneWins.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(LeftGamesWon.Text);
            temp--;
            LeftGamesWon.Text = temp.ToString();

            StreamWriter playerOneWins = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneWins.txt");

            playerOneWins.Write(LeftGamesWon.Text);
            playerOneWins.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(RightGamesWon.Text);
            temp--;
            RightGamesWon.Text = temp.ToString();

            StreamWriter playerTwoWins = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoWins.txt");

            playerTwoWins.Write(RightGamesWon.Text);
            playerTwoWins.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(RightGamesWon.Text);
            temp++;
            RightGamesWon.Text = temp.ToString();

            StreamWriter playerTwoWins = new StreamWriter("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoWins.txt");

            playerTwoWins.Write(RightGamesWon.Text);
            playerTwoWins.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LeftPlayersName.ToString() != File.ReadAllText("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneName.txt").ToString())
            {
                LeftPlayersName.Text = File.ReadAllText("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneName.txt").ToString();
                LeftPlayersDeck.Text = File.ReadAllText("C:\\Program files\\Life_Manager_Overlay_Documents\\playerOneDeck.txt").ToString();
                RightPlayersName.Text = File.ReadAllText("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoName.txt").ToString();
                RightPlayersDeck.Text = File.ReadAllText("C:\\Program files\\Life_Manager_Overlay_Documents\\playerTwoDeck.txt").ToString();

                timer2.Stop();
            }
        }
    }
}
