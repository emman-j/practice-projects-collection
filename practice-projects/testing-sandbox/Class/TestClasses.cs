using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing1.Class
{
    public class TestClasses
    {
        public class TestFormManager
        {
            public Form activeForm = null;
            public void OpenChildForm(System.Windows.Forms.Form childForm, System.Windows.Forms.Panel formPanel)
            {
                if (activeForm != null) { activeForm.Close(); }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                formPanel.Controls.Add(childForm);
                formPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
    }
}
