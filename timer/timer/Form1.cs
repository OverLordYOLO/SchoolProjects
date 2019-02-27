using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		bool isStart = false;
		DateTime start;
		private void startButton_Click(object sender, EventArgs e)
		{
			if (isStart)
			{
				this.startButton.Text = "Start";
				timer1.Enabled = false;
				isStart = false;
			}
			else
			{
				this.startButton.Text = "Stop";
				start = DateTime.Now;
				isStart = true;
				timer1.Enabled = true;
			}
		}

		private void lapButton_Click(object sender, EventArgs e)
		{
			this.lapListBox.Items.Add(this.getTimeElapsedText());
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			lapListBox.Items.Clear();
			start = DateTime.Now;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lapListBox.Items.Clear();
		}
		private string getTimeElapsedText()
		{
			DateTime timeElapsedTicks;
			timeElapsedTicks = DateTime.Now.AddTicks(-start.Ticks);
			return $"{timeElapsedTicks.Hour.ToString("00")} : {timeElapsedTicks.Minute.ToString("00")} : {timeElapsedTicks.Second.ToString("00")} : {timeElapsedTicks.Millisecond.ToString("000")}";


		}
		private void showTime()
		{
			this.label1.Text = getTimeElapsedText();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.showTime();
		}
	}
}
