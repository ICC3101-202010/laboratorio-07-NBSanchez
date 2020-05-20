using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    [Serializable]
    public partial class Numero7 : Form
    {
        Double resultValue = 0;
        String operationPerfom = " ";
        bool isoperation = false;
        public Numero7()
        {
            InitializeComponent();
        }

        private void click_boton(object sender, EventArgs e)
        {
            if ( TEXTresultado.Text == "0" || isoperation)
            {
                TEXTresultado.Clear();
            }

            isoperation = false;
            Button boton = (Button)sender;
            
            if (boton.Text == ",")
            {
                if (!TEXTresultado.Text.Contains(","))
                    TEXTresultado.Text = TEXTresultado.Text + boton.Text;
               
            }else
            TEXTresultado.Text = TEXTresultado.Text + boton.Text;

        }

        private void operador_boton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (resultValue != 0)
            {
                respuesta.PerformClick();
                operationPerfom = boton.Text;
                label_text.Text = resultValue + "" + operationPerfom;
                isoperation = true;
            }
            else
            {
                operationPerfom = boton.Text;
                resultValue = Double.Parse(TEXTresultado.Text);
                label_text.Text = resultValue + "" + operationPerfom;
                isoperation = true;

            }
            

        }

        private void Delete_1number(object sender, EventArgs e)
        {
            TEXTresultado.Text = "0";
            resultValue = 0;


        }

        private void Delete_All(object sender, EventArgs e)
        {
            TEXTresultado.Text = "0";

        }

        private void Equal_boton(object sender, EventArgs e)
        {
            switch (operationPerfom)
            {
                case "+":
                    TEXTresultado.Text = (resultValue + Double.Parse(TEXTresultado.Text)).ToString();
                    break;
                case "-":
                    TEXTresultado.Text = (resultValue - Double.Parse(TEXTresultado.Text)).ToString();
                    break;
                case "*":
                    TEXTresultado.Text = (resultValue * Double.Parse(TEXTresultado.Text)).ToString();
                    break;
                case "/":
                    TEXTresultado.Text = (resultValue / Double.Parse(TEXTresultado.Text)).ToString();
                    break;
                default:
                    break;



            }
            resultValue = Double.Parse(TEXTresultado.Text);
            label_text.Text = " ";



        }

        private void Answerd_boton(object sender, EventArgs e)
        {

        }
    }
}
