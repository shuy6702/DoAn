using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void ButtonThemKH_Click(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKH.Text;
            string SDT = TextBoxSDTKH.Text;
            string CCCD = TextBoxCCCD.Text;
            int diem = int.Parse(TextBoxDiemKH.Text);
            if (TextBoxHoTenKH.Text == "" || TextBoxSDTKH.Text == "" || TextBoxCCCD.Text == "" || TextBoxDiemKH.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                KhachHangDAO.Instance.InsertKH(HoTenKH, SDT, CCCD, diem);
            }

            LoadDataGridView();
        }

        private void ButtonSuaKH_Click(object sender, EventArgs e)
        {

            string HoTenKH = TextBoxHoTenKH.Text;
            string SDT = TextBoxSDTKH.Text;
            string CCCD = TextBoxCCCD.Text;
            int diem = int.Parse(TextBoxDiemKH.Text);
            if (TextBoxHoTenKH.Text == "" || TextBoxSDTKH.Text == "" || TextBoxCCCD.Text == "" || TextBoxDiemKH.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                KhachHangDAO.Instance.UpdateKH(HoTenKH, SDT, CCCD, diem);
            }
            LoadDataGridView();
        }

        private void ButtonXoaKH_Click(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKH.Text;
            KhachHangDAO.Instance.DeleteKH(HoTenKH);
            LoadDataGridView();


        }

        private void FormKhachHang_Load(object sender, EventArgs e)
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
                DataGridViewKH.DataSource = Connection.Instance.ExecuteQuery("select * from KH");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void DataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxHoTenKH.Text = DataGridViewKH[1, DataGridViewKH.CurrentRow.Index].Value.ToString();
        }

        private void TextBoxTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            string name = TextBoxTimKiemKH.Text.Trim();
            if (name == "")
            {
                FormKhachHang_Load(sender, e);
            }
            else
            {
                string query = "select * from KH where HoTenKH like '%" + name + "%' ";
                DataGridViewKH.DataSource = Connection.Instance.ExecuteQuery(query);


            }
        }

        private void ButtonThemKH_Click_1(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKH.Text;
            string SDT = TextBoxSDTKH.Text;
            string CCCD = TextBoxCCCD.Text;
            int diem = int.Parse(TextBoxDiemKH.Text);
            if (TextBoxHoTenKH.Text == "" || TextBoxSDTKH.Text == "" || TextBoxCCCD.Text == "" || TextBoxDiemKH.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                KhachHangDAO.Instance.InsertKH(HoTenKH, SDT, CCCD, diem);
            }

            LoadDataGridView();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKH.Text;
            string SDT = TextBoxSDTKH.Text;
            string CCCD = TextBoxCCCD.Text;
            int diem = int.Parse(TextBoxDiemKH.Text);
            if (TextBoxHoTenKH.Text == "" || TextBoxSDTKH.Text == "" || TextBoxCCCD.Text == "" || TextBoxDiemKH.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                KhachHangDAO.Instance.UpdateKH(HoTenKH, SDT, CCCD, diem);
            }
            LoadDataGridView();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKH.Text;
            KhachHangDAO.Instance.DeleteKH(HoTenKH);
            LoadDataGridView();
        }
    }
}
