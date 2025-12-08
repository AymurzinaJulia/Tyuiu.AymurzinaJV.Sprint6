using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.AymurzinaJV.Sprint6.Task3.V1.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task3.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 25, 20, 28, 2, 6},
                                      { 19, 9, 18, -7, 24},
                                      { 21, 16, 5, -7, -8},
                                      { 30, -13, 1, -15, 2 },
                                      { 31, 9, -3, -9, -18 } };
        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            textBoxResult_AJV.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void textBoxResult_AJV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
