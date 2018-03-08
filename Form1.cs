using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti= new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\cannet\\Desktop\\veri_seti.xls; Extended Properties = 'Excel 12.0 xml;HDR=NO;'");
            baglanti.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM[Training_Data$]", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
