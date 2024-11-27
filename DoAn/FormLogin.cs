using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn
{
    public partial class FormLogin : Form
    {
        bool login(string username, string password)
        {

            return AccountDAO.Instance.login(username, password);

        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userName = TextBoxUserName.Text;
            string password = TextBoxPassword.Text;

            Account loginaccount = AccountDAO.Instance.GetAccountcsByUserName(userName);
            if (login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountcsByUserName(userName);
                this.Hide();
                FormTable f = new FormTable(loginAccount, userName);
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("sai tai khoan mat khau");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
