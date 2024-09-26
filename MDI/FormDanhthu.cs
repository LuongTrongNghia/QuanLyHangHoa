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
    public partial class FormDanhthu : Form
    {
        public FormDanhthu()
        {
            InitializeComponent();
        }

        SqlDataAdapter dataAdapter;
        DataSet  ds;
        void loaddt()
        {
            try
            {
                clsDatabase.OpenConnection();
                dataAdapter = new SqlDataAdapter("Select h.*,SOLG_MUA,TRIGIA_MUA,(SOLG_MUA * TRIGIA_MUA) as TongMUA,SOLG_BAN,TRIGIA_BAN,(SOLG_BAN * TRIGIA_BAN)as TongBAN,((SOLG_BAN * TRIGIA_BAN)-(SOLG_MUA * TRIGIA_MUA) )as LAI_LO from HANGHOA h join BAN b on h.MA_HANG = b.MA_HANG join MUA m on h.MA_HANG = m.MA_HANG\r\n", clsDatabase.con);
               
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(dataAdapter);
                ds = new DataSet();
                dataAdapter.Fill(ds,"HANGHOA");
                dataGridView1.DataSource= ds.Tables["HANGHOA"];
             
               // txtTongMua.DataBindings.Add("Text", ds.Tables["HANGHOA"],"GIA_MUA");
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormDanhthu_Load(object sender, EventArgs e)
        {
            loaddt();
        }

        private void bntCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntMua_Click(object sender, EventArgs e)
        {
          
        }

        private void bntBan_Click(object sender, EventArgs e)
        {
         
        }

        private void bntLo_Click(object sender, EventArgs e)
        {
         
        }
    }
}
