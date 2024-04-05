using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace Task_4_forms
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string label1 = A.Text;
            string label2 = B.Text;
            int a = Convert.ToInt32(label1);
            int b = Convert.ToInt32(label2);
            double SumSqrts = Math.Pow(a, 2) + Math.Pow(b, 2);
            double SqrtSum = Math.Pow((a + b), 2);
            SumSqrtsOut.Text = SumSqrts.ToString();
            SqrtSumOut.Text = SqrtSum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label1 = A.Text; 
            string label2 = B.Text; 

            int a = Convert.ToInt32(label1);
            int b = Convert.ToInt32(label2);
            double SumSqrts = Math.Pow(a, 2) + Math.Pow(b, 2);
            double SqrtSum = Math.Pow((a + b), 2);
            SumSqrtsOut.Text = SumSqrts.ToString();
            SqrtSumOut.Text = SqrtSum.ToString();
            if (SumSqrts > SqrtSum)
            {
                ResultOut.Text = "Сумма квадратів більше";
            }
            else if (SqrtSum > SumSqrts)
            {
                ResultOut.Text = "Квадрат сумми більше";
            }
            else
            {
                ResultOut.Text = "Некоректне введення. Число рівне 0.";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Визначити, що більше сума квадратів, або квадрат суми \n © Совєтніков Олександр, 2024", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
