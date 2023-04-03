using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Senkron_Asenkron
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Sum(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private async void btnMultiplication_Click(object sender, EventArgs e)
        {
            await MultiplicationAsync(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            MessageBox.Show("Process Completed.");
        }

        private void Sum(int number1, int number2)
        {
            MessageBox.Show($"Result: {number1 + number2}");
        }

        private void Multiplication(int number1, int number2)
        {
            Thread.Sleep(10000);
            MessageBox.Show($"Result: {number1 * number2}");
        }

        private Task MultiplicationAsync(int number1, int number2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show($"Result: {number1 * number2}");
            });
        }
    }
}
