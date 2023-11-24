using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            listofOperator();
        }

        public void listofOperator()
        {
            cmbBox1.Items.Add("+");
            cmbBox1.Items.Add("-");
            cmbBox1.Items.Add("*");
            cmbBox1.Items.Add("/");
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill up the textbox");
            }
            else if (cmbBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an operator");
            }
            else
            {
                float num1 = Convert.ToInt64(textBox1.Text);
                float num2 = Convert.ToInt64(textBox2.Text);

                if (cmbBox1.SelectedItem.ToString() == "+")
                {
                    float add = BasicComputation.Addition(num1, num2);
                    label3.Text = add.ToString();
                }
                else if (cmbBox1.SelectedItem.ToString() == "-")
                {
                    float sub = BasicComputation.Substraction(num1, num2);
                    label3.Text = sub.ToString();
                }
                else if (cmbBox1.SelectedItem.ToString() == "*")
                {
                    float mul = BasicComputation.Multiplication(num1, num2);
                    label3.Text = mul.ToString();
                }
                else if (cmbBox1.SelectedItem.ToString() == "/")
                {
                    float div = BasicComputation.Division(num1, num2);
                    label3.Text = div.ToString();
                }

            }


        }

    }
}
