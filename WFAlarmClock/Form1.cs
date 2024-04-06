using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace WFAlarmClock
{
    public partial class Form1 : Form
    {
        private Queue<DateTime> alarmQueue = new Queue<DateTime>(); // Alarm queue
        private SoundPlayer alarmSound = new SoundPlayer(); // Alarm sound player

        public Form1()
        {
            InitializeComponent();

            // Window will be fixed and not maximisable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            timer.Start();
            radioButton2.Checked = true; // 24 hr format selected by default
            alarmSound.SoundLocation = @"E:\Coding Practice\WFAlarmClock\assets\alarmTune.wav"; // relative path is recommended
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                clkLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
            else if (radioButton2.Checked)
            {
                clkLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            clkLabel.Refresh();

            // Check for alarms in the queue
            CheckAlarms();
        }

        private void CheckAlarms()
        {
            // Check if there are any alarms in the queue
            while (alarmQueue.Count > 0)
            {
                DateTime nextAlarm = alarmQueue.Peek();

                // If the next alarm time has been reached
                if (DateTime.Now >= nextAlarm)
                {
                    // Remove the triggered alarm from the queue
                    alarmQueue.Dequeue();

                    // Update the ListBox to reflect the changes
                    UpdateAlarmList();

                    // Trigger the alarm
                    alarmSound.Play();
                    MessageBox.Show("Alarm!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                else
                {
                    // If the next alarm time has not been reached yet, break the loop
                    break;
                }
            }
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            // Parse alarm time from TextBoxes and ComboBox
            int hours, minutes;
            if (int.TryParse(txtHour.Text, out hours)
                && int.Parse(txtHour.Text) <= 12
                && int.TryParse(txtMinute.Text, out minutes) 
                && int.Parse(txtMinute.Text) <= 59
                && (comboBoxAMPM.SelectedItem != null))
            {
                string amPm = comboBoxAMPM.SelectedItem.ToString();
                if (amPm.Equals("PM", StringComparison.OrdinalIgnoreCase) && hours < 12)
                {
                    hours += 12;
                }
                else if (amPm.Equals("AM", StringComparison.OrdinalIgnoreCase) && hours == 12)
                {
                    hours = 0;
                }

                // Create a DateTime object for the alarm time
                DateTime alarmTime = DateTime.Today.AddHours(hours).AddMinutes(minutes);

                // Add the alarm to the queue
                alarmQueue.Enqueue(alarmTime);

                // Update the ListBox to reflect the changes
                UpdateAlarmList();
            }
            else
            {
                MessageBox.Show("Invalid time format. Please enter valid hour and minute values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAlarmList()
        {
            // Clear the ListBox
            listBoxAlarms.Items.Clear();

            // Add alarms from the queue to the ListBox
            foreach (DateTime alarm in alarmQueue)
            {
                listBoxAlarms.Items.Add(alarm.ToString("hh:mm:ss tt"));
            }
        }

        private void buttonClrQueue_Click(object sender, EventArgs e)
        {
            alarmQueue.Clear();
            UpdateAlarmList();
        }
    }
}
