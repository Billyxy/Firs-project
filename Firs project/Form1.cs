using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firs_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\abrah\\OneDrive\\Desktop\\form.accdb";// "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\abrah\\OneDrive\\Desktop\\form.accdb"; "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\abrah\\OneDrive\\Desktop\\sssssssss.mdb";// //
            OleDbConnection con = new OleDbConnection(connectionString);

           
            OleDbCommand command = new OleDbCommand("Select * form bnm",con);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource =dt ;
        }

       
    }
}
