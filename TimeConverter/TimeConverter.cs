using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            try
            {
                TimeDiff = TimeSpan.Parse(TimeDifference.Text);
                TimeIn = TimeSpan.Parse(TimeInBox.Text);
                TimeResultCalculated = TimeIn.Add(TimeDiff);
                TimeResult.Text = TimeResultCalculated.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input.");
            }
        }

        private void TimeSubstractBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TimeDiff = TimeSpan.Parse(TimeDifference.Text);
                TimeIn = TimeSpan.Parse(TimeInBox.Text);
                TimeResultCalculated = TimeIn.Subtract(TimeDiff);
                if (TimeDiff > TimeIn)
                {
                    TimeResult.Text = "-" + TimeResultCalculated.ToString();
                }
                else
                {
                    TimeResult.Text = TimeResultCalculated.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input.");
            }
        }

        private void PasteTimeBtn_Click(object sender, EventArgs e)
        {
            TimeInBox.Text = Clipboard.GetText();
        }

        private void CopyTimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(TimeResult.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing to copy.");
            }
        }
    }
}
