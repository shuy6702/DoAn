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
    public partial class FormQuanLyBan : Form
    {
        public FormQuanLyBan()
        {
            InitializeComponent();
        }

        

        private void ButtonThemBan_Click(object sender, EventArgs e)
        {
            string TenB = TextBoxTenBan.Text;
            string status = ComboBoxStatusQLB.Text;
            TableDAO.Instance.InsertBan(TenB, status);
            LoadDataGridView();
        }

        private void ButtonSuaBan_Click(object sender, EventArgs e)
        {
            string TenB = TextBoxTenBan.Text;
            string status = ComboBoxStatusQLB.Text;
            TableDAO.Instance.UpdateBan(TenB, status);
            LoadDataGridView();
        }

        private void ButtonXoaBan_Click(object sender, EventArgs e)
        {
            string TenB = TextBoxTenBan.Text;
            TableDAO.Instance.DeleteBan(TenB);
            LoadDataGridView();
        }

        private void FormQuanLyBan_Load(object sender, EventArgs e)
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }
        private void LoadDataGridView()
        {
            try
            {
                DataGridViewQuanLyBan.DataSource = Connection.Instance.ExecuteQuery("select * from Ban");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void DataGridViewQuanLyBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxTenBan.Text = DataGridViewQuanLyBan[1, DataGridViewQuanLyBan.CurrentRow.Index].Value.ToString();
        }

        private void TextBoxTimKiemBan_TextChanged(object sender, EventArgs e)
        {
            string name = TextBoxTimKiemBan.Text.Trim();
            if (name == "")
            {
                FormQuanLyBan_Load(sender, e);
            }
            else
            {
                string query = "select * from Ban where TenB like '%" + name + "%' ";
                DataGridViewQuanLyBan.DataSource = Connection.Instance.ExecuteQuery(query);


            }
        }

        private void ButtonThemB_Click(object sender, EventArgs e)
        {
            string TenB = TextBoxTenBan.Text;
            string status = ComboBoxStatusQLB.Text;
            TableDAO.Instance.InsertBan(TenB, status);
            LoadDataGridView();
        }

        private void btnSuaB_Click(object sender, EventArgs e)
        {
            string TenB = TextBoxTenBan.Text;
            string status = ComboBoxStatusQLB.Text;
            TableDAO.Instance.UpdateBan(TenB, status);
            LoadDataGridView();
        }

        private void btnXoaB_Click(object sender, EventArgs e)
        {
            string TenB = TextBoxTenBan.Text;
            TableDAO.Instance.DeleteBan(TenB);
            LoadDataGridView();
        }
    }
}
