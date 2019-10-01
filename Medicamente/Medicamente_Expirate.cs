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
        string selectName = "SELECT ID, Nume FROM Medicamente";
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
            this.Size = new Size(500, 300);
            exit_button.Location = new Point(472, 7);
            this.Controls.Add(MedicamenteExpirate_listbox);

            String calendar = Pick_monthCalendar.SelectionRange.Start.ToShortDateString();

            string query = selectName + " WHERE DataExpirarii <= CONVERT(date,'" + calendar + "',102)";
            //TO-DO    
            //when selected index resize and add the date when it expires and delete button.
            fillListbox(query);

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

        private static void convertDate(String input)
        {

        }

    }
}
