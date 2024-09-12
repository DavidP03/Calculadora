using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public float num1;
        public float num2;
        public string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            num1 = 0;
            num2 = 0;
            operacion = "";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 1;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 2;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 3;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 4;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 5;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 6;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 7;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 8;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 9;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text + 0;
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(tbResult.Text);
            operacion = "suma";
            tbResult.Text = "";
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(tbResult.Text);
            operacion = "resta";
            tbResult.Text = "";
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(tbResult.Text);
            operacion = "multiplicacion";
            tbResult.Text = "";
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(tbResult.Text);
            operacion = "division";
            tbResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(num1 != float.Parse(tbResult.Text))
                    num2 = float.Parse(tbResult.Text);

                switch (operacion)
                {
                    case "suma":
                        {
                            tbResult.Text = "" + (num1 + num2);
                            num1 = float.Parse(tbResult.Text);
                        }
                        break;
                    case "resta":
                        {
                            tbResult.Text = "" + (num1 - num2);
                            num1 = float.Parse(tbResult.Text);
                        }
                        break;
                    case "multiplicacion":
                        {
                            tbResult.Text = "" + (num1 * num2);
                            num1 = float.Parse(tbResult.Text);
                        }
                        break;
                    case "division":
                        {
                            tbResult.Text = "" + (num1 / num2);
                            num1 = float.Parse(tbResult.Text);
                        }
                        break;
                }
            }
            catch (Exception)
            {
                num1 = 0;
                num2 = 0;
                tbResult.Text = "";
                operacion = "";
            }
        }
    }
}
