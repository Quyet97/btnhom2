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
    public partial class Phieumuon : Form
    {
        string sql = "";
        SqlConnection conn;
        string flag = "";
        public Phieumuon()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=XKNIGHT\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        }
        private void Connect()
        {
            conn.Open();
        }
        private void LoadInforPM(SqlConnection connect)
        {
            sql = "select MaBD,Sophieu from Phieumuon";// tạo chuỗi truy vấn
            SqlCommand cmd = new SqlCommand(sql, connect);// tạo truy  vấn
            SqlDataAdapter adp = new SqlDataAdapter();// tạo adapter
            adp.SelectCommand = cmd;// chọn truy vấn cho adapter
            DataTable dt = new DataTable();// tạo kho chứa dữ liệu
            adp.Fill(dt);// chuyển dữ liệu truy vấn dc vào kho thông qua adapter
            dgvphieumuon.DataSource = dt;// lấy dữ liệu trong kho để hiển thị lên GridView
            connect.Close();
        }
        private void Phieumuon_Load(object sender, EventArgs e)
        {
            
            Connect();
            LoadInforPM(conn);
        }
        private void Locked()
        {
            txtsp.ReadOnly = true;
            txtma.ReadOnly = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        private void InsertPM(SqlConnection connect)
        {
            Connect();
            string sql = "InsertPhieumuon";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@MaBD", txtma.Text));
                cmd.Parameters.Add(new SqlParameter("@SoPhieu", txtsp.Text));
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
            int rowmax = dgvphieumuon.Rows.Count - 2;
            string mamax = dgvphieumuon.Rows[rowmax].Cells[0].Value.ToString();
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
            txtma.Text = moi;
            txtsp.Text = "";
            txtma.ReadOnly = false;
            txtsp.ReadOnly = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }
        private void UpdatePM(SqlConnection connect)
        {
            Connect();
            string sql = "UpdatePhieumuon";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@MaBD", txtma.Text));
                cmd.Parameters.Add(new SqlParameter("@SoPhieu", txtsp.Text));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();// cập nhật lại cơ sở dữ liệu
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }     
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = "Update";
            txtsp.ReadOnly = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }
        private void DeletePM(SqlConnection connect)
        {
            
                Connect();
                //string sql = "DeletePhieumuon";
                string sql = "delete from Phieumuon where SoPhieu = '" + txtsp.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@SoPhieu",txtsp.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();// cập nhật lại cơ sở dữ liệu
                LoadInforPM(conn);
                     
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DeletePM(conn);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case "Add":
                    if (txtsp.Text == "" || txtma.Text == "")
                    {
                        MessageBox.Show("Nhập chưa đủ dữ liệu");
                        btnluu.Enabled = true; btnhuy.Enabled = true;
                        return;
                    }
                    InsertPM(conn);
                    LoadInforPM(conn);
                    Locked();
                    break;
                case "Update":
                    if (txtma.Text == "")
                    {
                        MessageBox.Show("Nhập chưa đủ dữ liệu");
                        btnluu.Enabled = true; btnhuy.Enabled = true;
                        return;
                    }
                    UpdatePM(conn);
                    LoadInforPM(conn);
                    Locked();
                    break;
            }
            txtma.ReadOnly = true;
            txtsp.ReadOnly = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtsp.Text = "";
            txtma.Text = "";
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void dgvphieumuon_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvphieumuon.CurrentCell.RowIndex;
            txtsp.Text = dgvphieumuon.Rows[index].Cells[0].Value.ToString();
            txtma.Text = dgvphieumuon.Rows[index].Cells[1].Value.ToString();
        }

        private void Phieumuon_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void txtmabd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsophieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

    }
}
