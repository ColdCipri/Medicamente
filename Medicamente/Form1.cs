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

            fillListbox(SqlConn.dataSet);
            
            //SqlConn.bindingSource.DataSource = SqlConn.dataSet.Tables["Medicamente"];

            //Id_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Id");
            //Nume_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Nume");
            //Bucati_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Buc");
            //dateTimePicker1.DataBindings.Add("Text", SqlConn.bindingSource, "DataExpirarii");
            //pictureBox1.DataBindings.Add("Image", SqlConn.bindingSource, "Imagine", true);
            

            //if (SqlConn.dataSet.Tables["Medicamente"].Rows[0]["Pastila"].Equals(true))
            //{
            //    comboBox.SelectedIndex = 0;
            //}
            //else if(SqlConn.dataSet.Tables["Medicamente"].Rows[0]["Crema"].Equals(true))
            //{
            //    comboBox.SelectedIndex = 1;
            //}
            //else if (SqlConn.dataSet.Tables["Medicamente"].Rows[0]["Ceai"].Equals(true))
            //{
            //    comboBox.SelectedIndex = 2;
            //}
            //else 
            //{
            //    comboBox.SelectedIndex = 3;
            //}
            

            //Id_textBox.ReadOnly = true;
            //listBox1.SelectedIndex = 0;
            //comboBox_Upgrade.SelectedIndex = 0;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //listBox1.Sorted = true;
            
        }
        

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                deleteSelected();                
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
            //if (SqlConn.bindingSource != null)
            //{
            //    SqlConn.bindingSource.Position = listBox1.SelectedIndex;//HERE IS THE PROBLEM

            //    try
            //    {
            //        if (SqlConn.dataSet.Tables["Medicamente"].Rows[SqlConn.bindingSource.Position]["Pastila"].Equals(true))
            //        {
            //            comboBox.SelectedIndex = 0;
            //        }
            //        else if (SqlConn.dataSet.Tables["Medicamente"].Rows[SqlConn.bindingSource.Position]["Crema"].Equals(true))
            //        {
            //            comboBox.SelectedIndex = 1;
            //        }
            //        else if (SqlConn.dataSet.Tables["Medicamente"].Rows[SqlConn.bindingSource.Position]["Ceai"].Equals(true))
            //        {
            //            comboBox.SelectedIndex = 2;
            //        }
            //        else
            //        {
            //            comboBox.SelectedIndex = 3;
            //        }

            //    }
            //    catch
            //    {
            //        //Update
            //        Form1 childForm = new Form1();
            //        this.Hide();
            //        childForm.Closed += (s, args) => this.Close();
            //        childForm.ShowDialog();
            //    }
            //    DateTime today = DateTime.Today;
            //    if (DateTime.Compare(dateTimePicker1.Value.Date, today) < 0)
            //    {
            //        string text = "Atentie! Acest medicament a expirat! \nDoresti sa il sterg?";
            //        DialogResult dialogResult = MessageBox.Show(text, "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            deleteSelected();
            //        }

            //    }

            //}

            string sqlQuery = "SELECT * FROM Medicamente WHERE Nume='" + listBox1.SelectedItem +"'";//you left here

            SqlCommand command = new SqlCommand(sqlQuery, SqlConn.connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            BindingSource bindingSource = new BindingSource();
            dataAdapter.Fill(dataSet, "Medicamente");

            fillListbox(dataSet);

            bindingSource.DataSource = dataSet.Tables["Medicamente"];

            Id_textBox.DataBindings.Clear();
            Nume_textBox.DataBindings.Clear();
            Bucati_textBox.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            pictureBox1.DataBindings.Clear();

            Id_textBox.DataBindings.Add("Text", bindingSource, "Id");
            Nume_textBox.DataBindings.Add("Text", bindingSource, "Nume");
            Bucati_textBox.DataBindings.Add("Text", bindingSource, "Buc");
            dateTimePicker1.DataBindings.Add("Text", bindingSource, "DataExpirarii");
            pictureBox1.DataBindings.Add("Image", bindingSource, "Imagine", true);


            if (dataSet.Tables["Medicamente"].Rows[bindingSource.Position]["Pastila"].Equals(true))
            {
                comboBox.SelectedIndex = 0;
            }
            else if (dataSet.Tables["Medicamente"].Rows[bindingSource.Position]["Crema"].Equals(true))
            {
                comboBox.SelectedIndex = 1;
            }
            else if (dataSet.Tables["Medicamente"].Rows[bindingSource.Position]["Ceai"].Equals(true))
            {
                comboBox.SelectedIndex = 2;
            }
            else 
            {
                comboBox.SelectedIndex = 3;
            }

            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 1 + ", Crema = " + 0 + ", Ceai = " + 0 + ", Spray = " + 0 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }
                else if (text.Equals("Crema"))
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 0 + ", Crema = " + 1 + ", Ceai = " + 0 + ", Spray = " + 0 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }
                else if (text.Equals("Ceai"))
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 0 + ", Crema = " + 0 + ", Ceai = " + 1 + ", Spray = " + 0 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                    SqlCommand command = new SqlCommand(query, SqlConn.connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 0 + ", Crema = " + 0 + ", Ceai = " + 0 + ", Spray = " + 1 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
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
            if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
            {

                fillListbox(SqlConn.dataSet);
            }
            else
            {

                string query = "SELECT * FROM Medicamente WHERE Nume LIKE '" + Filtru_textBox.Text + "%'";

                SqlCommand command = new SqlCommand(query , SqlConn.connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Medicamente");

                fillListbox(dataSet);
            }

        }

        private void deleteSelected()
        {
            int id = Int32.Parse(Id_textBox.Text);
            string query = "DELETE FROM Medicamente WHERE Id =" + id;

            SqlCommand command = new SqlCommand(query, SqlConn.connection);
            command.ExecuteNonQuery();
            this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
        }

        private void fillListbox(DataSet dataSet)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (DataRow r in dataSet.Tables["Medicamente"].Rows)
            {
                listBox1.Items.Add(r["Nume"].ToString());
                //Id_textBox.Text = r["Id"].ToString();
                //Nume_textBox.Text = r["Nume"].ToString();
                //Bucati_textBox.Text = r["Buc"].ToString();
                //dateTimePicker1.Text = r["DataExpirarii"].ToString();
                //pictureBox1.Image = r["Imagine"];
                //Id_textBox.ReadOnly = true;

                //Id_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Id");
                //Nume_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Nume");
                //Bucati_textBox.DataBindings.Add("Text", SqlConn.bindingSource, "Buc");
                //dateTimePicker1.DataBindings.Add("Text", SqlConn.bindingSource, "DataExpirarii");
                //pictureBox1.DataBindings.Add("Image", SqlConn.bindingSource, "Imagine", true);
            }
            listBox1.ValueMember = "Id";
        }
    }   
}
