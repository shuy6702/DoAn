using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();

        }

        private void ButtonThemNV_Click(object sender, EventArgs e)
        {
            string HoTenNV = TextBoxHoTenNV.Text;
            string DiaChiNV = TextBoxDCNV.Text;
            float Luong = int.Parse(TextBoxLuong.Text);
            float Thuong = int.Parse(TextBoxThuong.Text);
            int ViPham = int.Parse(TextBoxViPham.Text);
            float Cong = float.Parse(TextBoxCong.Text);
            if (TextBoxHoTenNV.Text == "" || TextBoxDCNV.Text == "" || TextBoxLuong.Text == "" || TextBoxThuong.Text == "" || TextBoxViPham.Text =="" || TextBoxCong.Text =="")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                NhanVienDAO.Instance.InsertNV(HoTenNV, DiaChiNV, Luong, Thuong, ViPham, Cong);
            }

            LoadDataGridView();
        }

        private void ButtonSuaNV_Click(object sender, EventArgs e)
        {
            string HoTenNV = TextBoxHoTenNV.Text;
            string DiaChiNV = TextBoxDCNV.Text;
            float Luong = int.Parse(TextBoxLuong.Text);
            float Thuong = int.Parse(TextBoxThuong.Text);
            int ViPham = int.Parse(TextBoxViPham.Text);
            float Cong = float.Parse(TextBoxCong.Text);
            if (TextBoxHoTenNV.Text == "" || TextBoxDCNV.Text == "" || TextBoxLuong.Text == "" || TextBoxThuong.Text == "" || TextBoxViPham.Text =="" || TextBoxCong.Text =="")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                NhanVienDAO.Instance.UpdateNV(HoTenNV, DiaChiNV, Luong, Thuong, ViPham, Cong);
            }
            LoadDataGridView();
        }

        private void ButtonXoaNV_Click(object sender, EventArgs e)
        {
            string HoTenNV = TextBoxHoTenNV.Text;
            KhachHangDAO.Instance.DeleteKH(HoTenNV);
            LoadDataGridView();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label1.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void LoadDataGridView()
        {
            try
            {
                DataGridViewNV.DataSource = Connection.Instance.ExecuteQuery("select * from NV");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

        }

        private void DataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxHoTenNV.Text = DataGridViewNV[1, DataGridViewNV.CurrentRow.Index].Value.ToString();
        }

        private void TextBoxTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            string name = TextBoxTimKiemNV.Text.Trim();
            if (name == "")
            {
                FormNhanVien_Load(sender, e);
            }
            else
            {
                string query = "select * from NV where HoTenNV like '%" + name + "%' ";
                DataGridViewNV.DataSource = Connection.Instance.ExecuteQuery(query);


            }
        }

        private void ButtonThemNV_Click_1(object sender, EventArgs e)
        {
            string HoTenNV = TextBoxHoTenNV.Text;
            string DiaChiNV = TextBoxDCNV.Text;
            float Luong = int.Parse(TextBoxLuong.Text);
            float Thuong = int.Parse(TextBoxThuong.Text);
            int ViPham = int.Parse(TextBoxViPham.Text);
            float Cong = float.Parse(TextBoxCong.Text);
            if (TextBoxHoTenNV.Text == "" || TextBoxDCNV.Text == "" || TextBoxLuong.Text == "" || TextBoxThuong.Text == "" || TextBoxViPham.Text == "" || TextBoxCong.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                NhanVienDAO.Instance.InsertNV(HoTenNV, DiaChiNV, Luong, Thuong, ViPham, Cong);
            }

            LoadDataGridView();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string HoTenNV = TextBoxHoTenNV.Text;
            string DiaChiNV = TextBoxDCNV.Text;
            float Luong = int.Parse(TextBoxLuong.Text);
            float Thuong = int.Parse(TextBoxThuong.Text);
            int ViPham = int.Parse(TextBoxViPham.Text);
            float Cong = float.Parse(TextBoxCong.Text);
            if (TextBoxHoTenNV.Text == "" || TextBoxDCNV.Text == "" || TextBoxLuong.Text == "" || TextBoxThuong.Text == "" || TextBoxViPham.Text == "" || TextBoxCong.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                NhanVienDAO.Instance.UpdateNV(HoTenNV, DiaChiNV, Luong, Thuong, ViPham, Cong);
            }
            LoadDataGridView();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string HoTenNV = TextBoxHoTenNV.Text;
            KhachHangDAO.Instance.DeleteKH(HoTenNV);
            LoadDataGridView();
        }
    }
}
