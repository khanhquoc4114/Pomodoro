using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Homemade_Pomodoros
{
    public partial class Pomodoros : Form
    {
        int timer = 0;
        bool isStarted = false;
        int[] all = new int[3];
        int currentTimer = 0;
        int countTimer = 0;
        int countRest = 0;
        int countLongRest = 0;
        int currentIndex = 0;

        public Pomodoros()
        {
            InitializeComponent();
            timerMain.Interval = 1000; // Thời gian chạy tính bằng ms 1000ms = 1s
            timerMain.Tick += TimerMain_Tick;
            SetTimer(cbTimer);
            btnStop.Enabled = false;
        }

        // Gán thời gian cho timer
        void SetValue()
        {
            try
            {
                all[0] = int.Parse(cbTimer.Text)*60; // main
                all[1] = int.Parse(cbRest.Text)*60;  // short 
                all[2] = int.Parse(cbLongRest.Text) * 60; // long
            } catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        // Thời gian chạy
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer -= 1;

                int minutes = timer / 60;
                int seconds = timer % 60;

                lbTime.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
            }
            else
            {
                if (currentIndex == 0)
                {
                    countTimer++;
                    lbTimer.Text = countTimer.ToString();
                    currentIndex = 1;
                }
                else if (currentIndex == 1)
                {
                    countRest++;
                    lbRest.Text = countRest.ToString();

                    if (countRest % 3 == 0)
                    {
                        currentIndex = 2;
                    }
                    else
                    {
                        currentIndex = 0;
                    }
                }
                else if (currentIndex == 2)
                {
                    countLongRest++;
                    lbLongRest.Text = countLongRest.ToString();
                    currentIndex = 0;
                }

                timer = all[currentIndex];

                int minutes = timer / 60;
                int seconds = timer % 60;

                lbTime.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
            }
        }



        void SetTimer(ComboBox cb = null)
        {
            if (int.TryParse(cb.Text.Trim(), out int minutes))
            {
                currentTimer= minutes * 60;
                lbTime.Text = (currentTimer / 60).ToString("00") + ":" + (currentTimer % 60).ToString("00");
            }
            else
            {
                MessageBox.Show("Please enter a valid number of minutes.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetValue();
            string text = btnStart.Text.ToLower();
            if (text == "start")
            {
                if (int.TryParse(cbTimer.Text.Trim(), out int minutes))
                {
                    if (!isStarted)
                    {
                        timer = minutes * 60;
                        currentTimer = timer;
                    }

                    timerMain.Start();
                    btnStart.Text = "Pause";
                    isStarted = true;
                    btnStop.Enabled = true;
                }
            }
            else if (text == "pause")
            {
                timerMain.Stop();
                btnStart.Text = "Start";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!isStarted) return;
            timerMain.Stop();
            lbTime.Text = (currentTimer / 60).ToString("00") + ":" + (currentTimer % 60).ToString("00");
            btnStart.Text = "Start";
            cbTimer.Enabled = true;
            btnStop.Enabled = false;
        }

        private void cbTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTimer(cbTimer);
        }
    }
}
