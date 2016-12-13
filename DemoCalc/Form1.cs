using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalc
{
    public partial class NormalCalc : Form
    {
        // Initialize calculator
        Calc calc = new Calc();

        public NormalCalc()
        {
            InitializeComponent();

            // Subscribe to current change
            calc.OnCurrentChange += (s, e) => {
                resultBox.Text = e.Current;
            };

        }


        // NumBtn
        private void sixButton_Click(object sender, EventArgs e)
        {
            calc.Current += "6";

        }


        // NumBtn
        private void twoButton_Click(object sender, EventArgs e)
        {
            calc.Current += "2";
        }

        // NumBtn
        private void oneButton_Click(object sender, EventArgs e)
        {
            calc.Current += "1";
        }

        // OprBtn
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calc.Num = Convert.ToDouble(calc.Current);
            calc.Enter();
            calc.NextAction = "Mul";
        }

        // Not used
        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        // Not used
        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        // NumBtn
        private void fiveButton_Click(object sender, EventArgs e)
        {
            calc.Current += "5";
        }

        // NumBtn
        private void sevenButton_Click(object sender, EventArgs e)
        {
            calc.Current += "7";
        }

        // NumBtn
        private void eightButton_Click(object sender, EventArgs e)
        {
            calc.Current += "8";
        }

        // NumBtn
        private void nineButton_Click(object sender, EventArgs e)
        {
            calc.Current += "9";
        }

        // NumBtn
        private void fourButton_Click(object sender, EventArgs e)
        {
            calc.Current += "4";
        }

        // NumBtn
        private void threeButton_Click(object sender, EventArgs e)
        {
            calc.Current += "3";
        }

        // NumBtn
        private void zeroButton_Click(object sender, EventArgs e)
        {
            calc.Current += "0";
        }

        // DclBtn
        private void decimalButton_Click(object sender, EventArgs e)
        {
            // Only one decemal point
            if (!calc.Current.Contains(".")) 
                calc.Current += ".";
        }

        // Clear
        private void clearButton_Click(object sender, EventArgs e)
        {
            calc.Clear();
        }

        // OprBtn
        private void plusButton_Click(object sender, EventArgs e)
        {
            calc.Num = Convert.ToDouble(calc.Current);
            calc.Enter();
            calc.NextAction = "Add";
            
        }

        // OprBtn
        private void equalsButton_Click(object sender, EventArgs e)
        {
            calc.Num = Convert.ToDouble(calc.Current);
            calc.Equals();

        }

        // OprBtn
        private void minusButton_Click(object sender, EventArgs e)
        {
            // calc.Subtract(Convert.ToDouble(calc.Current));
            calc.Num = Convert.ToDouble(calc.Current);
            calc.Enter();
            calc.NextAction = "Sub";
            
        }

        // OprBtn
        private void divideButton_Click(object sender, EventArgs e)
        {
            calc.Num = Convert.ToDouble(calc.Current);
            calc.Enter();
            calc.NextAction = "Div";
        }

        // MemBtn
        private void MButton_Click(object sender, EventArgs e)
        {
            calc.Num = calc.Mem;
            calc.Current = calc.Num.ToString();
        }

        // MemBtn
        private void memPlusButton_Click(object sender, EventArgs e)
        {
            calc.Num = Convert.ToDouble(calc.Current);
            calc.Mem = calc.Mem + calc.Num; 
        }

        // MemBtn
        private void memClearButton_Click(object sender, EventArgs e)
        {
            calc.Mem = 0;
        }

        // Not used
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Not used
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // OprBtn
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            calc.Num = Convert.ToDouble(calc.Current);
            // Immediate display of result
            calc.NextAction = "Sqr";
            calc.Enter();
            
        }

        private async void factorialButton_Click(object sender, EventArgs e)
        {
            checked
            {
                long result;
                result = await calc.FactorialAsync(int.Parse(calc.Current));
                calc.Current = result.ToString();
            }

        }
    }
}
