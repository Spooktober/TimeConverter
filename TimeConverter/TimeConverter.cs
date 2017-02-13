using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeConverter
{
    public partial class TimeConverter : Form
    {
        private static TimeSpan TimeDiff;
        private static TimeSpan TimeIn;
        private static TimeSpan TimeResultCalculated;

        public TimeConverter()
        {
            InitializeComponent();
        }

        private void TimeAddBtn_Click(object sender, EventArgs e)
        {
            string mode = "mm':'ss";
            try
            {
                if (DotMode.Checked)
                {
                    mode = "mm'.'ss";
                    TimeDiff = TimeSpan.ParseExact(TimeDifference.Text, mode, null);
                    TimeIn = TimeSpan.ParseExact(TimeInBox.Text, mode, null);
                    TimeResultCalculated = TimeIn.Add(TimeDiff);
                    TimeResult.Text = TimeResultCalculated.ToString(@"mm\.ss");
                }
                else
                {
                    TimeDiff = TimeSpan.ParseExact(TimeDifference.Text, mode, null);
                    TimeIn = TimeSpan.ParseExact(TimeInBox.Text, mode, null);
                    TimeResultCalculated = TimeIn.Add(TimeDiff);
                    TimeResult.Text = TimeResultCalculated.ToString(@"mm\:ss");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input. Be sure to have alternative input mode on if you are using dot as separator.");
            }
        }

        private void TimeSubstractBtn_Click(object sender, EventArgs e)
        {
            string mode = "mm':'ss";
            try
            {
                if (DotMode.Checked)
                {
                    mode = "mm'.'ss";
                    TimeDiff = TimeSpan.ParseExact(TimeDifference.Text, mode, null);
                    TimeIn = TimeSpan.ParseExact(TimeInBox.Text, mode, null);
                    TimeResultCalculated = TimeIn.Subtract(TimeDiff);
                    if (TimeDiff > TimeIn)
                    {
                        TimeResult.Text = "-" + TimeResultCalculated.ToString(@"mm\.ss");
                    }
                    else
                    {
                        TimeResult.Text = TimeResultCalculated.ToString(@"mm\.ss");
                    }
                }
                else
                {
                    TimeDiff = TimeSpan.ParseExact(TimeDifference.Text, mode, null);
                    TimeIn = TimeSpan.ParseExact(TimeInBox.Text, mode, null);
                    TimeResultCalculated = TimeIn.Subtract(TimeDiff);
                    if (TimeDiff > TimeIn)
                    {
                        TimeResult.Text = "-" + TimeResultCalculated.ToString(@"mm\:ss");
                    }
                    else
                    {
                        TimeResult.Text = TimeResultCalculated.ToString(@"mm\:ss");
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input. Be sure to have alternative input mode on if you are using dot as separator.");
            }
        }

        private void CopyTimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(TimeResult.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to copy.");
            }
        }
    
        private void PasteTimeBtn_Click(object sender, EventArgs e)
            {
                TimeInBox.Text = Clipboard.GetText();
            }

        private void ClearInput_Click(object sender, EventArgs e)
        {
            TimeDifference.Text = "";
            TimeInBox.Text = "";
            TimeResult.Text = "";
        }
    }
}
