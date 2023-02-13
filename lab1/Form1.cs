using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] arr;
        private int n;

        private void initialize()
        {
            arr = new int[11];
            arr[0] = 2;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 1;
            arr[5] = 1;
            arr[6] = -1;
            arr[7] = 2;

            n = 8;

            lblArray.Text = "Array elements: " + Exercises.getArray(arr, n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initialize();
            lblResult.Text = Exercises.exercise1(arr, n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initialize();
            lblResult.Text = Exercises.exercise2(arr, n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            initialize();
            if (txtNum.Text != "")
            {
                int num = Convert.ToInt32(txtNum.Text);
                lblResult.Text = Exercises.exercise3(arr, n, num);
            }
            else lblResult.Text = "Input value is incorrect!";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            initialize();
            lblResult.Text = Exercises.exercise4(arr, n);
        }
    }
}
