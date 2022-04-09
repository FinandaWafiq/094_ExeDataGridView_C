using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads the data into the table 'ProdiTIDataSet.Mahasiswa'. You can move, or delete them as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.SlateBlue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Teal;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkMagenta;

            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkSlateBlue;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Teal;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Pink;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Orange;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.RoyalBlue;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Maroon;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}