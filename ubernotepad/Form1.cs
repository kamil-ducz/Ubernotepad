using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ubernotepad
{
    public partial class MainForm : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents | *.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            mainTextBox.Text = await sr.ReadToEndAsync();//use async - wait till awaited tasc completes
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mainTextBox.Text);
        }

        private void cleanWholeCodeBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = null;
        }



        private async void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents | *.txt", Multiselect = false, ValidateNames = true })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            mainTextBox.Text = await sr.ReadToEndAsync();//use async - wait till awaited tasc completes
                        }
                        filePath.Text = ofd.FileName;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath.Text))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save text file";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                    {
                        sw.Write(mainTextBox.Text);
                    }
                    filePath.Text = saveFileDialog1.FileName;
                }
            }
            else
            {
                File.WriteAllText(filePath.Text, mainTextBox.Text);
            }
        }

        private void customSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save an text File";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(mainTextBox.Text);
                }
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;
        }

        private void radioMagnolia_CheckedChanged_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
        }

        private void radioDefault_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCoral;
        }

        private void radioDefault_CheckedChanged_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents | *.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            mainTextBox.Text = await sr.ReadToEndAsync();//use async - wait till awaited tasc completes
                        }
                        filePath.Text = ofd.FileName;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath.Text))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save an text File";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                    {
                        sw.Write(mainTextBox.Text);
                    }
                }
            }
            else
            {
                File.WriteAllText(filePath.Text, mainTextBox.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save an text File";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(mainTextBox.Text);
                }
            }
        }

        private void defaultFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = mainTextBox.Font.Size;
            currentSize = 8.0F;
            mainTextBox.Font = new Font(mainTextBox.Font.Name, currentSize,
            mainTextBox.Font.Style, mainTextBox.Font.Unit);
        }

        private void increaseFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = mainTextBox.Font.Size;
            currentSize += 2.0F;
            mainTextBox.Font = new Font(mainTextBox.Font.Name, currentSize,
            mainTextBox.Font.Style, mainTextBox.Font.Unit);
        }

        private void decreaseFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = mainTextBox.Font.Size;
            currentSize -= 2.0F;
            mainTextBox.Font = new Font(mainTextBox.Font.Name, currentSize,
            mainTextBox.Font.Style, mainTextBox.Font.Unit);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ubernotepad. Kamil Duczakowski. Freeware version. Enjoy!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ubernotepad. Kamil Duczakowski. Freeware version. Enjoy!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {

        }

        private void showRecord_Click(object sender, EventArgs e)
        {            
            sda = new SqlDataAdapter(@"SELECT * FROM Products", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void showRecord2_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Orders", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
