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

namespace QuanLyThuvien.form
{
    public partial class Bandoc : Form
    {
        string sql = "";
        SqlConnection conn;
        string flag = "";
        public Bandoc()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=XKNIGHT\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        }
        private void Connect()
        {
            conn.Open();
        }
        private void LoadInforReader(SqlConnection connect)
        {
            sql = "select * from Bandoc";// tạo chuỗi truy vấn
            SqlCommand cmd = new SqlCommand(sql, connect);// tạo truy  vấn
            SqlDataAdapter adp = new SqlDataAdapter();// tạo adapter
            adp.SelectCommand = cmd;// chọn truy vấn cho adapter
            DataTable dt = new DataTable();// tạo kho chứa dữ liệu
            adp.Fill(dt);// chuyển dữ liệu truy vấn dc vào kho thông qua adapter
            dgvbandoc.DataSource = dt;// lấy dữ liệu trong kho để hiển thị lên GridView
            connect.Close();
        }
        private void Bandoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.Bandoc' table. You can move, or remove it, as needed.
            this.bandocTableAdapter.Fill(this.qLTVDataSet.Bandoc);
            Connect();
            LoadInforReader(conn);
        }
        private void InsertBandoc(SqlConnection connect)
        {
            Connect();
            string sql = "InsertBandoc";
            string date = dtpbandoc.Value.Year + "/" + dtpbandoc.Value.Month + "/" + dtpbandoc.Value.Day;
           // string gt="";
            string date2 = dtpNHH.Value.Year + "/" + dtpNHH.Value.Month + "/" + dtpNHH.Value.Day;
            // string gt="";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@MaBD",txtmabd.Text));
                cmd.Parameters.Add(new SqlParameter("@HoTenBD",txttenbd.Text));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh",date));
                cmd.Parameters.Add(new SqlParameter("@GT",cmbGT.Text));
                cmd.Parameters.Add(new SqlParameter("@Diachi",txtdiachi.Text));
                cmd.Parameters.Add(new SqlParameter("@Email",txtemail.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayHetHanthe", date2));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();// cập nhật lại cơ sở dữ liệu
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }         
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = "Add";
            int rowmax = dgvbandoc.Rows.Count - 1;
            string mamax = dgvbandoc.Rows[rowmax].Cells[0].Value.ToString();
            string moi = (Int32.Parse(mamax.Substring(2)) + 1).ToString();
            //MessageBox.Show(moi.Length.ToString());
            switch (moi.Length)
            {
                case 1:
                    moi = "bd0" + moi;
                    break;
                case 2:
                    moi = "bd" + moi;
                    break;
          }
            txtmabd.Text = moi;
            txttenbd.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            

            txtmabd.ReadOnly = false;
            txttenbd.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txtemail.ReadOnly = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }
        private void UpdateBandoc(SqlConnection connect)
        {
            Connect();
            string sql = "UpdateBandoc";
            string date = dtpbandoc.Value.Year + "/" + dtpbandoc.Value.Month + "/" + dtpbandoc.Value.Day;
            string gt = "";
            string date2 = dtpNHH.Value.Year + "/" + dtpNHH.Value.Month + "/" + dtpNHH.Value.Day;

            
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@MaBD", txtmabd.Text));
                cmd.Parameters.Add(new SqlParameter("@HoTenBD", txttenbd.Text));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", date));
                cmd.Parameters.Add(new SqlParameter("@GT", cmbGT.Text));
                cmd.Parameters.Add(new SqlParameter("@Diachi", txtdiachi.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", txtemail.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayHetHanthe", date2));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();// cập nhật lại cơ sở dữ liệu
        
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = "Update";
            txtmabd.ReadOnly = true;
            txttenbd.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txtemail.ReadOnly = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }
        private void DeleteBandoc(SqlConnection connect)
        {
            Connect();
            string sql = "delete from Bandoc where MaBD = '" + txtmabd.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();// cập nhật lại cơ sở dữ liệu
            LoadInforReader(conn);
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DeleteBandoc(conn);
        }
        private void Locked()
        {
            txtmabd.ReadOnly = true;
            txttenbd.ReadOnly = true;
            //dtpbandoc.ReadOnly = true;
            //cmbGT.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtemail.ReadOnly = true;
            //dtpNHH.ReadOnly = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case "Add":
                    if (txtmabd.Text == "" || txttenbd.Text == "" || txtdiachi.Text == "" || txtemail.Text == "")
                    {
                        MessageBox.Show("Nhập chưa đủ dữ liệu");
                        btnluu.Enabled = true; btnhuy.Enabled = true;
                        return;
                    }
                    InsertBandoc(conn);
                    LoadInforReader(conn);
                    Locked();
                    break;
                case "Update":
                    if (txttenbd.Text == "" || txtdiachi.Text == "" || txtemail.Text == "")
                    {
                        MessageBox.Show("Nhập chưa đủ dữ liệu");
                        btnluu.Enabled = true; btnhuy.Enabled = true;
                        return;
                    }
                    UpdateBandoc(conn);
                    LoadInforReader(conn);
                    Locked();
                    break;
            }        
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmabd.Text = "";
            txttenbd.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";

            Locked();
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void dgvbandoc_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvbandoc.CurrentCell.RowIndex;
            txtmabd.Text = dgvbandoc.Rows[index].Cells[0].Value.ToString();
            txttenbd.Text = dgvbandoc.Rows[index].Cells[1].Value.ToString();
            dtpbandoc.Text = dgvbandoc.Rows[index].Cells[2].Value.ToString();
            cmbGT.Text = dgvbandoc.Rows[index].Cells[3].Value.ToString();
            txtdiachi.Text = dgvbandoc.Rows[index].Cells[4].Value.ToString();
            txtemail.Text = dgvbandoc.Rows[index].Cells[5].Value.ToString();
            dtpNHH.Text = dgvbandoc.Rows[index].Cells[6].Value.ToString();
        }

        private void Bandoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdnu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpNHH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpbandoc_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
