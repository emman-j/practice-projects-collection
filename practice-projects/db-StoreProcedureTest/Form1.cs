using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Database;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Database database = new Database();
        private string selectedColumn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //database.LoadAllUnfinished(dataGridView1);
            database.GetSearchResults(selectedColumn, "", dataGridView1);
            database.LoadAllOngoing(dataGridView2);

            DatagridViewManager.DataGridViewFormatting(dataGridView1);
            DatagridViewManager.DataGridViewFormatting(dataGridView2);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Name == "dataGridView1" || dataGridView.Name == "dataGridView2")
                {
                    int selectedRowCount = dataGridView.SelectedRows.Count;
                    label1.Text = $"Count: {selectedRowCount}";
                }
                else
                {
                    int selectedRowCount = dataGridView.SelectedCells.Count;
                    label1.Text = $"Count: {selectedRowCount}";
                }
            }
        }
    }
}
