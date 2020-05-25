using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        String operationPerfom = "";
        bool isoperation = false;
        String Ans = " ";
        String firstNum, secondNum;
        List<string> history = new List<string>() { " " };
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

            
            Button boton = (Button)sender;
            isoperation = false;

            if (boton.Text == ",")
            {
                if (!TEXTresultado.Text.Contains(","))
                    TEXTresultado.Text = TEXTresultado.Text + boton.Text;
                else
                {
                    TEXTresultado.Text = "Syntax Error";
                }
               
            }
            else
            TEXTresultado.Text = TEXTresultado.Text + boton.Text;

        }

        private void operador_boton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            
            resultValue = Double.Parse(TEXTresultado.Text);
            TEXTresultado.Text = TEXTresultado.Text + boton.Text;
            operationPerfom = boton.Text;
            label_text.Text = resultValue + "" + operationPerfom;
            isoperation = true;

            firstNum = label_text.Text;

        }

        private void Delete_1number(object sender, EventArgs e)
        {
           if ( TEXTresultado.Text.Length > 0)
            {
                TEXTresultado.Text = TEXTresultado.Text.Remove(TEXTresultado.Text.Length - 1, 1);
            }
           if (TEXTresultado.Text == "")
            {
                TEXTresultado.Text = "0";
            }
           


        }

        private void Delete_All(object sender, EventArgs e)
        {
            TEXTresultado.Text = "0";
            

        }

        private void Equal_boton(object sender, EventArgs e)

        {
            secondNum = TEXTresultado.Text;
            switch (operationPerfom)
            {
                case "+":
                    TEXTresultado.Text = (resultValue + Double.Parse(TEXTresultado.Text)).ToString();
                    Ans = (TEXTresultado.Text);
                    break;
                case "-":
                    TEXTresultado.Text = (resultValue - Double.Parse(TEXTresultado.Text)).ToString();
                    Ans = (TEXTresultado.Text);
                    break;
                case "*":
                    TEXTresultado.Text = (resultValue * Double.Parse(TEXTresultado.Text)).ToString();
                    Ans = (TEXTresultado.Text);
                    break;
                case "/":
                    TEXTresultado.Text = (resultValue / Double.Parse(TEXTresultado.Text)).ToString();
                    Ans = (TEXTresultado.Text);
                    break;
                default:
                    break;



            }
            resultValue = Double.Parse(TEXTresultado.Text);
            label_text.Text = " ";
            if (TEXTresultado.Text == "∞" || TEXTresultado.Text == "NaN")
            {
                TEXTresultado.Text = "Math Error";
            }
            //=======================================

            bote.Visible = true;
            richTextBox1.AppendText(firstNum + " " + secondNum + " = " + "\n");
            richTextBox1.AppendText("\n\t " + TEXTresultado.Text + "\n\n");
            history.Add(richTextBox1.Text);
            hay_historial.Text = " ";

        }
            
           
        private void Answerd_boton(object sender, EventArgs e)
        {
            TEXTresultado.Text = Ans; 

        }

        private void History_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < history.Count(); i++)
            {
                richTextBox2.Text = history[i];
            }
            richTextBox1.Text = "";
            bote.Visible = true;
            hay_historial.Text = "";
            richTextBox1.Clear();

        }

        private void bote_basura(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            if (hay_historial.Text == " ")
            {
                hay_historial.Text = "No hay historial";
            }
            bote.Visible = false;
            TEXTresultado.ScrollBars = 0;



        }
    }
}
