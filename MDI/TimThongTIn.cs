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

namespace MDI
{
    public partial class TimThongTIn : Form
    {
        public TimThongTIn()
        {
            InitializeComponent();
        }
        SqlDataAdapter dataAdapter;
        DataSet ds = new DataSet();
       /*  void loadtimkiem()
        {
            try
            {
                clsDatabase.OpenConnection();

                dataAdapter = new SqlDataAdapter("select * from HANGHOA where MA_HANG = '@mahangg'", clsDatabase.con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);
                textBox1.Text = "@mahangg";
                ds = new DataSet();
                dataAdapter.Fill(ds, "HANGHOA");
                dataGridView1.DataSource = ds.Tables["HANGHOA"];
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }*/
        private void TimThongTIn_Load(object sender, EventArgs e)
        {
            //loadtimkiem();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                clsDatabase.OpenConnection();
                if (comboBox1.SelectedItem.ToString() == "Mã hàng hoá")
                {
                    void loadtimkiem()
                    {
                        dataAdapter = new SqlDataAdapter("select * from HANGHOA where MA_HANG = '@mahangg'", clsDatabase.con);
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);
                        textBox1.Text = "@mahangg";
                        ds = new DataSet();
                        dataAdapter.Fill(ds, "HANGHOA");
                        dataGridView1.DataSource = ds.Tables["HANGHOA"];
                    }
                 

                    clsDatabase.CloseConnection();
                   
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                   
            }
        }
    }
}
