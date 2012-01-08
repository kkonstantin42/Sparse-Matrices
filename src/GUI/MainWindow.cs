using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DigitalRune.Mathematics;
using DigitalRune.Mathematics.Analysis;
using SparseMatrices.Tools;

namespace SparseMatrices.GUI
{
    public partial class MainWindow : Form
    {
        ArrayList freqList = new ArrayList();
        ArrayList resultList = new ArrayList();
        Random rnd = new Random();
        private int n = 0;
        private int t = 1;

        public MainWindow()
        {
            InitializeComponent();
            mainChart.Series.Add("Frequencies");
        }

        private void evalButton_Click(object sender, EventArgs e)
        {
            


            mainChart.Series[0].Points.Add(t);

            freqList.Add(n++);
            resultList.Add(t += 5);
            
            
        }

        private void danceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mainChart.Series[0].Points.Count(); i++)
            {

                mainChart.Series[0].Points[i].YValues.SetValue(rnd.Next(0, 300), 0);
            }


            updateChart();
            
        }


        private void updateChart()
        {
            mainChart.ResetAutoValues();
            mainChart.Invalidate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            double[] inp = new double[] {-36, 33, -10, 1, 17, -32, 1, -3, 5};

            mainChart.Series.Clear();
            mainChart.Series.Add("Frequencies");
            
            
            Func<double, double> foo = PolynomialFactory.getPolynomialFunction(inp);
            Func<double, double> fooD = PolynomialFactory.getPolynomialDerivative(inp);

            ImprovedNewtonRaphsonMethodD rootFinder = new ImprovedNewtonRaphsonMethodD(foo, fooD);
            double x1 = float.MinValue, x2 = 1.84;
            double equalsTo = 0;

            rootFinder.ExpandBracket(ref x1, ref x2, equalsTo);

            double root = rootFinder.FindRoot(x1, x2, equalsTo);

            MessageBox.Show("Root is: " + root + "    x1: " + x1 + ";   x2: " + x2);
            
        }

        private void randomCheck_Click(object sender, EventArgs e)
        {
            double prob;
            int count;
            try
            {
                count = Convert.ToInt32(dataAmountTextBox.Text);
                prob = Convert.ToDouble(zeroProbTextBox.Text);

                if(count < 0)
                    throw new FormatException();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Number conversion error");
                zeroProbTextBox.Text = "0";
                return;
            }

            mainChart.Series[0].Points.Clear();
            mainChart.Series[0].Points.Add(0).XValue = 0;
            mainChart.Series[0].Points.Add(0).XValue = 1;


            int rndVal;
            MyRandom rnd = new MyRandom();

            for (int i = 0; i < count; i++)
            {
                rndVal = rnd.getBinary(prob);
                if (rndVal == 0)
                    mainChart.Series[0].Points[0].YValues[0]++;
                else
                    mainChart.Series[0].Points[1].YValues[0]++;

            }

            updateChart();
        }


  


    }
}
