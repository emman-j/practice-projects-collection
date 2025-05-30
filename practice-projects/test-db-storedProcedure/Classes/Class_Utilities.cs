using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Database;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public static class DatagridViewManager
    {
        public static List<DataGridViewCell> matchingCells = new List<DataGridViewCell>();
        public static int currentCellIndex = -1;
        public static void SearchDataGridView(DataGridView dataGridView, string searchText)
        {
            ////Clear previous matching cells and highlights
            matchingCells.Clear();
            currentCellIndex = -1;

            // Remove any previous highlights
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Reset background color
                }
            }

            // Check if searchText is not empty
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return;
            }

            // Loop through the rows and cells to find the matching text
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Highlight the matching cell
                        cell.Style.BackColor = Color.Yellow; // You can change the color as needed
                        matchingCells.Add(cell); // Collect matching cells
                    }
                }
            }
        }
        public static void FindNextMatch(DataGridView dataGridView)
        {
            if (matchingCells.Count == 0)
            {
                MessageBox.Show("No matches found.");
                return;
            }

            // Move to the next matching cell
            currentCellIndex = (currentCellIndex + 1) % matchingCells.Count;

            // Get the next matching cell
            DataGridViewCell cell = matchingCells[currentCellIndex];

            // Focus on the cell
            dataGridView.ClearSelection();
            cell.DataGridView.CurrentCell = cell;
            cell.DataGridView.FirstDisplayedScrollingRowIndex = cell.RowIndex;
            cell.Selected = true; // Highlight the current matching cell
        }
        public static void DataGridViewFormatting(DataGridView dataGridView)
        {
            dataGridView.CellFormatting += DataGridView_CellFormatting;
        }
        private static async void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView.Columns[e.ColumnIndex].Name == "Priority")
            {
                if (e.Value != null)
                {
                    switch (e.Value.ToString().ToLower())
                    {
                        case "high":
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.BackColor = Color.LightPink;
                            break;
                        case "medium":
                            e.CellStyle.ForeColor = Color.Orange;
                            e.CellStyle.BackColor = Color.LightYellow;
                            break;
                        case "low":
                            e.CellStyle.ForeColor = Color.Green;
                            e.CellStyle.BackColor = Color.LightGreen;
                            break;
                        default:
                            e.CellStyle.ForeColor = SystemColors.ControlDarkDark;
                            e.CellStyle.BackColor = Color.White;
                            break;
                    }
                }
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    switch (e.Value.ToString().ToLower())
                    {
                        case "done":
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case "open":
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.BackColor = Color.LightPink;
                            break;
                        case "on-going":
                            e.CellStyle.ForeColor = Color.Green;
                            e.CellStyle.BackColor = Color.LightGreen;
                            break;
                        case "paused":
                            e.CellStyle.ForeColor = Color.DarkOrange;
                            e.CellStyle.BackColor = Color.LightYellow;
                            break;
                        default:
                            e.CellStyle.ForeColor = SystemColors.ControlDarkDark;
                            break;
                    }
                }
            }
            Application.DoEvents();
            await Task.Delay(50);
        }
        public static void ResetDataGridView(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }
    }
    public class TextManager
    {
        public static void TextFormatting(System.Windows.Forms.Control control)
        {
            string controltext = control.Text.ToLower();
            switch (controltext)
            {
                case "done":
                    control.ForeColor = SystemColors.ControlDarkDark;
                    control.BackColor = SystemColors.AppWorkspace;
                    break;
                case "open":
                    control.ForeColor = Color.Red;
                    control.BackColor = Color.LightPink;
                    break;
                case "paused":
                    control.ForeColor = Color.DarkOrange;
                    control.BackColor = Color.LightYellow;
                    break;
                case "on-going":
                    control.ForeColor = Color.Green;
                    control.BackColor = Color.LightGreen;
                    break;
                case "high":
                    control.ForeColor = Color.Red;
                    control.BackColor = Color.LightPink;
                    break;
                case "medium":
                    control.ForeColor = Color.Orange;
                    control.BackColor = Color.LightYellow;
                    break;
                case "low":
                    control.ForeColor = Color.Green;
                    control.BackColor = Color.LightGreen;
                    break;
                default: break;
            }
        }
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
        public static void HighlightRichTextBox(System.Windows.Forms.RichTextBox richTextBox, Color fontColor)
        {
            string timestampPattern = @"\d{2}/\d{2}/\d{2,4} \d{2}:\d{2}:\d{2}";
            string remarksPattern = @"\bRemarks\b";
            string remarksPattern2 = @"\bChanged\b";

            string combinedPattern = $"{timestampPattern}|{remarksPattern}|{remarksPattern2}";

            MatchCollection matches = Regex.Matches(richTextBox.Text, combinedPattern);

            foreach (Match match in matches)
            {
                richTextBox.Select(match.Index, match.Length);
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
                richTextBox.SelectionColor = fontColor;
            }

            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.SelectionLength = 0;
        }
    }
    public class Base64Converter
    {
        public static string EncodeToBase64(string input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodeFromBase64(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}

