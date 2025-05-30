using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormsApp3
{
    public partial class Main : Form
    {
        PersonManager pManager = new PersonManager();
        TextBoxManager tbManager = new TextBoxManager();
        DataGridManager dgManager = new DataGridManager();

        public Main()
        {
            InitializeComponent();

            Person Test = new Person("Juan", "Dela Cruz");
            Console.WriteLine($"{Test.Fname} {Test.Lname}");
            pManager.AddPerson(Test);
            pManager.AddPerson(new Person("Maria", "Clara"));
            pManager.AddPerson(new Person("Pepito", "Manaloto"));
            pManager.AddPerson(new Person("Giga", "Byte"));

            //bind Person to dataGridView
            dataGridView1.DataSource = pManager.GetAllPeople();

            // Customize column headers after data binding
            dgManager.ColumnHeader(dataGridView1, "fname", "First Name");
            dgManager.ColumnHeader(dataGridView1, "lname", "Last Name");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Retrieve Values from Textboxes
            string fname = Firstnametxt.Text;
            string lname = Lastnametxt.Text;

            //Create new Person object and add to list

            Person newPerson = new Person(fname, lname);
            pManager.AddPerson(newPerson);

            //Refresh DataGridView
            //dgManager.Refresh(dataGridView1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pManager.GetAllPeople();

            //Clear Textboxes
            tbManager.ClearTextBox(Firstnametxt);
            tbManager.ClearTextBox(Lastnametxt);

            dgManager.ColumnHeader(dataGridView1, "fname", "First Name");
            dgManager.ColumnHeader(dataGridView1, "lname", "Last Name");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Retrieve Values from Textboxes
            string searchterm = searchtxt.Text;
            List<Person> Result = pManager.Search(searchterm);
            pManager.PrintSearchResults(Result);
            tbManager.ClearTextBox(searchtxt);
        }

    }
}