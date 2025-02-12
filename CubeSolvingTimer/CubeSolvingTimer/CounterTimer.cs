﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSolvingTimer
{
    class CounterTimer: IDisposable
    {
        public Action TimeChanged;
        //public Action CountDownFinished;

        public bool IsRunnign => timer.Enabled;

        public int StepMs
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        private readonly Timer timer = new Timer();

        private DateTime _maxTime = new DateTime(1, 1, 1, 0, 30, 0);
        //private DateTime _minTime = new DateTime(1, 1, 1, 0, 0, 0);

        public DateTime TimeLeft { get; private set; }
        //private long TimeLeftMs => TimeLeft.Ticks / TimeSpan.TicksPerMillisecond;

        public string TimeLeftStr => TimeLeft.ToString("m:s");

        public string TimeLeftMsStr => TimeLeft.ToString("m:s.ff");

        private void TimerTick(object sender, EventArgs e)
        {
            //if (TimeLeftMs > timer.Interval)
            //{
                TimeLeft = TimeLeft.AddMilliseconds(+timer.Interval);
                TimeChanged?.Invoke();
            //}
            //else
            //{
            //    Stop();
            //    TimeLeft = _minTime;

            //    TimeChanged?.Invoke();
            //    CountDownFinished?.Invoke();
            //}
        }

        public CounterTimer(int min, int sec)
        {
            SetTime(min, sec);
            Init();
        }

        public CounterTimer(DateTime dt)
        {
            SetTime(dt);
            Init();
        }

        public CounterTimer()
        {
            Init();
        }

        private void Init()
        {
            TimeLeft = _maxTime;

            StepMs = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        public void SetTime(DateTime dt)
        {
            TimeLeft = _maxTime = dt;
            TimeChanged?.Invoke();
        }

        public void SetTime(int min, int sec = 0) => SetTime(new DateTime(1, 1, 1, 0, min, sec));

        public void Start() => timer.Start();

        public void Pause() => timer.Stop();

        public void Stop()
        {
            Pause();
            Reset();
        }

        public void Reset()
        {
            TimeLeft = _maxTime;
        }

        public void Restart()
        {
            Reset();
            Start();
        }

        public void Dispose() => timer.Dispose();
    }
}
