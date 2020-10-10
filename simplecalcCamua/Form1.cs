using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalcCamua
{
    public partial class Form1 : Form
    {

        GetAnswer delegatedAddition, delegatedDifference, delegatedProduct, delegatedQuotient;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            delegatedQuotient = new GetAnswer(Formula.getQuotient);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegatedQuotient(num1, num2).ToString(),"Answer");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            delegatedDifference = new GetAnswer(Formula.getDifference);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegatedDifference(num1, num2).ToString(), "Answer");

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            delegatedProduct = new GetAnswer(Formula.getProduct);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegatedProduct(num1, num2).ToString(), "Answer");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            delegatedAddition = new GetAnswer(Formula.getSum);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegatedAddition(num1, num2).ToString(), "Answer");
        }
    }
}
