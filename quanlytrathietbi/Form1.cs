using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlytrathietbi.Class;
namespace quanlytrathietbi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tblCL;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblPhieuTra";
            tblCL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dataGridView1.DataSource = tblCL; //Nguồn dữ liệu            
            dataGridView1.Columns[0].HeaderText = "Mã thiết bị";
            dataGridView1.Columns[1].HeaderText = "Nhân viên trả";
            dataGridView1.Columns[2].HeaderText = "Nhân viên nhận";
            dataGridView1.Columns[3].HeaderText = "Ngày trả";
            dataGridView1.Columns[4].HeaderText = "Số lượng";
            dataGridView1.Columns[5].HeaderText = "Tình trạng";
            dataGridView1.Columns[6].HeaderText = "Mã phòng";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;

            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp}
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            LoadDataGridView();
            

            string matb;
            matb = "SELECT MaTB FROM tblThietBi";
            comboBox1.DataSource = Functions.GetDataToTable(matb);
            comboBox1.DisplayMember = "MaTB";

            string nvtra;
            nvtra = "SELECT TenNV FROM tblNhanVien";
            comboBox2.DataSource = Functions.GetDataToTable(nvtra);
            comboBox2.DisplayMember = "TenNV";

            string nvnhan;
            nvnhan = "SELECT TenNV FROM tblNhanVien";
            comboBox3.DataSource = Functions.GetDataToTable(nvnhan);
            comboBox3.DisplayMember = "TenNV";

            string tinhtrang;
            tinhtrang = "SELECT TinhTrang FROM tblThietBi";
            comboBox5.DataSource = Functions.GetDataToTable(tinhtrang);
            comboBox5.DisplayMember = "TinhTrang";

            string maphong;
            maphong = "SELECT MaPhong FROM tblPhong";
            comboBox4.DataSource = Functions.GetDataToTable(maphong);
            comboBox4.DisplayMember = "MaPhong";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlap_Click(object sender, EventArgs e)
        {

        }
    }
}
