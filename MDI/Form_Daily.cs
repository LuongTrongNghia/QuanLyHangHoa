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
    public partial class Form_Daily : Form
    {
        public Form_Daily()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("insert into DaiLy values (@MaDL,@TenDl,@Diachi,@Sdt)",clsDatabase.con);
                cmd.Parameters.AddWithValue("@MaDL", txtMA_DL.Text);
                cmd.Parameters.AddWithValue("@TenDl", txt_DL.Text);
                cmd.Parameters.AddWithValue("@Diachi", txtDC.Text);
                cmd.Parameters.AddWithValue("@Sdt", txtSDT.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Sản Phẩm Thành Công.");
                clsDatabase.CloseConnection();
                Close();
                Form_Daily f = new Form_Daily();
                f.Show();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Không Thể Thêm sản Phẩm" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void bntclear_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //right here
        SqlDataAdapter dataAdapter;
        DataSet ds;
        void loadDaily()
        {
            try {
                clsDatabase.OpenConnection();
                dataAdapter = new SqlDataAdapter("select * from DaiLy",clsDatabase.con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);
                ds = new DataSet();
                dataAdapter.Fill(ds,"DaiLy");
                //compex
                dgvDaily.DataSource = ds.Tables["DaiLy"];
                //textbox va dgv
                txtMA_DL.DataBindings.Add("Text", ds.Tables["DaiLy"], "STT_DL");
                txt_DL.DataBindings.Add("Text", ds.Tables["DaiLy"], "TEN_DL");
                txtDC.DataBindings.Add("Text", ds.Tables["DaiLy"],"DCHI_DL");
                txtSDT.DataBindings.Add("Text", ds.Tables["DaiLy"], "SDT");

                clsDatabase.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi load",ex.Message);
            }
        }
        private void Form_Daily_Load(object sender, EventArgs e)
        {
            loadDaily();
        }
        

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataAdapter.Update(ds.Tables["DaiLy"]);
        }

        private void bntfix_Click(object sender, EventArgs e)
        {
            try {
                this.BindingContext[ds.Tables["DaiLy"]].EndCurrentEdit();
                dataAdapter.Update(ds.Tables["DaiLy"]);
            }
            catch (Exception ex) { 
                MessageBox.Show ("Lỗi",ex.Message);
                ds.Tables["Loaisp"].RejectChanges();
            }
        }

        private void bntclear_Click_1(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)this.BindingContext[ds.Tables["DaiLy"]].Current).Delete();
                this.BindingContext[ds.Tables["Daily"]].EndCurrentEdit();
                dataAdapter.Update(ds.Tables["Daily"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ds.Tables["DaiLy"].RejectChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
