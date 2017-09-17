using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int days,hours, minutes, seconds;


        private void StartButton_Click(object sender, EventArgs e)
        {
            if (SecondInput.Text == "")//check input textbox is empty or not
            {
                MessageBox.Show("NO INPUT");//if it is displaying message
            }
            else//if not we intialize hours,minutes,and seconds
            {
                int inputseconds = int.Parse(SecondInput.Text.Trim());//getting textbox input and converting String to integer 
                TimeSpan time = TimeSpan.FromSeconds(inputseconds);//here TimeSpan takes input seconds and converts to dd:hh:mm:ss
              days = time.Days;
                if (days != 0)//here it checks that input seconds is more than 24Hours
               {
                    hours = time.Hours;
                    hours = hours + (days * 24);//here we add up days to hours so that it can support more than 24Hours countdown
                }
                else
                {
                    hours = time.Hours;
                }
                
                minutes = time.Minutes;
                seconds = time.Seconds;
                ButtonActionState();
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if(hours==0 && minutes==0 && seconds == 0)//here we check if the time is up so that to display messagebox
            {
                timer1.Stop();
                MessageBox.Show(new Form() { TopMost = true }, "Timpes up!", "Click OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonActionState();
            }
            else
            {
                if(hours==0 && minutes==0 && seconds <= 59)//here we check for last minute and change the color of the labels to red
                {
                    labelhours.BackColor = Color.Red;
                    labelminutes.BackColor = Color.Red;
                    labelseconds.BackColor = Color.Red;
                }
                if (seconds < 1)//here it checks the countdown of seconds reachs to less than 1 and we assgin seconds=59 
                {
                    seconds = 59;
                    if (minutes < 1)//the same we followed here
                    {
                        minutes = 59;
                        if (hours != 0)//we check hour is not zero so that we decrement to one
                            hours = hours - 1;
                    }
                    else minutes = minutes - 1;//if minutes is not less than zero than we decrement to one
                }
                else seconds = seconds - 1;//the same is here
                if (hours > 9)//here we put the strings to the label and check the digits more than 9 so it remains same
                    labelhours.Text = hours.ToString();
                else labelhours.Text = "0" + hours.ToString();//if the digit is less than 9 than we concatenate zero front of it
                if (minutes > 9)
                    labelminutes.Text = minutes.ToString();
                else labelminutes.Text = "0" + minutes.ToString();
                if (seconds > 9)
                    labelseconds.Text = seconds.ToString();
                else labelseconds.Text = "0" + seconds.ToString();
            }
        }

       
        private void PauseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (PauseButton.Text == "Pause")//here the text of the button changes to pause to resume and vice versa
            {
                timer1.Stop();
                PauseButton.Text = "Resume";
            }
            else
            {
                timer1.Start();
                PauseButton.Text = "Pause";
            }

        }

        private void ButtonActionState()
        {
            if(StartButton.Text=="Start")//here we change the button text to start to reset and vice versa
            {
                
                timer1.Start();
                StartButton.Text = "Reset";
            }
            else//here we reset the countdown and also change the color of the labels to Control
            {
                timer1.Stop();
                SecondInput.Text = "00";
                StartButton.Text = "Start";
                PauseButton.Text = "Pause";
                labelhours.Text = "00";
                labelminutes.Text = "00";
                labelseconds.Text = "00";
                labelhours.BackColor = SystemColors.Control;
                labelminutes.BackColor = SystemColors.Control;
                labelseconds.BackColor = SystemColors.Control;
            }
        }



        private void labelTimer_Click(object sender, EventArgs e)
        {

        }
        private void labelTitle_Click(object sender, EventArgs e)
        {

        }


    }
}
