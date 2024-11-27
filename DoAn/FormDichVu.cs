using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormDichVu : Form
    {
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void ButtonThemDV_Click(object sender, EventArgs e)
        {
            string TenDV = TextBoxTenDV.Text;
            float DonGia = int.Parse(TextBoxDonGia.Text);
            string DonViTinh = TextBoxDVT.Text;
            if (TextBoxTenDV.Text == "" || TextBoxDonGia.Text == "" || TextBoxDVT.Text == "" )
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                DichVuThemDAO.Instance.InsertDVThem(TenDV, DonGia, DonViTinh);
            }
            LoadDataGridView();
        }

        private void ButtonSuaDV_Click(object sender, EventArgs e)
        {
            string TenDV = TextBoxTenDV.Text;
            float DonGia = int.Parse(TextBoxDonGia.Text);
            string DonViTinh = TextBoxDVT.Text;
            if (TextBoxTenDV.Text == "" || TextBoxDonGia.Text == "" || TextBoxDVT.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                DichVuThemDAO.Instance.UpdateDVThem (TenDV, DonGia, DonViTinh);
            }
            LoadDataGridView();
        }

        private void ButtonXoaDV_Click(object sender, EventArgs e)
        {
            string TenDV = TextBoxTenDV.Text;
            DichVuThemDAO.Instance.DeleteDVThem(TenDV);
            LoadDataGridView();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
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
                DataGridViewDV.DataSource = Connection.Instance.ExecuteQuery("select * from DichVuThem");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void DataGridViewDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxTenDV.Text = DataGridViewDV[1, DataGridViewDV.CurrentRow.Index].Value.ToString();
        }

        private void TextBoxTimKiemDV_TextChanged(object sender, EventArgs e)
        {
            string name = TextBoxTenDV.Text.Trim();
            if (name == "")
            {
                FormDichVu_Load(sender, e);
            }
            else
            {
                string query = "select * from DichVuThem where TenDV like '%" + name + "%' ";
                DataGridViewDV.DataSource = Connection.Instance.ExecuteQuery(query);


            }
        }

        private void ButtonThemDV_Click_1(object sender, EventArgs e)
        {
            string TenDV = TextBoxTenDV.Text;
            float DonGia = int.Parse(TextBoxDonGia.Text);
            string DonViTinh = TextBoxDVT.Text;
            if (TextBoxTenDV.Text == "" || TextBoxDonGia.Text == "" || TextBoxDVT.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                DichVuThemDAO.Instance.InsertDVThem(TenDV, DonGia, DonViTinh);
            }
            LoadDataGridView();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            string TenDV = TextBoxTenDV.Text;
            float DonGia = int.Parse(TextBoxDonGia.Text);
            string DonViTinh = TextBoxDVT.Text;
            if (TextBoxTenDV.Text == "" || TextBoxDonGia.Text == "" || TextBoxDVT.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                DichVuThemDAO.Instance.UpdateDVThem(TenDV, DonGia, DonViTinh);
            }
            LoadDataGridView();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            string TenDV = TextBoxTenDV.Text;
            DichVuThemDAO.Instance.DeleteDVThem(TenDV);
            LoadDataGridView();
        }
    }
}
