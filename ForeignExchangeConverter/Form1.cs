using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeignExchangeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usTextBox_TextChanged(object sender, EventArgs e)
        {          
           string strDollars = usText.Text;
            var dollars= 0.0;

           if (!double.TryParse(strDollars, out dollars))
            {
                nisText.Text = "0";
                cadText.Text = "0";
                eurText.Text = "0";
            }
            else
            { 
                //dollars -> shekels
                string us2ilExchangeStr = nis2usdText.Text;
                var us2ilExchangeVar = 0.0;

                if (!double.TryParse(us2ilExchangeStr, out us2ilExchangeVar))
                {
                    nisText.Text = "0";
                    MessageBox.Show("Wrong Exchange Rate");
                }
                else
                {
                    var shekels = dollars * us2ilExchangeVar;
                    nisText.Text = shekels.ToString();
                }

                // dollars -> CAD
                string us2cadExchangeStr = usd2cadText.Text;
                var us2cadExchangeVar = 0.0;

                if (!double.TryParse(us2cadExchangeStr, out us2cadExchangeVar))
                {
                    cadText.Text = "0";
                    MessageBox.Show("Wrong Exchange Rate");
                }
                else
                {
                    var cad = dollars / us2cadExchangeVar;
                    cadText.Text = cad.ToString();
                }

                // dollars -> euro
                string us2euroExchangeStr = usd2eurText.Text;
                var us2euroExchangeVar = 0.0;

                if (!double.TryParse(us2euroExchangeStr, out us2euroExchangeVar))
                {
                    eurText.Text = "0";
                    MessageBox.Show("Wrong Exchange Rate");
                }
                else
                {
                    var euro = dollars / us2euroExchangeVar;
                    eurText.Text = euro.ToString();
                }


            } 


        } 

        private void cadTextBox_TextChanged(object sender, EventArgs e)
        {
            string strCadDollars = cadText.Text;
            var cad = 0.0;

            if (!double.TryParse(strCadDollars, out cad))
            {
                usText.Text = "0";
            }
            else
            {
                // CAD -> dollars
                string us2cadExchangeStr = usd2cadText.Text;
                var us2cadExchangeVar = 0.0;

                if (!double.TryParse(us2cadExchangeStr, out us2cadExchangeVar))
                {
                    usd2cadText.Text = "0";
                    MessageBox.Show("Wrong Exchange Rate");
                }
                else
                {
                    if (cad % us2cadExchangeVar != 0)
                    {
                        var dollar = cad * us2cadExchangeVar;
                        usText.Text = dollar.ToString();
                    }
                }
            }
        }

        private void nisTextBox_TextChanged(object sender, EventArgs e)
        {
            string strNis = nisText.Text;
            var nis = 0.0;

            if (!double.TryParse(strNis, out nis))
            {
                usText.Text = "0";
            }
            else
            {
                // NIS -> dollars
                string us2nisExchangeStr = nis2usdText.Text;
                var us2nisExchangeVar = 0.0;

                if (!double.TryParse(us2nisExchangeStr, out us2nisExchangeVar))
                {
                    nis2usdText.Text = "0";
                    MessageBox.Show("Wrong Exchange Rate");
                }
                else
                {
                    var dollar = nis / us2nisExchangeVar;
                    usText.Text = dollar.ToString();
                }
            }
        }

        private void eurTextBox_TextChanged(object sender, EventArgs e)
        {
            string strEuro = eurText.Text;
            var euro = 0.0;

            if (!double.TryParse(strEuro, out euro))
            {
                usText.Text = "0";
            }
            else
            {
                // euro -> dollars
                string us2euroExchangeStr = usd2eurText.Text;
                var us2euroExchangeVar = 0.0;

                if (!double.TryParse(us2euroExchangeStr, out us2euroExchangeVar))
                {
                    usd2eurText.Text = "0";
                    MessageBox.Show("Wrong Exchange Rate");
                }
                else
                {
                    if (euro % us2euroExchangeVar != 0)
                    {
                        var dollar = euro * us2euroExchangeVar;
                        usText.Text = dollar.ToString();
                    }
                }
            }
        }

        private void us2cadTextBox_TextChanged(object sender, EventArgs e)
        {
            //us -> cad
            string us2cadExchangeStr = usd2cadText.Text;
            var us2cadExchangeVar = 0.0;

            if (!double.TryParse(us2cadExchangeStr, out us2cadExchangeVar))
            {
                usText.Text = "0";
                cadText.Text = "0";
                MessageBox.Show("WrongExchangeRate");
                
            }
            else
            {
                string usStr = usText.Text;
                var dollar = 0.0;
                string cadStr = cadText.Text;
                var cad = 0.0;


                if (!double.TryParse(usStr, out dollar) || !double.TryParse(cadStr, out cad))
                {
                    usText.Text = "0";
                    cadText.Text = "0";
                }
                else
                {
                  cad = dollar * us2cadExchangeVar;                 
                    cadText.Text = cad.ToString();
                }
            }
        }

        private void nis2usTextBox_TextChanged(object sender, EventArgs e)
        {
            string nis2usExchangeStr = nis2usdText.Text;
            var nis2usExchangeVar = 0.0;

            if (!double.TryParse(nis2usExchangeStr, out nis2usExchangeVar))
            {
                usText.Text = "0";
                nisText.Text = "0";
                MessageBox.Show("WrongExchangeRate");

            }
            else
            {
                string usStr = usText.Text;
                var dollar = 0.0;
                string nisStr = nisText.Text;
                var nis = 0.0;


                if (!double.TryParse(usStr, out dollar) || !double.TryParse(nisStr, out nis))
                {
                    usText.Text = "0";
                    nisText.Text = "0";
                }
                else
                {
                    nis = dollar * nis2usExchangeVar;
                    nisText.Text = nis.ToString();
                }
            }
        }

        private void us2eurTextBox_TextChanged(object sender, EventArgs e)
        {
            string us2euroExchangeStr = usd2eurText.Text;
            var us2euroExchangeVar = 0.0;

            if (!double.TryParse(us2euroExchangeStr, out us2euroExchangeVar))
            {
                usText.Text = "0";
                eurText.Text = "0";
                MessageBox.Show("WrongExchangeRate");

            }
            else
            {
                string usStr = usText.Text;
                var dollar = 0.0;
                string euroStr = eurText.Text;
                var euro = 0.0;


                if (!double.TryParse(usStr, out dollar) || !double.TryParse(euroStr, out euro))
                {
                    usText.Text = "0";
                    eurText.Text = "0";
                }
                else
                {
                    euro = dollar * us2euroExchangeVar;
                    eurText.Text = euro.ToString();
                }
            }
        }
    }
}
