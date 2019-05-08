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
            fillListbox("SELECT Nume FROM Medicamente");
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
            string text = comboBox_Upgrade.Text;
            if (name == "" || bucati == "" || data == "" || text == "")
                MessageBox.Show("Eroare! Nu ati completat spatiile!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
                try
                {
                    SqlConn.OpenConn();
                    byte[] images = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    images = binaryReader.ReadBytes((int)stream.Length);

                    string query = "";

                    if (text.Equals("Pastila"))
                    {
                        query = "INSERT INTO Medicamente(Nume, Buc, Pastila, Crema, Ceai, Spray, DataExpirarii, Imagine) VALUES('" + name + "', " + bucati + ", " + 1 + ", " + 0 + ", " + 0 + ", " + 0 + ", '" + data + "', @images)";
                    }
                    else if (text.Equals("Crema"))
                    {
                        query = "INSERT INTO Medicamente(Nume, Buc, Pastila, Crema, Ceai, Spray, DataExpirarii, Imagine) VALUES('" + name + "', " + bucati + ", " + 0 + ", " + 1 + ", " + 0 + ", " + 0 + ", '" + data + "', @images)";
                    }
                    else if (text.Equals("Ceai"))
                    {
                        query = "INSERT INTO Medicamente(Nume, Buc, Pastila, Crema, Ceai, Spray, DataExpirarii, Imagine) VALUES('" + name + "', " + bucati + ", " + 0 + ", " + 0 + ", " + 1 + ", " + 0 + ", '" + data + "', @images)";
                    }
                    else if (text.Equals("Spray"))
                    {
                        query = "INSERT INTO Medicamente(Nume, Buc, Pastila, Crema, Ceai, Spray, DataExpirarii, Imagine) VALUES('" + name + "', " + bucati + ", " + 0 + ", " + 0 + ", " + 0 + ", " + 1 + ", '" + data + "', @images)";
                    }
                    //MessageBox.Show("Eroare! Nu ati ales tipul medicamentului! \n " + text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                    SqlCommand command = SqlConn.connection.CreateCommand(); 
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@images", images));
                    command.ExecuteNonQuery();
                    

                    Nume_textBox_Upgrade.Text = "";
                    Bucati_textbox_Upgrade.Text = "";
                    Upgrade_dateTimePicker.Text = "";
                    comboBox_Upgrade.SelectedIndex = -1;
                    pictureBox_Add.Image = null;
                    pictureBox_Add.ImageLocation = "";
                    imgLocation = "";

                    fillListbox("SELECT Nume FROM Medicamente");

                    
                    SqlConn.CloseConn();
                }
                catch
                {
                    MessageBox.Show("Eroare! Nu ai ales poza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConn.OpenConn();
            
            SqlCommand command = SqlConn.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            if (listBox1.SelectedIndex == -1)
                listBox1.ClearSelected();
            else
            {
                command.CommandText = "SELECT * FROM Medicamente WHERE Nume = '" + listBox1.SelectedItem.ToString() + "'";
                command.ExecuteNonQuery();


                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow r in dataTable.Rows)
                {
                    Id_textBox.Text = r["Id"].ToString();
                    Nume_textBox.Text = r["Nume"].ToString();
                    Bucati_textBox.Text = r["Buc"].ToString();
                    dateTimePicker1.Text = r["DataExpirarii"].ToString();
                    pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])r["Imagine"]));
                    if (r["Pastila"].ToString().Equals("True"))
                    {
                        comboBox.SelectedIndex = 0;
                    }
                    else if (r["Crema"].ToString().Equals("True"))
                    {
                        comboBox.SelectedIndex = 1;
                    }
                    else if (r["Ceai"].ToString().Equals("True"))
                    {
                        comboBox.SelectedIndex = 2;
                    }
                    else
                    {
                        comboBox.SelectedIndex = 3;
                    }
                }

                Id_textBox.ReadOnly = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (DateTime.Compare(dateTimePicker1.Value.Date, DateTime.Now.Date) < 0)
                {
                    if (MessageBox.Show("Acest medicament a expirat! \nDoresti sa il stergi?", "Expirat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        deleteSelected();
                    }
                }
                else if (DateTime.Compare(dateTimePicker1.Value.Date, DateTime.Now.Date) == 0)
                {
                    MessageBox.Show("Acest medicament expira azi!", "Expirat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                SqlConn.CloseConn();
            }


            
        }

        private void Upgrade_button_Click(object sender, EventArgs e)
        {
            
            if (Id_textBox.Text == "" || Nume_textBox.Text == "" || Bucati_textBox.Text == "" || dateTimePicker1.Text == "")
                MessageBox.Show("Eroare! Minim un camp este gol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlConn.OpenConn();
                int id = Int32.Parse(Id_textBox.Text);
                string name = Nume_textBox.Text;
                string bucati = Bucati_textBox.Text;
                string data = dateTimePicker1.Text;
                string text = comboBox.Text;
                string query = "";
                
                if (text.Equals("Pastila"))
                {
                    query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 1 + ", Crema = " + 0 + ", Ceai = " + 0 + ", Spray = " + 0 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                    
                }
                else if (text.Equals("Crema"))
                {
                    query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 0 + ", Crema = " + 1 + ", Ceai = " + 0 + ", Spray = " + 0 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                }
                else if (text.Equals("Ceai"))
                {
                    query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 0 + ", Crema = " + 0 + ", Ceai = " + 1 + ", Spray = " + 0 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                }
                else
                {
                    query = "UPDATE Medicamente SET Nume = '" + name + "', Buc = '" + bucati + "', Pastila = " + 0 + ", Crema = " + 0 + ", Ceai = " + 0 + ", Spray = " + 1 + ", DataExpirarii = '" + data + "' WHERE Id =" + id;
                }

                SqlCommand command = SqlConn.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();
                SqlConn.CloseConn();

                Id_textBox.Text = "";
                Nume_textBox.Text = "";
                Bucati_textBox.Text = "";
                dateTimePicker1.Text = "";
                comboBox.SelectedIndex = -1;
                pictureBox1.Image = null;
                pictureBox1.ImageLocation = "";
                imgLocation = "";

                fillListbox("SELECT Nume FROM Medicamente");


                SqlConn.CloseConn();
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
                fillListbox("SELECT Nume FROM Medicamente");
            }
            else
            {
                string query = "SELECT * FROM Medicamente WHERE Nume LIKE '" + Filtru_textBox.Text + "%'";
                
                fillListbox(query);
            }

        }

        private void deleteSelected()
        {
            SqlConn.OpenConn();
            int id = Int32.Parse(Id_textBox.Text);
            string query = "DELETE FROM Medicamente WHERE Id =" + id;

            SqlCommand command = SqlConn.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();

            SqlConn.CloseConn();

            Id_textBox.Text = "";
            Nume_textBox.Text = "";
            Bucati_textBox.Text = "";
            dateTimePicker1.Text = "";
            comboBox.SelectedIndex = -1;
            pictureBox1.Image = null; 

            fillListbox("SELECT Nume FROM Medicamente");
        }

        private void fillListbox(string query)
        {

            listBox1.Items.Clear();
            SqlConn.OpenConn();
            SqlCommand command = SqlConn.connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                listBox1.Items.Add(r["Nume"].ToString());
            }
            
            SqlConn.CloseConn();
        }

        private void Bucati_textbox_Upgrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Bucati_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SortareAlfabetica_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
            {
                if (SortareAlfabetica_CheckBox.Checked == true)
                    fillListbox("SELECT Nume FROM Medicamente ORDER BY Nume");
                else
                    fillListbox("SELECT Nume FROM Medicamente");
            }
            else
            {
                if (SortareAlfabetica_CheckBox.Checked == true)
                    fillListbox("SELECT * FROM Medicamente WHERE Nume LIKE '" + Filtru_textBox.Text + "%' ORDER BY Nume");
                else
                    fillListbox("SELECT * FROM Medicamente WHERE Nume LIKE '" + Filtru_textBox.Text + "%'");
            }

            Id_textBox.ReadOnly = true;
        }
    }   
}
