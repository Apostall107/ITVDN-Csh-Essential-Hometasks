using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4CalCulatorMVP
{
    public partial class Form1 : Form
    {
         Model model = null;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
        }



        #region Numbers
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }


        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        #endregion




        private void Button_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = model.Enter_Check(textBox1.Text);
            model.Clear();
           
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += model.OperationCheck(textBox1.Text,"+");
            textBox1.Clear();
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += model.OperationCheck(textBox1.Text, "-");
            textBox1.Clear();
        }

        private void Mult_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += model.OperationCheck(textBox1.Text, "X");
            textBox1.Clear();
        }

        private void Div_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += model.OperationCheck(textBox1.Text, "/");
            textBox1.Clear();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            model.Clear();
        }
    }
}
