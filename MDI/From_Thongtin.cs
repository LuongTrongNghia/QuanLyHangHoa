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
    public partial class From_Thongtin : Form
    {
        public From_Thongtin()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("insert into HANGHOA values (@MA_HANG,@TEN_HG,@DVT,@NCC)", clsDatabase.con);
                cmd.Parameters.AddWithValue("@MA_HANG", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@TEN_HG", txtNameHH.Text);
                cmd.Parameters.AddWithValue("@DVT", txtDVT.Text);
                cmd.Parameters.AddWithValue("@NCC", txtNCC.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                //asd
                clsDatabase.CloseConnection();
                Close();
                From_Thongtin d = new From_Thongtin();
                d.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể Thêm" + ex.Message);
            }
        }
        SqlDataAdapter dataAdapter;
        DataSet ds = new DataSet();
        void loadThongtin()
        {
            try
            {
                clsDatabase.OpenConnection();

                dataAdapter = new SqlDataAdapter("select * from HANGHOA", clsDatabase.con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);
                ds = new DataSet();
                dataAdapter.Fill(ds, "HANGHOA");
                dgvThongtin.DataSource = ds.Tables["HANGHOA"];

                txtMaHang.DataBindings.Add("Text", ds.Tables["HANGHOA"], "MA_HANG");
                txtNameHH.DataBindings.Add("Text", ds.Tables["HANGHOA"], "TEN_HG");
                txtDVT.DataBindings.Add("Text", ds.Tables["HANGHOA"], "DVT");
                txtNCC.DataBindings.Add("Text", ds.Tables["HANGHOA"], "NCC");
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi load" + ex.Message);
            }
        }
            private void From_Thongtin_Load(object sender, EventArgs e)
            {
                loadThongtin();        
            }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
            
                this.BindingContext[ds.Tables["HANGHOA"]].EndCurrentEdit();
                dataAdapter.Update(ds.Tables["HANGHOA"]);   

            }
            catch (Exception ex)
            {
                MessageBox.Show ("sua ko thanh cong"+ex.Message);
                ds.Tables["HANGHOA"].RejectChanges();
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try {
                ((DataRowView)this.BindingContext[ds.Tables["HANGHOA"]].Current).Delete();
                this.BindingContext[ds.Tables["HANGHOA"]].EndCurrentEdit();
                dataAdapter.Update(ds.Tables["HANGHOA"]);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                ds.Tables["HANGHOA"].RejectChanges();
            }
        }
      /*  void loadcbtimkiem()
        {
            try
            { 
                clsDatabase.OpenConnection();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from HANGHOA",clsDatabase.con);
                DataSet ds = new DataSet(); 
                dataAdapter.Fill(ds,"HANGHOA");

                cbtimkiem.DataSource = ds.Tables["HANGHOA"];
                cbtimkiem.ValueMember = "MA_HANG";
                cbtimkiem.DisplayMember = "TEN_HANG";
                clsDatabase.CloseConnection();
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
            }
        }*/
        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            TimThongTIn a= new TimThongTIn();   
            a.Show();
        }
    } 
}
