using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3Stopwatch
{
    public partial class Form1 : Form
    {
        Model model = new Model();

        public Form1()
        {
            InitializeComponent();

           

    }
        
        private void Start_Button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            TimerTextBox.Clear();
            model.sec = 0;
            model.min = 0;
            model.hrs = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTextBox.Text = model.TimerTime();
        }

        private void TimerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
