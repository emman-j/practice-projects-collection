using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace testing1.UserControls
{
    public static class FormManager
    {
        /// <summary>
        /// Used for mousedown events to allow dragging of form
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Switches from the current form to a new form, preserving state and position.
        /// </summary>
        /// <typeparam name="T">The type of the new form to show.</typeparam>
        /// <param name="currentForm">The current form that is being switched from.</param>
        /// 
        /// Sample application FormManager.SwitchForm<FORM YOU WANT TO SWITCH TO>(this);
        public static void SwitchForm<T>(Form currentForm) where T : Form, new()
        {
            // Find existing instance of the form, if it exists
            var existingForm = Application.OpenForms[typeof(T).Name] as T;

            if (existingForm == null)
            {
                // Create a new instance if it doesn't exist
                existingForm = new T();
            }

            // Preserve the state and location of the current form
            var state = currentForm.WindowState;
            var location = currentForm.Location;

            // Hide the current form
            currentForm.Hide();

            // Apply the preserved state and location to the new form
            existingForm.WindowState = state;
            existingForm.StartPosition = FormStartPosition.Manual;
            existingForm.Location = location;

            // Show the new form
            existingForm.Show();
        }
    }

    public static class UserLogin
    {
        public static void ShowPWCheckChanged(System.Windows.Forms.CheckBox checkbox, System.Windows.Forms.TextBox textbox)
        {
            if (checkbox.Checked)
            {
                textbox.UseSystemPasswordChar = false;
            }
            else
            {
                textbox.UseSystemPasswordChar = true;
            }
        }

    }
}
