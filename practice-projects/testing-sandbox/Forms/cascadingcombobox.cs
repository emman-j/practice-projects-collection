using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testing1.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace testing1.Forms
{
    public partial class cascadingcombobox : Form
    {
        
        public cascadingcombobox()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<Main>(this);
        }

        public void cascadedcombobox()
        {


        }


        public static string selectedcombobox;
        public static bool comboBox1selected = false;
        public static bool comboBox2selected = false;
        public static bool comboBox3selected = false;
        public static bool comboBox4selected = false;
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox currentcombobox)
            {
                if (currentcombobox.SelectedItem != null)
                {
                    switch (currentcombobox.Name)
                    {
                        case "comboBox1":
                            selectedcombobox = "Customer";
                            label2.Text = selectedcombobox;
                            comboBox1selected = true;
                            break;
                        case "comboBox2":
                            selectedcombobox = "Project";
                            label2.Text = selectedcombobox;
                            comboBox2selected = true;
                            break;
                        case "comboBox3":
                            selectedcombobox = "Activity";
                            label2.Text = selectedcombobox;
                            comboBox3selected = true;
                            break;
                        case "comboBox4":
                            selectedcombobox = "Person-In-Charge";
                            label2.Text = selectedcombobox;
                            comboBox4selected = true;
                            break;
          
                        default: selectedcombobox = "Wala"; label2.Text = selectedcombobox; break;
                    }
                    Checkstate();
                    //return; 
                }
                else
                {
                    //checkedBox.ForeColor = SystemColors.ControlDarkDark;
                    label2.Text = "Mali";
                }

            }
        }
        private void Checkstate()
        {
            if (comboBox1selected && button1.Visible)
            { 
                button1.Visible = false;
            }
            else if (comboBox2selected && button2.Visible)
            { 
                button2.Visible = false;
            }
            else if (comboBox3selected && button3.Visible)
            { 
                button3.Visible = false;
            }
            else if (comboBox4selected && button4.Visible)
            { 
                button4.Visible = false;
            }
            else 
            { label2.Text = "MALI uli"; }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1selected = false;
            comboBox2selected = false;
            comboBox3selected = false;
            comboBox4selected = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void cascadingcombobox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
