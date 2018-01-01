using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array2DSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int ROWS = 3;
            const int COLS = 3;
            int[,] numbers = { { 1, 2, 3, 4},
                               { 5, 6, 7, 8},
                               { 9, 10, 11, 12}
                              };

            int total;

            for (int row = 0; row < ROWS; row++)
            {
                total = 0;
                for (int col = 0; col < COLS; col++)
                {
                    total += numbers[row, col];
                }
                MessageBox.Show("The total of row " + row + " is " + total);
            }         


        }
    }
}
