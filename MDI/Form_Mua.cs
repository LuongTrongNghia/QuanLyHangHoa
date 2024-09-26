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
    public partial class Form_Mua : Form
    {
        public Form_Mua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                clsDatabase.OpenConnection();
                 
                SqlCommand cmd = new SqlCommand("insert into MUA values (@MA_HANG,@STT_DL,@NGAY_MUA,@SOLG_MUA,@TRIGIA_MUA)",clsDatabase.con);
                cmd.Parameters.AddWithValue("@MA_HANG",txtMaHang.Text);
                cmd.Parameters.AddWithValue("@STT_DL",txtMaDL.Text);
                cmd.Parameters.AddWithValue("@NGAY_MUA",dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SOLG_MUA",txtSLban.Text);
                cmd.Parameters.AddWithValue("@TRIGIA_MUA",txtTriGia.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Sản Phẩm Thành Công");
                clsDatabase.CloseConnection();
                Close();
                Form_Mua a = new Form_Mua();
                a.Show();

            }
            catch (Exception ex)
            { 
                MessageBox.Show("loi" +ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        SqlDataAdapter dataAdapter;
        DataSet ds;
        void loadmua()
        {
            try
            {
                clsDatabase.OpenConnection();

                dataAdapter = new SqlDataAdapter("select * from MUA", clsDatabase.con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

                ds = new DataSet();
                dataAdapter.Fill(ds, "MUA");

                dataGridView1.DataSource = ds.Tables["MUA"];

                txtMaHang.DataBindings.Add("Text", ds.Tables["MUA"], "MA_HANG");
                txtMaDL.DataBindings.Add("Text", ds.Tables["MUA"], "STT_DL");
                dateTimePicker1.DataBindings.Add("Text", ds.Tables["MUA"], "NGAY_MUA");
                txtSLban.DataBindings.Add("Text", ds.Tables["MUA"], "SOLG_MUA");
                txtTriGia.DataBindings.Add("Text", ds.Tables["MUA"], "TRIGIA_MUA");
                clsDatabase.CloseConnection();

            }
            catch(Exception ex) { MessageBox.Show("khongload dc " + ex.Message); }
        }
        private void Form_Mua_Load(object sender, EventArgs e)
        {
            loadmua();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)this.BindingContext[ds.Tables["MUA"]].Current).Delete();
                this.BindingContext[ds.Tables["MUA"]].EndCurrentEdit();
                dataAdapter.Update(ds.Tables["MUA"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ds.Tables["MUA"].RejectChanges();
            }
        }
    }
}
