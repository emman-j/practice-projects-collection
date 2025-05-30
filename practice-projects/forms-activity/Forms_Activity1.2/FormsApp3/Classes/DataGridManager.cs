using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3
{
    public class DataGridManager
    {
        PersonManager pManager = new PersonManager();

        public void Refresh(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = pManager.GetAllPeople();
        }

        public void ColumnHeader(DataGridView dataGridView, string Header, string newHeader)
        {
            dataGridView.Columns[Header].HeaderText = newHeader;
        }
    }
}
