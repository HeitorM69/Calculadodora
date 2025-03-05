using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadodora
{
    public partial class Form1: Form
    {
        double num1, num2, resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void AtribuirOperação(String oper)
        {
            lblOper.Text = oper;
            btIgual.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            AtribuirOperação(btSoma.Text);
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperação(btSub.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperação(btMult.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperação(btDiv.Text);
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
        
            num1 = (double)numOper1.Value;
            num2 = (double)numOper2.Value;

            if (lblOper.Text == btSoma.Text)
                resultado = num1 + num2;
            else if (lblOper.Text == btSub.Text)
                resultado = num1 - num2;
            else if (lblOper.Text == btMult.Text)
                resultado = num1 * num2;
            else
                resultado = num1 / num2;
            lblResultado.Text = resultado.ToString();

        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            double limpar = 0;
            if((double)numOper1.Value >= 0 && (double)numOper2.Value >= 0)
            {
                numOper1.Value = 0;
                numOper2.Value = 0;
                lblResultado.Text = limpar.ToString();
                btIgual.Enabled = false;
                lblOper.Text = "...";
            }
        }

        private void btSegue_Click(object sender, EventArgs e)
        {
            numOper1.Value = (decimal)resultado;
            double d = Double.Parse("0.5");
        }
    }
}
