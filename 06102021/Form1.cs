using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06102021
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private Results results = new Results();
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnCatchMe.Visible = true;
            this.startTime = DateTime.Now;
        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            DateTime endTime = DateTime.Now;
            btnCatchMe.Visible = false;
            TimeSpan deltaTime = endTime - startTime;
            results.Add((int) deltaTime.TotalMilliseconds);
            this.Text = $"Last: {results.LastTime}, Best: {results.BestTime}, Average: {results.AverageTime}";
            int newInterval = random.Next(200, 5000);
            tmrTimer.Interval = newInterval;
            tmrTimer.Enabled = true;

        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;
            btnCatchMe.Visible = true;
            this.startTime = DateTime.Now;
        }
    }
}
