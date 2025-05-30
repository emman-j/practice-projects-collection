using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace testUI.Forms
{
    public partial class Account_Manager : Form
    {
        DataTable dataTable = new DataTable();
        public Account_Manager()
        {
            InitializeComponent();

            UserAcc_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserAcc_dataGridView.MultiSelect = false; // Single row selection
            UserAcc_dataGridView.ClearSelection();

            roleComboBox.SelectedItem = "User";

            GetUser();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            WindowManager.ReleaseCapture();
            WindowManager.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void GetUser()
        {
            
            string connectionString = "Server=.;Database=Sample2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("dbo.GetUserAccount", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);

                UserAcc_dataGridView.DataSource = dataTable;

            }
        }
        public void ClearTextBox()
        {
            usernametxt.Clear();
            firstnametxt.Clear();
            lastnametxt.Clear();
            emailtxt.Clear();
            idNumbertxt.Clear();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (UserAcc_dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = UserAcc_dataGridView.SelectedRows[0];

                // Get the user_id of the row to be deleted
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

                string connectionString = "Server=.;Database=Sample2;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var parameters = new {user_id = userId};
                    // Execute the stored procedure
                    connection.Execute("dbo.DeleteUserAcc", parameters, commandType: CommandType.StoredProcedure);
                }

                // Remove the row from the DataGridView
                UserAcc_dataGridView.Rows.Remove(selectedRow);

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UserAcc_dataGridView.ClearSelection();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string password = "pw";
            if
           (
                   string.IsNullOrWhiteSpace(usernametxt.Text) ||
                   string.IsNullOrWhiteSpace(password) ||
                   string.IsNullOrWhiteSpace(lastnametxt.Text) ||
                   string.IsNullOrWhiteSpace(idNumbertxt.Text) ||
                   string.IsNullOrWhiteSpace(emailtxt.Text) ||
                   string.IsNullOrWhiteSpace(firstnametxt.Text)
           )
            {
                MessageBox.Show("Fields cannot be empty!" + Environment.NewLine +
                     "Please try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserAcc_dataGridView.ClearSelection();
            }
            else if (!int.TryParse(idNumbertxt.Text, out _))
            {
                MessageBox.Show("Invalid ID Number!" + Environment.NewLine +
                      "Please try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database db = new Database();
                int idNumber = Convert.ToInt32(idNumbertxt.Text);
                db.CreateAccount(usernametxt.Text, password, firstnametxt.Text, lastnametxt.Text, emailtxt.Text, idNumber);
                ClearTextBox();
            }
            GetUser();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (UserAcc_dataGridView.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(usernametxt.Text) || !string.IsNullOrWhiteSpace(lastnametxt.Text) || 
                !string.IsNullOrWhiteSpace(idNumbertxt.Text) || !string.IsNullOrWhiteSpace(emailtxt.Text) || !string.IsNullOrWhiteSpace(firstnametxt.Text))
            {
                DataGridViewRow selectedRow = UserAcc_dataGridView.SelectedRows[0];

                // Get the user_id of the row to be updated
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

                string connectionString = "Server=.;Database=Sample2;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var parameters = new
                    {
                        user_id = userId,
                        Username = usernametxt.Text,
                        Firstname = firstnametxt.Text,
                        Lastname = lastnametxt.Text,
                        Email = emailtxt.Text,
                    };
                    // Execute the stored procedure
                    connection.Execute("dbo.UpdateUserAcc", parameters, commandType: CommandType.StoredProcedure);
                }
                GetUser();
                ClearTextBox();
                UserAcc_dataGridView.ClearSelection();
                MessageBox.Show("User Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
