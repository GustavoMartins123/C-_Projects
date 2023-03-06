using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal value1 = 0;
        decimal value2 = 0;
        decimal result = 0;
        bool operacaoRealizada = false;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "2";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "ERRO")
            {
                txtResultado.Text += ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != ""&& txtResultado.Text != "ERRO")
            {
                value1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtResultado.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out value2))
            {
                if (txtResultado.Text == "")
                {
                    return;
                }
                txtResultado.Text = "ERRO";
            }
            
            switch (operacao)
            {
                case "SOMA":
                    if (!operacaoRealizada)
                    {
                        if (value2 == 0)
                        {
                            result = value1 + value2;
                            operacaoRealizada = true;
                            return;
                        }
                        else
                        {
                            result = value1 + value2;
                            txtResultado.Text = Convert.ToString(result);
                            operacaoRealizada = true;
                            return;
                        }
                    }
                    else
                    {
                        if (value2 == 0)
                        {
                            return;
                        }
                        else
                        {
                            result = value1 + value2;
                            txtResultado.Text = Convert.ToString(result);
                            return;
                        }
                    }
                    /*if (value2 != 0)
                    {
                        value1 += value2;
                        txtResultado.Text = Convert.ToString(value1);
                    }*/
                case "SUB":
                    if (value2 != 0)
                    {
                        value1 -= value2;
                        txtResultado.Text = Convert.ToString(value1);
                    }
                    break;
                case "MULT":
                    txtResultado.Text = Convert.ToString(value1 * value2);
                    break;
                case "DIV":
                    if(value2 == 0)
                    {
                        txtResultado.Text = "ERRO";
                        MessageBox.Show("Não é possível dividir por zero!");
                        lblOperacao.Text = "";
                        operacao = "";
                        break;
                    }
                    txtResultado.Text = Convert.ToString(value1 / value2);
                    break;
                default:
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" && txtResultado.Text != "ERRO")
            {
                value1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" && txtResultado.Text != "ERRO")
            {
                value1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" && txtResultado.Text != "ERRO")
            {
                value1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            value1 = 0;
            value2 = 0;
            operacao = "";
        }

    }
}
