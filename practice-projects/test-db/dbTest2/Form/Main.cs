using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbTest2
{
    public partial class Main : Form
    {
        List<Customer> customer = new List<Customer>();


        public Main()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            customer = db.ViewCustomer();

            //DataGridView
            dataGridView1.DataSource = customer;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Remove("CusFullInfo");
            dataGridView1.Columns.Remove("Country");

            //ListBox
            customerFoundListbox.DataSource = customer;
            customerFoundListbox.DisplayMember = "CusFullInfo";


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            TextBoxManager tbManager = new TextBoxManager();

            customer = db.GetCustomer(searchCountrytxt.Text);

            customerFoundListbox.DataSource = customer;
            customerFoundListbox.DisplayMember = "CusFullInfo";
            dataGridView1.DataSource = customer;

            tbManager.ClearTextBox(searchCountrytxt);
        }
    }
}
