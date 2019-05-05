using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicamente
{
    public partial class Form1 : Form
    {
        string imgLocation = "";
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            this.Text = SqlConn.myApp();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConn.sqlQuery = "SELECT * FROM Medicamente";
            SqlConn.OpenConn();
            SqlConn.command = new SqlCommand(SqlConn.sqlQuery, SqlConn.connection);

            SqlConn.dataAdapter = new SqlDataAdapter(SqlConn.command);
            SqlConn.dataSet = new DataSet();
            SqlConn.bindingSource = new BindingSource();
            SqlConn.dataAdapter.Fill(SqlConn.dataSet, "Medicamente");


            foreach (DataRow r in SqlConn.dataSet.Tables["Medicamente"].Rows)
            {
                listBox1.Items.Add(r["Nume"].ToString());
            }
            listBox1.ValueMember = "Id";
            

            SqlConn.bindingSource.DataSource = SqlConn.dataSet.Tables["Medicamente"];

            Id_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Id");
            Nume_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Nume");
            Bucati_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Buc");
            dateTimePicker1.DataBindings.Add("Text", SqlConn.bindingSource, "DataExpirarii");
            pictureBox1.DataBindings.Add("Image", SqlConn.bindingSource, "Imagine", true);
            

            if (SqlConn.dataSet.Tables["Medicamente"].Rows[0]["Pastila"].Equals(true))
            {
                comboBox.SelectedIndex = 0;
            }
            else if(SqlConn.dataSet.Tables["Medicamente"].Rows[0]["Crema"].Equals(true))
            {
                comboBox.SelectedIndex = 1;
            }
            else if (SqlConn.dataSet.Tables["Medicamente"].Rows[0]["Ceai"].Equals(true))
            {
                comboBox.SelectedIndex = 2;
            }
            else 
            {
                comboBox.SelectedIndex = 3;
            }
            

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Id_textBox.ReadOnly = true;
            listBox1.SelectedIndex = 0;
            comboBox_Upgrade.SelectedIndex = 0;
            
        }
        

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                int id = Int32.Parse(Id_textBox.Text);
                string query = "DELETE FROM Medicamente WHERE Id =" + id;

                SqlCommand command = new SqlCommand(query, SqlConn.connection);
                command.ExecuteNonQuery();
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                
            }
            else
                MessageBox.Show("Eroare! Nu sunt medicamente introduse!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            Form1 childForm = new Form1();
            this.Hide();
            childForm.Closed += (s, args) => this.Close();
            childForm.ShowDialog();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string name = Nume_textBox_Upgrade.Text;
            string bucati = Bucati_textbox_Upgrade.Text;
            
            string data = Upgrade_dateTimePicker.Text;

            if (name == "" || bucati == "" || data == "")
                MessageBox.Show("Eroare! Nu ati completat spatiile!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
                try
                {
                    byte[] images = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    images = binaryReader.ReadBytes((int)stream.Length);

                    string query = "INSERT INTO Medicamente(Nume, Buc, DataExpirarii, Imagine) " +
                               "Values('" + name + "', '" + bucati + "', '" + data + "', @images)";

                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.Parameters.Add(new SqlParameter("@images", images));

                    command.ExecuteNonQuery();
                    //Update
                    Form1 childForm = new Form1();
                    this.Hide();
                    childForm.Closed += (s, args) => this.Close();
                    childForm.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Eroare! Nu ai ales poza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SqlConn.bindingSource != null)
            {
                SqlConn.bindingSource.Position = listBox1.SelectedIndex;

                try
                {
                    if (SqlConn.dataSet.Tables["Medicamente"].Rows[listBox1.SelectedIndex]["Pastila"].Equals(true))
                    {
                        comboBox.SelectedIndex = 0;
                    }
                    else if (SqlConn.dataSet.Tables["Medicamente"].Rows[listBox1.SelectedIndex]["Crema"].Equals(true))
                    {
                        comboBox.SelectedIndex = 1;
                    }
                    else if (SqlConn.dataSet.Tables["Medicamente"].Rows[listBox1.SelectedIndex]["Ceai"].Equals(true))
                    {
                        comboBox.SelectedIndex = 2;
                    }
                    else
                    {
                        comboBox.SelectedIndex = 3;
                    }
                    
                }
                catch
                {
                    //Update
                    Form1 childForm = new Form1();
                    this.Hide();
                    childForm.Closed += (s, args) => this.Close();
                    childForm.ShowDialog();
                }
                DateTime today = DateTime.Today;
                if (DateTime.Compare(dateTimePicker1.Value.Date, today) < 0)
                {
                    MessageBox.Show("Atentie! Acest medicament a expirat!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void Upgrade_button_Click(object sender, EventArgs e)
        {
            if (Id_textBox.Text == "" || Nume_textBox.Text == "" || Bucati_textBox.Text == "" || dateTimePicker1.Text == "")
                MessageBox.Show("Eroare! Minim un camp este gol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Int32.Parse(Id_textBox.Text);
                string name = Nume_textBox.Text;
                string bucati = Bucati_textBox.Text;
                string data = dateTimePicker1.Text;
                string text = comboBox.Text;

                if (text.Equals("Pastila"))
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }
                else if (text.Equals("Crema"))
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = '" + false + "', Crema = '" + true + "', DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }
                else if (text.Equals("Ceai"))
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = '" + false + "', Ceai = '" + true + "', DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = '" + false + "', Spray = '" + true + "', DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }

                //Update
                Form1 childForm = new Form1();
                this.Hide();
                childForm.Closed += (s, args) => this.Close();
                childForm.ShowDialog();
            }
            
        }

        private void Upload_button_Upgrade_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox_Add.ImageLocation = imgLocation;
                pictureBox_Add.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConn.CloseConn();
        }

        private void Filtru_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Filtru_textBox.Text.ToString().Equals(""))
            {

                listBox1.DataSource = null;
                listBox1.Items.Clear();

                foreach (DataRow r in SqlConn.dataSet.Tables["Medicamente"].Rows)
                {
                    listBox1.Items.Add(r["Nume"].ToString());

                }
                listBox1.ValueMember = "Id";
            }
            else
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();

                string query = "SELECT * FROM Medicamente WHERE Nume LIKE '" + Filtru_textBox.Text + "%'";

                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SqlConn.connection);

                dataAdapter.Fill(table);
                listBox1.DataSource = table;
                listBox1.DisplayMember = "Nume";
            }

        }
    }   
}
