using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs4_demo_week3_recursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult1.Text = power(Convert.ToDouble(this.tbxEx1n.Text), Convert.ToDouble(this.tbxEx1p.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            //double x = power(Convert.ToDouble(this.tbxEx1n), Convert.ToDouble(this.tbxEx1p));
            //lblResult1.Text = x.ToString();
        }

        private double power(double n, double p)
        {
            if (p > 0)
            {
                return n * power(n, p - 1);
            }
            else return 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult2.Text = multiplication(Convert.ToDouble(this.tbxEx2n.Text), Convert.ToDouble(this.tbxEx2m.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private double multiplication(double n, double m)
        {
            if (m > 0)
            {
                return n + multiplication(n, m - 1);
            }
            else return 0;
        }

    }
}
