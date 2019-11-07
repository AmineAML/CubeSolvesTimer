using System;
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
        readonly CounterTimer timer = new CounterTimer();
        private void BtnStart_KeyPress(object sender, KeyPressEventArgs e)
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
            BtnStop.Focus();
        }

        int i = 0;
        string records;

        //Generate white spaces to skip of space after first line
        readonly string spaces = new string(' ', 54);
        readonly string[] Solves = new string[12];
        private void BtnStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stop timer
            timer.Stop();

            //Return the text to the default value set from Tag from Properties of this label
            labelNoSolves.Text = labelNoSolves.Tag.ToString();
            labelNoSolves.Text += NoOfSolves;

            //"GOOD! BUT CAN YOU DO BETTER" stop button's message
            labelDoYourBest.Text = labelDoYourBest.Tag.ToString();

            //Set focus back to the start button
            BtnStart.Focus();

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
    }
}
