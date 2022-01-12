using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Mohammed Waseq Rahman";
            DateTime currentDateTime = DateTime.Now;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val4 = 0;
            val4 = Convert.ToInt32(txtBox4.Text);
            double result = val4 * 0.6214;
            txtBox8.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = 0;
            val1 = Convert.ToInt32(txtBox1.Text);
            double result = val1 * 0.03937 ;
            txtBox5.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val2 = 0;
            val2 = Convert.ToInt32(txtBox2.Text);
            double result = val2 * 0.3937;
            txtBox6.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val3 = 0;
            val3 = Convert.ToInt32(txtBox3.Text);
            double result = val3 * 1.0936;
            txtBox7.Text = result.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtAns1.Text = ("c").ToString();
            txtAns2.Text = ("a,b,c").ToString();
            txtAns3.Text = ("a").ToString();
            txtAns4.Text = ("c").ToString();
            txtAns5.Text = ("d").ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "0";
            txtBox2.Text = "0";
            txtBox3.Text = "0";
            txtBox4.Text = "0";
            txtBox5.Text = "0";
            txtBox6.Text = "0";
            txtBox7.Text = "0";
            txtBox8.Text = "0";
            txtAns1.Text = "a,b,c,d";
            txtAns2.Text = "a,b,c,d";
            txtAns3.Text = "a,b,c,d";
            txtAns4.Text = "a,b,c,d";
            txtAns5.Text = "a,b,c,d";
        }

        private void btnTotalChars_Click(object sender, EventArgs e)
        {
            txtTotalLength.Text = textBox1.Text.Length.ToString();
            txtTotalLength.ToString();       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTotalID_Click(object sender, EventArgs e)
        {
            int val1 = 0, val2 = 0, val3 = 0, val4 = 0, val5 = 0, val6 = 0, val7 = 0,result;
            val1 = Convert.ToInt32(textBox2.Text);
            val2 = Convert.ToInt32(textBox3.Text);
            val3 = Convert.ToInt32(textBox4.Text);
            val4 = Convert.ToInt32(textBox5.Text);
            val5 = Convert.ToInt32(textBox6.Text);
            val6 = Convert.ToInt32(textBox7.Text);
            val7 = Convert.ToInt32(textBox8.Text);
            result = val1 + val2 + val3 + val4 + val5 + val6 + val7;

            txtTotalID.Text = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "9";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "1";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "3";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = "8";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "6";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = "4";
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
