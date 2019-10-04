using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicamente
{
    public partial class Medicamente_Expirate : Form
    {

        private ListBox MedicamenteExpirate_listbox = new ListBox();
        private Label dataExpirare_label = new Label();
        private Button sterge_button = new Button();
        private string selectName = "SELECT ID, Nume FROM Medicamente";
        private string deleteString = "DELETE FROM Medicamente";
        private bool mouseDown;
        private Point lastLocation;

        public Medicamente_Expirate()
        {
            InitializeComponent();
        }

        //________________________________Code for shadow on border___________________________________________________

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }

        }

        //_____________________END OF Code for shadow on border____________________________________________

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //________________________________Code for making app move by mouse drag___________________________________________________

        private void Medicamente_Expirate_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Medicamente_Expirate_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Medicamente_Expirate_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //_____________________END OF Code for making app move by mouse drag____________________________________________


        private void Pick_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

            string calendar = Pick_monthCalendar.SelectionRange.Start.ToShortDateString();

            string query = selectName + " WHERE DataExpirarii <= CONVERT(date,'" + calendar + "',102)";

            SqlConn.OpenConn();
            using (SqlCommand command = new SqlCommand(query, SqlConn.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        this.Size = new Size(450, 300);
                        exit_button.Location = new Point(425, 7);
                        this.Controls.Add(MedicamenteExpirate_listbox);
                        fillListbox(query);
                        if (MedicamenteExpirate_listbox.SelectedIndex == -1)
                        {
                            this.Controls.Remove(dataExpirare_label);
                            this.Controls.Remove(sterge_button);
                        }
                    }
                    else
                    {
                        this.Size = new Size(365, 323);
                        exit_button.Location = new Point(338, 2);
                        this.Controls.Remove(MedicamenteExpirate_listbox);
                        this.Controls.Remove(dataExpirare_label);
                        this.Controls.Remove(sterge_button);
                    }
                }
            }
            SqlConn.CloseConn();

        }

        private void Medicamente_Expirate_Load(object sender, EventArgs e)
        {
            MedicamenteExpirate_listbox.Name = "Medicamente Expirate";
            MedicamenteExpirate_listbox.Location = new Point(260, 25);
            MedicamenteExpirate_listbox.Size = new Size(150, 260);
        }

        private void fillListbox(string query)
        {

            MedicamenteExpirate_listbox.Items.Clear();
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
                MedicamenteExpirate_listbox.Items.Add(string.Format("{0}  {1}", r["ID"].ToString(), r["Nume"].ToString()));
            }

            SqlConn.CloseConn();
        }


        private void MedicamenteExpirate_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //TO-DO    
            //when selected index changes resize and add the delete button.
            SqlConn.OpenConn();
            SqlCommand command = SqlConn.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            if (MedicamenteExpirate_listbox.SelectedIndex == -1)
            {
                MedicamenteExpirate_listbox.ClearSelected();
                this.Controls.Remove(sterge_button);
                this.Controls.Remove(dataExpirare_label);
                this.Size = new Size(450, 300);
                exit_button.Location = new Point(425, 7);
            }
            else
            {
                command.CommandText = "SELECT * FROM Medicamente WHERE ID = '" + MedicamenteExpirate_listbox.SelectedItem.ToString().Substring(0, MedicamenteExpirate_listbox.SelectedItem.ToString().IndexOf(" ")) + "'";
                command.ExecuteNonQuery();

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                foreach (DataRow r in dataTable.Rows)
                {
                    string dataexp = r["DataExpirarii"].ToString();
                    dataexp = dataexp.Substring(0, 10);
                    dataExpirare_label.Text = "Medicamentul expira in: " + dataexp;
                }

                this.Size = new Size(550, 300);
                exit_button.Location = new Point(525, 7);

                dataExpirare_label.Size = new Size(120, 40);
                dataExpirare_label.Location = new Point(410, 30);
                this.Controls.Add(dataExpirare_label);

                sterge_button.Size = new Size(100, 50);
                sterge_button.Location = new Point(410, 80);
                sterge_button.Text = "Stergere Medicament";
                sterge_button.BackColor = Color.Gold;
                sterge_button.FlatStyle = FlatStyle.Flat;
                sterge_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
                this.Controls.Add(sterge_button);
            }


            SqlConn.CloseConn();

        }

        private void sterge_button_Click(object sender, EventArgs e)
        {
            if (this.MedicamenteExpirate_listbox.SelectedIndex >= 0)
            {
                deleteSelected();
                this.Controls.Remove(sterge_button);
                this.Controls.Remove(dataExpirare_label);
                this.Size = new Size(450, 300);
                exit_button.Location = new Point(425, 7);//270
            }
        }

        private void deleteSelected()
        {
            SqlConn.OpenConn();
            //to retrieve only number from string with number (in this case ID of the item)
            int id = Int32.Parse(System.Text.RegularExpressions.Regex.Match(MedicamenteExpirate_listbox.SelectedItem.ToString(),@"\d+").Value);
            string query = deleteString + " WHERE Id = @id";
            
            SqlCommand command = SqlConn.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.Add(new SqlParameter("@id", id));
            command.ExecuteNonQuery();

            SqlConn.CloseConn();

            string calendar = Pick_monthCalendar.SelectionRange.Start.ToShortDateString();

            string refreshQuery = selectName + " WHERE DataExpirarii <= CONVERT(date,'" + calendar + "',102)";

            fillListbox(refreshQuery);

        }
    }

}
