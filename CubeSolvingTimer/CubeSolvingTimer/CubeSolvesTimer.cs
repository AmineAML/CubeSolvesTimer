using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSolvingTimer
{
    public partial class CubeSolvesTimer : Form
    {
        public CubeSolvesTimer()
        {
            InitializeComponent();
        }

        int NoOfSolves = 0;
        CounterTimer timer = new CounterTimer();
        private void btnStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Start timer
            timer.SetTime(00, 0);

            timer.Start();

            NoOfSolves++;

            //NOTE: the timer class is for a count down timer that's changed for a counter
            timer.TimeChanged += () => labelTimer.Text = timer.TimeLeftMsStr;
            timer.StepMs = 33;

            //"DO YOUR BEST" signaling message
            labelDoYourBest.Text = "DO YOUR BEST!";

            //Set focus to the stop button
            btnStop.Focus();
        }

        int i = 0;
        string records;
        //Generate white spaces to skip of space after first line
        string spaces = new string(' ', 54);
        string[] Solves = new string[12];
        public bool btnStopKeyPressed = false;
        private void btnStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnStopKeyPressed = true;
            //Stop timer
            timer.Stop();

            //Return the text to the default value set from Tag from Properties of this label
            labelNoSolves.Text = labelNoSolves.Tag.ToString();
            labelNoSolves.Text = labelNoSolves.Text + NoOfSolves;

            //"GOOD! BUT CAN YOU DO BETTER" stop button's message
            labelDoYourBest.Text = "Good! but can you do better?";

            //Set focus back to the start button
            btnStart.Focus();

            //Reset the array index as the array limit is 12
            if (i == 12)
            {
                i = 0;
            }

            Solves[i] = labelTimer.Text;

            records = Solves[0] + " " + Solves[1] + " " + Solves[2] + spaces + Solves[3] + " " + Solves[4] + " " + Solves[5] + spaces + Solves[6] + " " + Solves[7] + " " + Solves[8] + spaces + Solves[9] + " " + Solves[10] + " " + Solves[11];
            labelSessionSolves.Text = labelSessionSolves.Tag.ToString() + records;

            i++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //var sw = System.Diagnostics.Stopwatch.StartNew();
            //100 lines of code... 
            //labelTimer.Text = sw.Elapsed.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
