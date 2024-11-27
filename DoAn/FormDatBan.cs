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
    public partial class FormDatBan : Form
    {
        public FormDatBan()
        {
            InitializeComponent();
        }


        private void DataGridViewDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDatBan_Load(object sender, EventArgs e)
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
                DataGridViewDB.DataSource = Connection.Instance.ExecuteQuery("select * from DatBan");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void TextBoxTimKiemDB_TextChanged(object sender, EventArgs e)
        {
            string name = TextBoxHoTenKHDatBan.Text.Trim();
            if (name == "")
            {
                FormDatBan_Load(sender, e);
            }
            else
            {
                string query = "select * from DatBan where HoTenKH like '%" + name + "%' ";
                DataGridViewDB.DataSource = Connection.Instance.ExecuteQuery(query);


            }
        }

        private void DataGridViewDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxHoTenKHDatBan.Text = DataGridViewDB[1, DataGridViewDB.CurrentRow.Index].Value.ToString();
        }

        private void ButtonThemDB_Click_1(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKHDatBan.Text;
            string SDT = TextBoxSDTDB.Text;
            DateTime GioDB = DateTimePickerDB.Value;
            string GhiChu = TextBoxGC.Text;
            if (TextBoxHoTenKHDatBan.Text == "" || TextBoxSDTDB.Text == "" || TextBoxGC.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                DaatBanDAO.Instance.InsertDB(HoTenKH, SDT, GioDB, GhiChu);
            }
            LoadDataGridView();
        }

        private void btnSuaDB_Click(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKHDatBan.Text;
            string SDT = TextBoxSDTDB.Text;
            DateTime GioDB = DateTimePickerDB.Value;
            string GhiChu = TextBoxGC.Text;
            if (TextBoxHoTenKHDatBan.Text == "" || TextBoxSDTDB.Text == "" || TextBoxGC.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                DaatBanDAO.Instance.UpdateDB(HoTenKH, SDT, GioDB, GhiChu);
            }
            LoadDataGridView();
        }

        private void btnXoaDB_Click(object sender, EventArgs e)
        {
            string HoTenKH = TextBoxHoTenKHDatBan.Text;
            DaatBanDAO.Instance.DeleteDB(HoTenKH);
            LoadDataGridView();
        }
    }
}
