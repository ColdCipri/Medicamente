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
            Delete_button.Enabled = false;
            Upgrade_button.Enabled = false;
        }
        

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (this.listBoxMedicamente.SelectedIndex >= 0)
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
            string name = Nume_Upgrade_textBox.Text;
            string bucati = Bucati_Upgrade_textBox.Text;
            string data = DataExpirarii_Upgrade_Picker.Text;
            string text = Tip_Upgrade_comboBox.Text;
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
                    

                    Nume_Upgrade_textBox.Text = "";
                    Bucati_Upgrade_textBox.Text = "";
                    DataExpirarii_Upgrade_Picker.Text = "";
                    Tip_Upgrade_comboBox.SelectedIndex = -1;
                    Imagine_Upgrade_pictureBox.Image = null;
                    Imagine_Upgrade_pictureBox.ImageLocation = "";
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
            if (listBoxMedicamente.SelectedIndex == -1)
            {
                listBoxMedicamente.ClearSelected();
                Delete_button.Enabled = false;
                Upgrade_button.Enabled = false;
            }
            else
            {
                command.CommandText = "SELECT * FROM Medicamente WHERE Nume = '" + listBoxMedicamente.SelectedItem.ToString() + "'";
                command.ExecuteNonQuery();


                Delete_button.Enabled = true;
                Upgrade_button.Enabled = true;

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow r in dataTable.Rows)
                {
                    Id_textBox.Text = r["Id"].ToString();
                    Nume_textBox.Text = r["Nume"].ToString();
                    Bucati_textBox.Text = r["Buc"].ToString();
                    DataExpirarii_Picker.Text = r["DataExpirarii"].ToString();
                    Imagine_pictureBox.Image = Image.FromStream(new MemoryStream((byte[])r["Imagine"]));
                    if (r["Pastila"].ToString().Equals("True"))
                    {
                        Tip_comboBox.SelectedIndex = 0;
                    }
                    else if (r["Crema"].ToString().Equals("True"))
                    {
                        Tip_comboBox.SelectedIndex = 1;
                    }
                    else if (r["Ceai"].ToString().Equals("True"))
                    {
                        Tip_comboBox.SelectedIndex = 2;
                    }
                    else
                    {
                        Tip_comboBox.SelectedIndex = 3;
                    }
                }

                Id_textBox.ReadOnly = true;
                Imagine_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                if (DateTime.Compare(DataExpirarii_Picker.Value.Date, DateTime.Now.Date) < 0)
                {
                    if (MessageBox.Show("Acest medicament a expirat! \nDoresti sa il stergi?", "Expirat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        deleteSelected();
                    }
                }
                else if (DateTime.Compare(DataExpirarii_Picker.Value.Date, DateTime.Now.Date) == 0)
                {
                    MessageBox.Show("Acest medicament expira azi!", "Expirat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                SqlConn.CloseConn();
            }


            
        }

        private void Upgrade_button_Click(object sender, EventArgs e)
        {
            
            if (Id_textBox.Text == "" || Nume_textBox.Text == "" || Bucati_textBox.Text == "" || DataExpirarii_Picker.Text == "")
                MessageBox.Show("Eroare! Minim un camp este gol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlConn.OpenConn();
                int id = Int32.Parse(Id_textBox.Text);
                string name = Nume_textBox.Text;
                string bucati = Bucati_textBox.Text;
                string data = DataExpirarii_Picker.Text;
                string text = Tip_comboBox.Text;
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
                DataExpirarii_Picker.Text = "";
                Tip_comboBox.SelectedIndex = -1;
                Imagine_pictureBox.Image = null;
                Imagine_pictureBox.ImageLocation = "";
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
                Imagine_Upgrade_pictureBox.ImageLocation = imgLocation;
                Imagine_Upgrade_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            DataExpirarii_Picker.Text = "";
            Tip_comboBox.SelectedIndex = -1;
            Imagine_pictureBox.Image = null; 

            fillListbox("SELECT Nume FROM Medicamente");
        }

        private void fillListbox(string query)
        {

            listBoxMedicamente.Items.Clear();
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
                listBoxMedicamente.Items.Add(r["Nume"].ToString());
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

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > listBoxMedicamente.ItemHeight*listBoxMedicamente.Items.Count){
                listBoxMedicamente.SelectedItems.Clear();
                Nume_textBox.Text = "";
                Bucati_textBox.Text = "";
                DataExpirarii_Picker.Text = "";
                Tip_comboBox.SelectedIndex = -1;
                Imagine_pictureBox.Image = null;
            }
        }
    }   
}
