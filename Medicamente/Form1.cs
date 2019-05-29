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
        string selectName = "SELECT ID, Nume FROM Medicamente";
        string filterData = " DataExpirarii < (select GETDATE())";
        string orderName = " ORDER BY Nume";
        string insertString = "INSERT INTO Medicamente(Nume, Buc, Tip, DataExpirarii, Imagine, SubstantaBaza, SubstBazaCantitate, Descriere)";
        string deleteString = "DELETE FROM Medicamente";
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
            this.Text = SqlConn.myApp();
        }

        //_____________________Code for filling listbox when app is loaded___________________________________________________

        private void Form1_Load(object sender, EventArgs e)
        {
            fillListbox(selectName);
            Delete_button.Enabled = false;
        }


        //_____________________END OF Code for filling listbox when app is loaded____________________________________________


        //_____________________Code for update textboxes by listbox selected item____________________________________________

        private void listBoxMedicamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConn.OpenConn();

            SqlCommand command = SqlConn.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            if (listBoxMedicamente.SelectedIndex == -1)
            {
                listBoxMedicamente.ClearSelected();
                Delete_button.Enabled = false;
                Update_button.Text = "Adauga";
            }
            else
            {
                if (Update_button.Text.Equals("Adauga"))
                {
                    Update_button.Text = "Actualizare";
                }
                command.CommandText = "SELECT * FROM Medicamente WHERE ID = '" + listBoxMedicamente.SelectedItem.ToString().Substring(0, listBoxMedicamente.SelectedItem.ToString().IndexOf(" ")) + "'";
                command.ExecuteNonQuery();


                Delete_button.Enabled = true;

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow r in dataTable.Rows)
                {
                    Id_label.Text = r["Id"].ToString();
                    Nume_textBox.Text = r["Nume"].ToString();
                    Bucati_textBox.Text = r["Buc"].ToString();
                    DataExpirarii_Picker.Text = r["DataExpirarii"].ToString();
                    SubstantaBaza_textBox.Text = r["SubstantaBaza"].ToString();
                    SubstBazaCantitate_textBox.Text = r["SubstBazaCantitate"].ToString();
                    Descriere_textBox.Text = r["Descriere"].ToString();
                    try
                    {
                        Imagine_pictureBox.Image = Image.FromStream(new MemoryStream((byte[])r["Imagine"]));
                    }
                    catch
                    {
                        Imagine_pictureBox.Image = null;
                    }

                    if (r["Tip"].ToString().Equals("Pastila"))
                    {
                        Tip_comboBox.SelectedIndex = 0;
                    }
                    else if (r["Tip"].ToString().Equals("Crema"))
                    {
                        Tip_comboBox.SelectedIndex = 1;
                    }
                    else if (r["Tip"].ToString().Equals("Ceai"))
                    {
                        Tip_comboBox.SelectedIndex = 2;
                    }
                    else if (r["Tip"].ToString().Equals("Spray"))
                    {
                        Tip_comboBox.SelectedIndex = 3;
                    }
                    else if (r["Tip"].ToString().Equals("Sirop"))
                    {
                        Tip_comboBox.SelectedIndex = 4;
                    }
                    else if (r["Tip"].ToString().Equals("Supozitor"))
                    {
                        Tip_comboBox.SelectedIndex = 5;
                    }
                    else if (r["Tip"].ToString().Equals("Picaturi"))
                    {
                        Tip_comboBox.SelectedIndex = 6;
                    }
                    else if (r["Tip"].ToString().Equals("Gel"))
                    {
                        Tip_comboBox.SelectedIndex = 7;
                    }
                    else if (r["Tip"].ToString().Equals("Efervescent"))
                    {
                        Tip_comboBox.SelectedIndex = 8;
                    }
                    else
                    {
                        Tip_comboBox.SelectedIndex = 9;
                    }
                }
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


        //_____________________END OF Code for update textboxes by listbox selected item_____________________________________


        //___________________________________Code for Add/Upgrade button_____________________________________________________

        private void Upgrade_button_Click(object sender, EventArgs e)
        {

            if (Nume_textBox.Text == "" || Bucati_textBox.Text == "" || DataExpirarii_Picker.Text == "" || Tip_comboBox.SelectedIndex == -1 || SubstantaBaza_textBox.Text == "" || SubstBazaCantitate_textBox.Text == "")
                MessageBox.Show("Eroare! Cel putin un camp este gol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = Nume_textBox.Text;
                string bucati = Bucati_textBox.Text;
                string data = DataExpirarii_Picker.Text;
                string tip = Tip_comboBox.Text;
                string substBaza = SubstantaBaza_textBox.Text;
                string substBazaCantitate = SubstBazaCantitate_textBox.Text;
                string descriere = Descriere_textBox.Text;
                string query = "";

                if (Id_label.Text.Equals(""))
                {
                    try
                    {
                        SqlConn.OpenConn();
                        byte[] images = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(stream);
                        images = binaryReader.ReadBytes((int)stream.Length);

                        query = insertString + " VALUES(@name, @bucati, @tip, @data, @images, @substBaza, @substBazaCantitate, @descriere)";

                        SqlCommand command = SqlConn.connection.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;
                        command.Parameters.Add(new SqlParameter("@name", name));
                        command.Parameters.Add(new SqlParameter("@bucati", bucati));
                        command.Parameters.Add(new SqlParameter("@tip", tip));
                        command.Parameters.Add(new SqlParameter("@data", data));
                        command.Parameters.Add(new SqlParameter("@images", images));
                        command.Parameters.Add(new SqlParameter("@substBaza", substBaza));
                        command.Parameters.Add(new SqlParameter("@substBazaCantitate", substBazaCantitate));
                        command.Parameters.Add(new SqlParameter("@descriere", descriere));
                        command.ExecuteNonQuery();


                        Id_label.Text = "";
                        Nume_textBox.Text = "";
                        Bucati_textBox.Text = "";
                        DataExpirarii_Picker.Text = "";
                        Tip_comboBox.SelectedIndex = -1;
                        SubstantaBaza_textBox.Text = "";
                        SubstBazaCantitate_textBox.Text = "";
                        Descriere_textBox.Text = "";
                        Imagine_pictureBox.Image = null;
                        Imagine_pictureBox.ImageLocation = "";
                        imgLocation = "";

                        fillListbox(selectName);


                        SqlConn.CloseConn();
                    }
                    catch
                    {
                        MessageBox.Show("Eroare! Nu ai ales poza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    SqlConn.OpenConn();

                    int id = Int32.Parse(Id_label.Text);
                    try
                    {
                        byte[] images = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(stream);
                        images = binaryReader.ReadBytes((int)stream.Length);

                        query = "UPDATE Medicamente SET Nume = @name, Buc = @bucati, Tip = @tip, DataExpirarii = @data, Imagine = @images, SubstantaBaza = @substBaza, SubstBazaCantitate = @substBazaCantitate, Descriere = @descriere WHERE Id = @id";
                        SqlCommand command = SqlConn.connection.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;

                        command.Parameters.Add(new SqlParameter("@name", name));
                        command.Parameters.Add(new SqlParameter("@bucati", bucati));
                        command.Parameters.Add(new SqlParameter("@tip", tip));
                        command.Parameters.Add(new SqlParameter("@data", data));
                        command.Parameters.Add(new SqlParameter("@images", images));
                        command.Parameters.Add(new SqlParameter("@substBaza", substBaza));
                        command.Parameters.Add(new SqlParameter("@substBazaCantitate", substBazaCantitate));
                        command.Parameters.Add(new SqlParameter("@descriere", descriere));
                        command.Parameters.Add(new SqlParameter("@id", id));

                        command.ExecuteNonQuery();
                        SqlConn.CloseConn();
                    }
                    catch
                    {
                        query = "UPDATE Medicamente SET Nume = @name, Buc = @bucati, Tip = @tip, DataExpirarii = @data, SubstantaBaza = @substBaza, SubstBazaCantitate = @substBazaCantitate, Descriere = @descriere WHERE Id = @id";

                        SqlCommand command = SqlConn.connection.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;

                        command.Parameters.Add(new SqlParameter("@name", name));
                        command.Parameters.Add(new SqlParameter("@bucati", bucati));
                        command.Parameters.Add(new SqlParameter("@tip", tip));
                        command.Parameters.Add(new SqlParameter("@data", data));
                        command.Parameters.Add(new SqlParameter("@substBaza", substBaza));
                        command.Parameters.Add(new SqlParameter("@substBazaCantitate", substBazaCantitate));
                        command.Parameters.Add(new SqlParameter("@descriere", descriere));
                        command.Parameters.Add(new SqlParameter("@id", id));

                        command.ExecuteNonQuery();
                        SqlConn.CloseConn();
                    }
                    
                    Id_label.Text = "";
                    Nume_textBox.Text = "";
                    Bucati_textBox.Text = "";
                    DataExpirarii_Picker.Text = "";
                    Tip_comboBox.SelectedIndex = -1;
                    Imagine_pictureBox.Image = null;
                    Imagine_pictureBox.ImageLocation = "";
                    imgLocation = "";


                    Delete_button.Enabled = false;
                    Update_button.Text = "Adauga";

                    fillListbox(selectName);
                    
                }
            }
        }


        //____________________________END OF Code for Add/Upgrade button_____________________________________________________


        //_______________________________________Code for Delete button______________________________________________________

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (this.listBoxMedicamente.SelectedIndex >= 0)
            {
                deleteSelected();
            }
            else
            {
                MessageBox.Show("Eroare! Nu sunt medicamente introduse!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //_________________________________END OF Code for Delete button______________________________________________________


        //_______________________________________Code for Restart button______________________________________________________


        private void Restart_button_Click(object sender, EventArgs e)
        {
            Form1 childForm = new Form1();
            this.Hide();
            childForm.Closed += (s, args) => this.Close();
            childForm.ShowDialog();
        }


        //________________________________END OF Code for Restart button______________________________________________________


        //________________________________Code for Upload picture button______________________________________________________

        private void Upload_button_Upgrade_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                Imagine_pictureBox.ImageLocation = imgLocation;
                Imagine_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //________________________________END OF Code for Upload picture button_________________________________________________


        //________________________________Code for filter textbox_______________________________________________________________

        private void Filtru_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Filtru_comboBox.SelectedIndex == -1 || Filtru_comboBox.SelectedIndex == 0)
            {

                if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
                {
                    fillListbox(selectName);
                }
                else
                {
                    string filterName = "Nume LIKE '" + Filtru_textBox.Text + "%'";

                    fillListbox(selectName + " WHERE " + filterName);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
                {
                    fillListbox(selectName);
                }
                else
                {
                    fillListbox(selectName + " WHERE " + "Descriere LIKE '%" + Filtru_textBox.Text + "%'");
                }
            }

        }

        //________________________________END OF Code for filter textbox________________________________________________________


        //________________________________Code for numbers input only___________________________________________________________

        private void Bucati_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void SubstBazaCantitate_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //________________________________END OF Code for numbers input only____________________________________________________


        //________________________________Code for alphabetic sort of listbox___________________________________________________

        private void SortareAlfabetica_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtru_comboBox.SelectedIndex == -1 || Filtru_comboBox.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
                {
                    if (SortareAlfabetica_CheckBox.Checked == true)
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + orderName);
                        }
                    }
                    else
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterData);
                        }
                        else
                        {
                            fillListbox(selectName);
                        }
                    }
                }
                else
                {
                    string filterName = "Nume LIKE '" + Filtru_textBox.Text + "%'";
                    if (SortareAlfabetica_CheckBox.Checked == true)
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterName + " AND " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterName + orderName);
                        }
                    }
                    else
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterName + " AND " + filterData);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterName);
                        }
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
                {
                    if (SortareAlfabetica_CheckBox.Checked == true)
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + orderName);
                        }
                    }
                    else
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterData);
                        }
                        else
                        {
                            fillListbox(selectName);
                        }
                    }
                }
                else
                {
                    string filterDescribe = "Descriere LIKE '%" + Filtru_textBox.Text + "%'";
                    if (SortareAlfabetica_CheckBox.Checked == true)
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe + " AND " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe + orderName);
                        }
                    }
                    else
                    {
                        if (MedicamenteExpirate_checkBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe + " AND " + filterData);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe);
                        }
                    }
                }
            }
        }

        //________________________________END OF Code for alphabetic sort of listbox____________________________________________


        //________________________________Code for reset selecte item from listbox_______________________________________________

        private void listBoxMedicamente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > listBoxMedicamente.ItemHeight * listBoxMedicamente.Items.Count)
            {
                listBoxMedicamente.SelectedItems.Clear();

                Id_label.Text = "";
                Nume_textBox.Text = "";
                Bucati_textBox.Text = "";
                DataExpirarii_Picker.Text = "";
                SubstantaBaza_textBox.Text = "";
                SubstBazaCantitate_textBox.Text = "";
                Descriere_textBox.Text = "";
                Tip_comboBox.SelectedIndex = -1;

                Imagine_pictureBox.Image = null;
                if (Update_button.Text.Equals("Adauga"))
                {
                    Update_button.Text = "Actualizare";
                }

                Filtru_comboBox.SelectedIndex = -1;
            }
        }

        //________________________________END OF Code for reset selecte item from listbox________________________________________


        //________________________________Code for filter by last date from listbox______________________________________________

        private void MedicamenteExpirate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtru_comboBox.SelectedIndex == -1 || Filtru_comboBox.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
                {
                    if (MedicamenteExpirate_checkBox.Checked == true)
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterData);
                        }
                    }
                    else
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + orderName);
                        }
                        else
                        {
                            fillListbox(selectName);
                        }
                    }
                }
                else
                {
                    string filterName = "Nume LIKE '" + Filtru_textBox.Text + "%'";
                    if (MedicamenteExpirate_checkBox.Checked == true)
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterName + " AND " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterName + " AND " + filterData);
                        }
                    }
                    else
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterName + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterName);
                        }
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(Filtru_textBox.Text) || String.IsNullOrWhiteSpace(Filtru_textBox.Text))
                {
                    if (MedicamenteExpirate_checkBox.Checked == true)
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterData);
                        }
                    }
                    else
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + orderName);
                        }
                        else
                        {
                            fillListbox(selectName);
                        }
                    }
                }
                else
                {
                    string filterDescribe = "Descriere LIKE '%" + Filtru_textBox.Text + "%'";
                    if (MedicamenteExpirate_checkBox.Checked == true)
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe + " AND " + filterData + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe + " AND " + filterData);
                        }
                    }
                    else
                    {
                        if (SortareAlfabetica_CheckBox.Checked == true)
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe + orderName);
                        }
                        else
                        {
                            fillListbox(selectName + " WHERE " + filterDescribe);
                        }
                    }
                }
            }
        }

        //________________________________END OF Code for filter by last date from listbox_______________________________________


        //________________________________Function for delete selecte item from listbox___________________________________________

        private void deleteSelected()
        {
            SqlConn.OpenConn();
            int id = Int32.Parse(Id_label.Text);
            string query = deleteString + " WHERE Id = @id";

            SqlCommand command = SqlConn.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.Add(new SqlParameter("@id", id));
            command.ExecuteNonQuery();

            SqlConn.CloseConn();

            Id_label.Text = "";
            Nume_textBox.Text = "";
            Bucati_textBox.Text = "";
            DataExpirarii_Picker.Text = "";
            Tip_comboBox.SelectedIndex = -1;
            Imagine_pictureBox.Image = null;

            Delete_button.Enabled = false;
            Update_button.Text = "Adauga";

            fillListbox(selectName);
        }

        //________________________________END OF Function for delete selecte item from listbox____________________________________


        //________________________________Function for fill listbox_______________________________________________________________

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
                listBoxMedicamente.Items.Add(string.Format("{0}  {1}", r["ID"].ToString(), r["Nume"].ToString()));
                //listBoxMedicamente.Items.Add(r["Nume"].ToString());
            }

            SqlConn.CloseConn();
        }

        //________________________________END OF Function for fill listbox________________________________________________________


        //________________________________Function for exit button________________________________________________________________


        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //________________________________END OF Function for fill listbox________________________________________________________

        //________________________________Code for makig app move by mouse drag___________________________________________________

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        //_____________________END OF Code for makig app move by mouse drag____________________________________________
    }
}