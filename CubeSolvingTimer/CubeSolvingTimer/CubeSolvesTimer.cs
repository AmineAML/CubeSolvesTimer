using System;
using System.Drawing;
using System.Globalization;
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
            BtnStop.BackColor = Color.Crimson;
            BtnStart.BackColor = Color.LightSteelBlue;

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

        int i = 0, j = 0;
        string records;

        //Generate white spaces to skip of space after first line
        //readonly string spaces = new string(' ', 54);

        readonly string[] Solves = new string[12];
        readonly string[] SolvesOfFive = new string[5];
        private void BtnStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnStart.BackColor = Color.CornflowerBlue;
            BtnStop.BackColor = Color.PaleVioletRed;

            //Stop timer
            timer.Stop();

            //Return the text to the default value set from Tag from Properties of this label
            labelNoSolves.Text = labelNoSolves.Tag.ToString();
            labelNoSolves.Text += NoOfSolves;

            //"GOOD! BUT CAN YOU DO BETTER" stop button's message
            labelDoYourBest.Text = labelDoYourBest.Tag.ToString();

            //Set focus back to the start button
            BtnStart.Focus();

            //Reset the Solves array index as the array limit is 12
            if (i == 12)
            {
                i = 0;
            }
            //Reset the SolvesOfFive array index as the array limit is 5
            if (j == 5)
            {
                j = 0;
            }

            Solves[i] = labelTimer.Text;
            SolvesOfFive[j] = Solves[i];

            records = Solves[0].TrimStart('0').TrimStart(':') + " ";
            if (Solves[1] != null) { records += Solves[1].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[2] != null) { records += Solves[2].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[3] != null) { records += Solves[3].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[4] != null) { records += Solves[4].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[5] != null) { records += Solves[5].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[6] != null) { records += Solves[6].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[7] != null) { records += Solves[7].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[8] != null) { records += Solves[8].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[9] != null) { records += Solves[9].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[10] != null) { records += Solves[10].TrimStart('0').TrimStart(':') + " "; }
            if (Solves[11] != null) { records += Solves[11].TrimStart('0').TrimStart(':') + " "; }
            labelSessionSolves.Text = labelSessionSolves.Tag.ToString() + records;

            //Average of last 5
            //The following executes only if the 5 elements of SolvesOfFive aren't null
            if (SolvesOfFive[0] != null && SolvesOfFive[1] != null && SolvesOfFive[2] != null && SolvesOfFive[2] != null && SolvesOfFive[3] != null && SolvesOfFive[4] != null)
            {
                DateTime d1 = DateTime.ParseExact(SolvesOfFive[0].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime d2 = DateTime.ParseExact(SolvesOfFive[1].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds1 = d1.Add(d2.TimeOfDay);
                DateTime d3 = DateTime.ParseExact(SolvesOfFive[2].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds2 = ds1.Add(d3.TimeOfDay);
                DateTime d4 = DateTime.ParseExact(SolvesOfFive[3].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds3 = ds2.Add(d4.TimeOfDay);
                DateTime d5 = DateTime.ParseExact(SolvesOfFive[4].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds4 = ds3.Add(d5.TimeOfDay);

                //Convert time to milliseconds
                var TotalMS = ds4.TimeOfDay.TotalMilliseconds;

                //Average of the last 5 elements from the array Solves
                var AverageOfFiveMS = TotalMS / 5;

                //Convert the average of milliseconds to this format mm:ss:ff
                TimeSpan TimeFromDateTimeToMS = TimeSpan.FromMilliseconds(AverageOfFiveMS);
                string TimeFromMStoDateTime = TimeFromDateTimeToMS.ToString(@"m\:s\.ff");

                labelAverageOfFive.Text = labelAverageOfFive.Tag.ToString() + TimeFromMStoDateTime.TrimStart('0').TrimStart(':');
            }

            //Average of the last 12 solves
            //The following executes only if the 12 elements of Solves aren't null
            if(Solves[0] != null && Solves[1] != null && Solves[2] != null && Solves[2] != null && Solves[3] != null && Solves[4] != null && Solves[5] != null && Solves[6] != null && Solves[7] != null && Solves[8] != null && Solves[9] != null && Solves[10] != null && Solves[11] != null)
            {
                DateTime d1 = DateTime.ParseExact(Solves[0].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime d2 = DateTime.ParseExact(Solves[1].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds1 = d1.Add(d2.TimeOfDay);
                DateTime d3 = DateTime.ParseExact(Solves[2].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds2 = ds1.Add(d3.TimeOfDay);
                DateTime d4 = DateTime.ParseExact(Solves[3].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds3 = ds2.Add(d4.TimeOfDay);
                DateTime d5 = DateTime.ParseExact(Solves[4].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds4 = ds3.Add(d5.TimeOfDay);
                DateTime d6 = DateTime.ParseExact(Solves[5].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds5 = ds4.Add(d6.TimeOfDay);
                DateTime d7 = DateTime.ParseExact(Solves[6].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds6 = ds5.Add(d7.TimeOfDay);
                DateTime d8 = DateTime.ParseExact(Solves[7].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds7 = ds6.Add(d8.TimeOfDay);
                DateTime d9 = DateTime.ParseExact(Solves[8].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds8 = ds7.Add(d9.TimeOfDay);
                DateTime d10 = DateTime.ParseExact(Solves[9].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds9 = ds8.Add(d10.TimeOfDay);
                DateTime d11 = DateTime.ParseExact(Solves[10].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds10 = ds9.Add(d11.TimeOfDay);
                DateTime d12 = DateTime.ParseExact(Solves[11].ToString(), "m:s.ff", CultureInfo.InvariantCulture);
                DateTime ds11 = ds10.Add(d12.TimeOfDay);

                //Convert time to milliseconds
                var TotalMS2 = ds11.TimeOfDay.TotalMilliseconds;

                //Average of the last 5 elements from the array Solves
                var AverageOfFiveMS2 = TotalMS2 / 12;

                //Convert the average of milliseconds to this format mm:ss:ff
                TimeSpan TimeFromDateTimeToMS2 = TimeSpan.FromMilliseconds(AverageOfFiveMS2);
                string TimeFromMStoDateTime2 = TimeFromDateTimeToMS2.ToString(@"m\:s\.ff");

                labelAverageOfTwelve.Text = labelAverageOfTwelve.Tag.ToString() + TimeFromMStoDateTime2.TrimStart('0').TrimStart(':');
            }
            i++;
            j++;
        }
    }
}
