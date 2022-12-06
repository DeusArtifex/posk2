using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace posk2
{
    public partial class Vision : Form
    {
        Stopwatch Stopwatch = new Stopwatch();
        List<double> results = new List<double>();
        Random rand = new Random();
        int counter;
        int miss;
        public Vision()
        {
            InitializeComponent();
        }

        private void show_Results()
        {
            resultTable.Visible = !resultTable.Visible;
            resultChart.Visible = !resultChart.Visible;
            resultAverage.Visible = !resultAverage.Visible;
        }

        private void clear_Results()
        {
            results.Clear();
            resultTable.Text = "";
            resultChart.Series[0].Points.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Stopwatch.IsRunning)
            {
                Stopwatch.Stop();
                timer.Stop();
                if (!tutorial.Checked)
                {
                    double reaction = (double)Stopwatch.ElapsedMilliseconds;
                    results.Add(reaction);
                    resultChart.Series[0].Points.AddXY(counter, reaction);
                    resultTable.Text += ("Wynik " + counter.ToString() + ": " + reaction.ToString() + "ms\n");
                    if (counter == 5)
                    {
                        resultAverage.Text = ("Śr.:" + results.Average().ToString() + "ms");
                        show_Results();
                    }
                }
                if (counter == 5)
                {
                    indicator.BackColor = Color.White;
                    btnStart.Enabled = !btnStart.Enabled;
                    btnCheck.Enabled = !btnCheck.Enabled;
                }
                else
                {
                    indicator.BackColor = Color.Turquoise;
                    timer.Interval = (rand.Next(4000) + 1000);
                    timer.Start();
                }
            }
            else
            {
                miss++;
                MessageBox.Show("Zbyt szybko! Skucha nr.: " + miss.ToString());
                if(miss == 3)
                {
                    indicator.BackColor = Color.White;
                    btnStart.Enabled = !btnStart.Enabled;
                    btnCheck.Enabled = !btnCheck.Enabled;
                    timer.Interval = 5000;
                    timer.Stop();
                    clear_Results();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnCheck.Enabled = !btnCheck.Enabled;
            timer.Start();
            indicator.BackColor = Color.Turquoise;
            counter = 0;
            miss = 0;
            if (resultChart.Visible)
            {
                show_Results();
                clear_Results();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!Stopwatch.IsRunning || counter == 0)
            {
                counter++;
                indicator.BackColor = Color.Red;
                Stopwatch.Restart();
            }
        }
    }
}
