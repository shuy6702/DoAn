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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            
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
            label2.ForeColor = ThemeColor.PrimaryColor;
        }
        

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadTheme();
        }
        private void LoadDataGridView()
        {
            try
            {
                DataGridViewTaiKhoan.DataSource = Connection.Instance.ExecuteQuery("select * from Account");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void DataGridViewTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxUsername.Text = DataGridViewTaiKhoan[0, DataGridViewTaiKhoan.CurrentRow.Index].Value.ToString();
        }

        private void TextBoxTimKiemTK_TextChanged(object sender, EventArgs e)
        {
            string name = TextBoxTimKiemTK.Text.Trim() ;
            if (name == "")
            {
                FormTaiKhoan_Load(sender, e);
            }
            else
            {
                string query = "select * from Account where Username like '%" + name + "%' ";
                DataGridViewTaiKhoan.DataSource = Connection.Instance.ExecuteQuery(query);

                
            }
        }

        private void ButtonThemTk_Click_1(object sender, EventArgs e)
        {
            string userName = TextBoxUsername.Text;
            string passWord = TextBoxPassword.Text;
            string displayName = TextBoxDisplaname.Text;
            int type = int.Parse(ComboBoxTypeTK.Text);
            if (TextBoxUsername.Text == "" || TextBoxPassword.Text == "" || TextBoxDisplaname.Text == "" || ComboBoxTypeTK.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                AccountDAO.Instance.InsertAccount(userName, displayName, passWord, type);
            }
            LoadDataGridView();
        }

        private void btnSuaTk_Click(object sender, EventArgs e)
        {
            string userName = TextBoxUsername.Text;
            string displayName = TextBoxDisplaname.Text;
            string passWord = TextBoxPassword.Text;
            int type = int.Parse(ComboBoxTypeTK.Text);
            if (TextBoxUsername.Text == "" || TextBoxDisplaname.Text == "" || TextBoxPassword.Text == "" || ComboBoxTypeTK.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
            else
            {
                AccountDAO.Instance.SuaAccount(userName, displayName, passWord, type);
            }
            LoadDataGridView();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string userName = TextBoxUsername.Text;
            AccountDAO.Instance.DeleteAccount(userName);
            LoadDataGridView();
        }
    }
}
