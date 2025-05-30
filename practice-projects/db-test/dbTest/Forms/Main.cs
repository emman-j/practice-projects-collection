using dbTest.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace dbTest
{
    public partial class Main : Form
    {
        List<Employees> employees = new List<Employees>();
        public Main()
        {
            InitializeComponent();
            peopleFoundListBox.DataSource = employees;
            peopleFoundListBox.DisplayMember = "EmpFullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            DataAccess db = new DataAccess();

            peopleFoundListBox.DataSource = employees;

            employees = db.FindEmployees(lastNametxt.Text);
            peopleFoundListBox.DataSource = employees;
            peopleFoundListBox.DisplayMember = "EmpFullInfo";
        }

        private void peopleFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
