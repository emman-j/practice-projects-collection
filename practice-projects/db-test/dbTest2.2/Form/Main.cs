using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbTest2
{
    public partial class Main : Form
    {
        List<Customer> customer = new List<Customer>();
        List<Employees> employee = new List<Employees>();


        public Main()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            //DataGridView
            customerDataGridView.DataSource = db.ViewCustomer();
            customerDataGridView.AutoGenerateColumns = false;
            customerDataGridView.Columns.Remove("CusFullInfo");
            //customerDataGridView.Columns.Remove("Country");

            employeeDataGridView.DataSource = db.ViewEmployees();
            employeeDataGridView.AutoGenerateColumns = false;
            employeeDataGridView.Columns.Remove("EmpFullInfo");

            //ListBox
            customerFoundListbox.DataSource = db.ViewCustomer();
            customerFoundListbox.DisplayMember = "CusFullInfo";

            employeeFoundListbox.DataSource = db.ViewEmployees();
            employeeFoundListbox.DisplayMember = "EmpFullInfo";


        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            TextBoxManager tbManager = new TextBoxManager();

            customer = db.GetCustomer(searchCountrytxt.Text);
            customerFoundListbox.DataSource = customer;
            customerFoundListbox.DisplayMember = "CusFullInfo";
            customerDataGridView.DataSource = customer;

            tbManager.ClearTextBox(searchCountrytxt);
        }

        private void employeeSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            TextBoxManager tbManager = new TextBoxManager();

            employee = db.GetEmployees(searchEmployeetxt.Text);
            employeeFoundListbox.DataSource = employee;
            employeeFoundListbox.DisplayMember = "EmpFullInfo";
            employeeDataGridView.DataSource = employee;

            tbManager.ClearTextBox(searchEmployeetxt);
        }



        private void searchCountrytxt_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            TextBoxManager tbManager = new TextBoxManager();

            customer = db.GetCustomer(searchCountrytxt.Text);
            customerFoundListbox.DataSource = customer;
            customerFoundListbox.DisplayMember = "CusFullInfo";
            customerDataGridView.DataSource = customer;
        }

        private void searchEmployeetxt_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            TextBoxManager tbManager = new TextBoxManager();

            employee = db.GetEmployees(searchEmployeetxt.Text);
            employeeFoundListbox.DataSource = employee;
            employeeFoundListbox.DisplayMember = "EmpFullInfo";
            employeeDataGridView.DataSource = employee;
        }

        private void customerFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
