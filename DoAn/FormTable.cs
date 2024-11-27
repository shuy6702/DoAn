using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormTable : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        string userName = "", displayName = "", passWord = "";
        int type = 0;
        public FormTable(Account acc, string username)
        {
            random = new Random();
            //this.userName = username;
            InitializeComponent();
            LoadTable();
            LoadDV();
            LoadComboboxTable(ComboBoxChuyenBan);
            
            //this.LoginAccount = acc;

            //changeaccount(loginAccount.Type);
            
        }
        public FormTable(string username, string displayName, string passWord, int type)
        {
            this.userName = userName;
            this.displayName = displayName;
            this.type = type;
            this.passWord = passWord;
        }
        private Account loginAccount;

        private void ApplyPermission(int accountType)
        {
            if (accountType == 0) // Nhân viên
            {
                btnTaiKhoan.Enabled = false; // Ẩn chức năng quản lý tài khoản
                btnKH.Enabled = false;       // Ẩn chức năng quản lý khách hàng
                btnDB.Enabled = false;       // Ẩn chức năng đặt bàn
                btnNV.Enabled = false;       // Ẩn chức năng quản lý nhân viên
            }
            else if (accountType == 1) // Chủ quán
            {
                btnTaiKhoan.Enabled = true;
                btnKH.Enabled = true;
                btnDB.Enabled = true;
                btnNV.Enabled = true;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public Account LoginAccount
        //{
        //    get => loginAccount;
        //    set { loginAccount = value; changeaccount(loginAccount.Type); }
        //}
        void LoadTable()
        {
            flpTable1.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.TenB + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable1.Controls.Add(btn);
            }
        }

        void ShowBill(int ID)
        {
            lsvBill.Items.Clear();

            int TongTien = 0;
            List<Menu> ListBillInfo = MenuDAO.Instance.GetListMenuByTable(ID);

            // Thêm dữ liệu vào ListView
            foreach (Menu item in ListBillInfo)
            {
                //Console.WriteLine($"Mã DV: {item.MaDV}, Số Lượng: {item.SoLuong}");
                ListViewItem lsvitem = new ListViewItem(item.TenDV.ToString());
                lsvitem.SubItems.Add(item.SoLuong.ToString());
                lsvitem.SubItems.Add(item.DonGia.ToString());
                lsvitem.SubItems.Add(item.TongTien.ToString());
                TongTien += item.TongTien; 
                lsvBill.Items.Add(lsvitem);
            }
            //CultureInfo cultureInfo = new CultureInfo("vi-Vn");
            //TextBoxTongTien.Text = TongTien.ToString("c", cultureInfo);

            HD bill = BillDAO.Instance.GetBillByTable(ID);
            if (bill != null)
            {
                DateTime tgbd = bill.TGBD;
                DateTime tgkt = bill.TGKT ?? DateTime.Now; // Nếu TGKT null, dùng thời gian hiện tại
                double soGioChoi = (tgkt - tgbd).TotalMinutes / 60.0; // Thời gian chơi (giờ)
                int DonGiaBan = 60000; // Giá mỗi giờ sử dụng bàn (giả sử 50.000 đồng/giờ)
                int TongTienBan = (int)(soGioChoi * DonGiaBan); // Tính phí sử dụng bàn

                // Thêm phí sử dụng bàn vào tổng tiền
                TongTien += TongTienBan;

                // Thêm thông tin phí sử dụng bàn vào ListView
                ListViewItem lsvBan = new ListViewItem("Phí sử dụng bàn");
                lsvBan.SubItems.Add(soGioChoi.ToString("0.00")); // Số giờ
                lsvBan.SubItems.Add(DonGiaBan.ToString()); // Đơn giá
                lsvBan.SubItems.Add(TongTienBan.ToString()); // Tổng tiền
                lsvBill.Items.Add(lsvBan);
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextBoxTongTien.Text = TongTien.ToString("c", cultureInfo);

        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "TenB";
        }
        void btn_Click(object sender, EventArgs e)
        {
            
            int tableID = ((sender as Button).Tag as Table).MaB;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }


        //private void btnTaiKhoan_Click(object sender, EventArgs e)
        //{
        //    FormTaiKhoan f = new FormTaiKhoan();
        //    f.ShowDialog();
        //}

        //private void ButtonKhachHang_Click(object sender, EventArgs e)
        //{
        //    FormKhachHang f = new FormKhachHang();
        //    f.ShowDialog();
        //}

        //private void ButtonDV_Click(object sender, EventArgs e)
        //{
        //    FormDichVu f = new FormDichVu();
        //    f.ShowDialog();
        //}

        //private void ButtonNV_Click(object sender, EventArgs e)
        //{
        //    FormNhanVien f = new FormNhanVien();
        //    f.ShowDialog();
        //}

        //private void ButtonDB_Click(object sender, EventArgs e)
        //{
        //    FormDatBan f = new FormDatBan();
        //    f.ShowDialog();
        //}

        //private void ButtonQLB_Click(object sender, EventArgs e)
        //{
        //    FormQuanLyBan f = new FormQuanLyBan();
        //    f.ShowDialog();
        //}

        private void FormTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            //try
            //{
            //    dataGridViewCTHD.DataSource = Connection.Instance.ExecuteQuery("select * from ChiTietHD");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("error: " + ex.Message);
            //}

        }

        void StartTable(int tableID)
        {
            string query = "UPDATE HD SET TGBD = GETDATE() WHERE MaB = @MaB AND status = 0";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { tableID });

            if (result > 0)
            {
                MessageBox.Show("Thời gian bắt đầu đã được lưu.");
            }
            else
            {
                MessageBox.Show("Không thể lưu thời gian bắt đầu. Hãy kiểm tra lại!");
            }
        }

        

        

        

        void LoadDV()
        {
            List<DichVuThem> listDV = DichVuThemDAO.Instance.GetListDV();
            ComboBoxDV.DataSource = listDV;
            ComboBoxDV.DisplayMember = "TenDV";
        }
        private void ComboBoxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DichVuThem selected = cb.SelectedItem as DichVuThem;
            id = selected.Id;


        }

        

        private void ButtonThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int MaHD = BillDAO.Instance.GetUnCheckBillByTable(table.MaB);

            int KM = int.Parse(TextBoxKM.Text);

            double totalPrice = Convert.ToDouble(TextBoxTongTien.Text.Split(',')[0]);

            double finalTotalPrice = totalPrice - (totalPrice/100)*KM;


            if ( MaHD != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.TenB, totalPrice, KM, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(MaHD , KM , (float)finalTotalPrice);
                    ShowBill(table.MaB);

                    LoadTable();
                }
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonChuyenban_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).MaB;

            int id2 = (ComboBoxChuyenBan.SelectedItem as Table).MaB;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).TenB, (ComboBoxChuyenBan.SelectedItem as Table).TenB), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }

        

        private void btnBD_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            // Lấy ID hóa đơn chưa thanh toán
            int idBill = BillDAO.Instance.GetUnCheckBillByTable(table.MaB);

            if (idBill == -1) // Nếu chưa có hóa đơn, tạo hóa đơn mới
            {
                BillDAO.Instance.InsertBill(table.MaB); // Tạo hóa đơn mới
                idBill = BillDAO.Instance.GetMaxBill(); // Lấy ID hóa đơn vừa tạo
            }

            // Thêm dịch vụ "Giờ chơi" vào hóa đơn với số lượng ban đầu là 0
            int maDV = 1; // Giả sử MaDV của "Giờ chơi" là 1
            int soLuong = 0;

            BillInfoDAO.Instance.InsertBillInfo(idBill, maDV, soLuong);

            MessageBox.Show($"Đã bắt đầu giờ chơi cho bàn {table.TenB}.");
            ShowBill(table.MaB);
            LoadTable();

            //DateTime tgbd = DateTime.Now;

            //ListViewItem item = new ListViewItem("Giờ chơi");
            //item.SubItems.Add("0"); // Số lượng ban đầu
            //item.SubItems.Add("60000"); // Đơn giá
            //item.SubItems.Add("0"); // Tổng tiền ban đầu
            //item.Tag = tgbd; // Lưu thời gian bắt đầu vào Tag

            //lsvBill.Items.Add(item);
            //MessageBox.Show($"Bắt đầu giờ chơi lúc {tgbd:HH:mm:ss}");
        }
        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            // Lấy ID hóa đơn chưa thanh toán
            int idBill = BillDAO.Instance.GetUnCheckBillByTable(table.MaB);

            if (idBill == -1)
            {
                MessageBox.Show("Không tìm thấy hóa đơn để kết thúc!");
                return;
            }

            
            DateTime tgbd = BillDAO.Instance.GetStartTimeByBill(idBill);
            DateTime tgkt = DateTime.Now; 

            
            TimeSpan thoiGianChoi = tgkt - tgbd;
            double soGioChoi = thoiGianChoi.TotalMinutes / 60.0; 
            double tongTien = soGioChoi * 60000; 

            // Cập nhật số lượng "Giờ chơi" trong ChiTietHD
            int maDV = 1; // Giả sử MaDV của "Giờ chơi" là 1
            BillInfoDAO.Instance.UpdateBillInfo(idBill, maDV, soGioChoi);

            // Cập nhật TGKT trong bảng HD
            BillDAO.Instance.UpdateEndTime(idBill, tgkt);

            MessageBox.Show($"Kết thúc giờ chơi cho bàn {table.TenB}.\nThời gian chơi: {soGioChoi:0.00} giờ\nTổng tiền: {tongTien:N0} đồng");
            ShowBill(table.MaB);
            LoadTable();


            //if (lsvBill.Items.Count == 0)
            //{
            //    MessageBox.Show("Không có dịch vụ nào để cập nhật!");
            //    return;
            //}

            //ListViewItem gioChoiItem = lsvBill.Items.Cast<ListViewItem>()
            //    .FirstOrDefault(item => item.Text == "Giờ chơi");

            //if (gioChoiItem == null)
            //{
            //    MessageBox.Show("Dịch vụ 'Giờ chơi' chưa được thêm!");
            //    return;
            //}

            //DateTime tgbd = (DateTime)gioChoiItem.Tag;
            //DateTime tgkt = DateTime.Now;
            //TimeSpan thoiGianChoi = tgkt - tgbd;

            //double soGioChoi = thoiGianChoi.TotalMinutes / 60;
            //double tongTien = soGioChoi * 60000;

            //gioChoiItem.SubItems[1].Text = soGioChoi.ToString("0.00");
            //gioChoiItem.SubItems[3].Text = tongTien.ToString("N0");

            //MessageBox.Show($"Kết thúc giờ chơi lúc {tgkt:HH:mm:ss}\nThời gian chơi: {soGioChoi:0.00} giờ\nTổng tiền: {tongTien:N0} đồng");
        }
        private void ButtonThemDV_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUnCheckBillByTable(table.MaB);
            int maDV = (ComboBoxDV.SelectedItem as DichVuThem).Id;
            int soLuong = (int)NumericUpDownThemDV.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.MaB);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxBill(), maDV, soLuong);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, maDV, soLuong);
            }
            ShowBill(table.MaB);

            LoadTable();
        }


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            //btnCloseChildForm.Visible = false;
        }
        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            if (type == 0)
            {
                OpenChildForm(new FormTaiKhoan(), sender);
            }
            else
                btnTaiKhoan.Enabled = false;
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien(), sender);
        }
        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang(), sender);
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDatBan(), sender);
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDichVu(), sender);
        }

        private void btnQLB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyBan(), sender);
        }
    }
}
