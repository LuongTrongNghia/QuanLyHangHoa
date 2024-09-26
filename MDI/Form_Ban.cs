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
    public partial class Form_Ban : Form
    {
        public Form_Ban()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            try
            { 
               clsDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand("insert into BAN values (@MA_HANG,@STT_DL,@NGAY_BAN,@SOLG_BAN,@TRIGIA_BAN)", clsDatabase.con);
                cmd.Parameters.AddWithValue("@MA_HANG", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@STT_DL",txtMaDL.Text);
                cmd.Parameters.AddWithValue("@NGAY_BAN",dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SOLG_BAN",txtSLBan.Text);
                cmd.Parameters.AddWithValue("@TRIGIA_BAN",txtTG.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đơn mua thành công");
                clsDatabase.CloseConnection();
                Close();
                Form_Ban a = new Form_Ban();
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Không Thành Công" + ex.Message);
            }
        }
        SqlDataAdapter dataAdapter;
        DataSet ds;
        void loadBan()
        {
            try
            {
                clsDatabase.OpenConnection();
                dataAdapter = new SqlDataAdapter("select *from BAN", clsDatabase.con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

                ds = new DataSet();
                dataAdapter.Fill(ds, "BAN");

                dataGridView1.DataSource = ds.Tables["BAN"];

                txtMaHang.DataBindings.Add("Text", ds.Tables["BAN"], "MA_HANG");
                txtMaDL.DataBindings.Add("Text", ds.Tables["BAN"], "STT_DL");
                dateTimePicker1.DataBindings.Add("Text", ds.Tables["BAN"], "NGAY_BAN");
                txtSLBan.DataBindings.Add("Text", ds.Tables["BAN"], "SOLG_BAN");
                txtTG.DataBindings.Add("Text", ds.Tables["BAN"], "TRIGIA_BAN");

                clsDatabase.CloseConnection();
                

            }
            catch (Exception ex) { MessageBox.Show("loi "+ex.Message); }
        }
        private void Form_Ban_Load(object sender, EventArgs e)
        {
            loadBan();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)this.BindingContext[ds.Tables["BAN"]].Current).Delete();
                this.BindingContext[ds.Tables["BAN"]].EndCurrentEdit();
                dataAdapter.Update(ds.Tables["BAN"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ds.Tables["BAN"].RejectChanges();
            }
        }
    }
}
