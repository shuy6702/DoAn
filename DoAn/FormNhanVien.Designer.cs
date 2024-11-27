namespace DoAn
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBoxTimKiemNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxHoTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDCNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxThuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxViPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxCong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.ButtonThemNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxTimKiemNV
            // 
            this.TextBoxTimKiemNV.BorderRadius = 6;
            this.TextBoxTimKiemNV.BorderThickness = 3;
            this.TextBoxTimKiemNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTimKiemNV.DefaultText = "";
            this.TextBoxTimKiemNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTimKiemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTimKiemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemNV.DisabledState.Parent = this.TextBoxTimKiemNV;
            this.TextBoxTimKiemNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemNV.FocusedState.Parent = this.TextBoxTimKiemNV;
            this.TextBoxTimKiemNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTimKiemNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemNV.HoverState.Parent = this.TextBoxTimKiemNV;
            this.TextBoxTimKiemNV.Location = new System.Drawing.Point(13, 464);
            this.TextBoxTimKiemNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTimKiemNV.Name = "TextBoxTimKiemNV";
            this.TextBoxTimKiemNV.PasswordChar = '\0';
            this.TextBoxTimKiemNV.PlaceholderText = "Tìm kiếm";
            this.TextBoxTimKiemNV.SelectedText = "";
            this.TextBoxTimKiemNV.ShadowDecoration.Parent = this.TextBoxTimKiemNV;
            this.TextBoxTimKiemNV.Size = new System.Drawing.Size(300, 50);
            this.TextBoxTimKiemNV.TabIndex = 11;
            this.TextBoxTimKiemNV.TextChanged += new System.EventHandler(this.TextBoxTimKiemNV_TextChanged);
            // 
            // DataGridViewNV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewNV.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewNV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewNV.EnableHeadersVisualStyles = false;
            this.DataGridViewNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewNV.Location = new System.Drawing.Point(418, 28);
            this.DataGridViewNV.Name = "DataGridViewNV";
            this.DataGridViewNV.RowHeadersVisible = false;
            this.DataGridViewNV.RowHeadersWidth = 51;
            this.DataGridViewNV.RowTemplate.Height = 24;
            this.DataGridViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewNV.Size = new System.Drawing.Size(599, 413);
            this.DataGridViewNV.TabIndex = 10;
            this.DataGridViewNV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewNV.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewNV.ThemeStyle.ReadOnly = false;
            this.DataGridViewNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewNV.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewNV_CellClick);
            // 
            // TextBoxHoTenNV
            // 
            this.TextBoxHoTenNV.BorderRadius = 6;
            this.TextBoxHoTenNV.BorderThickness = 3;
            this.TextBoxHoTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHoTenNV.DefaultText = "";
            this.TextBoxHoTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxHoTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxHoTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHoTenNV.DisabledState.Parent = this.TextBoxHoTenNV;
            this.TextBoxHoTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHoTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHoTenNV.FocusedState.Parent = this.TextBoxHoTenNV;
            this.TextBoxHoTenNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHoTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHoTenNV.HoverState.Parent = this.TextBoxHoTenNV;
            this.TextBoxHoTenNV.Location = new System.Drawing.Point(13, 28);
            this.TextBoxHoTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHoTenNV.Name = "TextBoxHoTenNV";
            this.TextBoxHoTenNV.PasswordChar = '\0';
            this.TextBoxHoTenNV.PlaceholderText = "Họ Tên NV";
            this.TextBoxHoTenNV.SelectedText = "";
            this.TextBoxHoTenNV.ShadowDecoration.Parent = this.TextBoxHoTenNV;
            this.TextBoxHoTenNV.Size = new System.Drawing.Size(300, 50);
            this.TextBoxHoTenNV.TabIndex = 15;
            // 
            // TextBoxDCNV
            // 
            this.TextBoxDCNV.BorderRadius = 6;
            this.TextBoxDCNV.BorderThickness = 3;
            this.TextBoxDCNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDCNV.DefaultText = "";
            this.TextBoxDCNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDCNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDCNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDCNV.DisabledState.Parent = this.TextBoxDCNV;
            this.TextBoxDCNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDCNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDCNV.FocusedState.Parent = this.TextBoxDCNV;
            this.TextBoxDCNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDCNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDCNV.HoverState.Parent = this.TextBoxDCNV;
            this.TextBoxDCNV.Location = new System.Drawing.Point(13, 97);
            this.TextBoxDCNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDCNV.Name = "TextBoxDCNV";
            this.TextBoxDCNV.PasswordChar = '\0';
            this.TextBoxDCNV.PlaceholderText = "Địa Chỉ ";
            this.TextBoxDCNV.SelectedText = "";
            this.TextBoxDCNV.ShadowDecoration.Parent = this.TextBoxDCNV;
            this.TextBoxDCNV.Size = new System.Drawing.Size(300, 50);
            this.TextBoxDCNV.TabIndex = 16;
            // 
            // TextBoxLuong
            // 
            this.TextBoxLuong.BorderRadius = 6;
            this.TextBoxLuong.BorderThickness = 3;
            this.TextBoxLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLuong.DefaultText = "";
            this.TextBoxLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLuong.DisabledState.Parent = this.TextBoxLuong;
            this.TextBoxLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLuong.FocusedState.Parent = this.TextBoxLuong;
            this.TextBoxLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLuong.HoverState.Parent = this.TextBoxLuong;
            this.TextBoxLuong.Location = new System.Drawing.Point(13, 166);
            this.TextBoxLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxLuong.Name = "TextBoxLuong";
            this.TextBoxLuong.PasswordChar = '\0';
            this.TextBoxLuong.PlaceholderText = "Lương";
            this.TextBoxLuong.SelectedText = "";
            this.TextBoxLuong.ShadowDecoration.Parent = this.TextBoxLuong;
            this.TextBoxLuong.Size = new System.Drawing.Size(300, 50);
            this.TextBoxLuong.TabIndex = 17;
            // 
            // TextBoxThuong
            // 
            this.TextBoxThuong.BorderRadius = 6;
            this.TextBoxThuong.BorderThickness = 3;
            this.TextBoxThuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxThuong.DefaultText = "";
            this.TextBoxThuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxThuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxThuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxThuong.DisabledState.Parent = this.TextBoxThuong;
            this.TextBoxThuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxThuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxThuong.FocusedState.Parent = this.TextBoxThuong;
            this.TextBoxThuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxThuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxThuong.HoverState.Parent = this.TextBoxThuong;
            this.TextBoxThuong.Location = new System.Drawing.Point(13, 239);
            this.TextBoxThuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxThuong.Name = "TextBoxThuong";
            this.TextBoxThuong.PasswordChar = '\0';
            this.TextBoxThuong.PlaceholderText = "Thưởng";
            this.TextBoxThuong.SelectedText = "";
            this.TextBoxThuong.ShadowDecoration.Parent = this.TextBoxThuong;
            this.TextBoxThuong.Size = new System.Drawing.Size(300, 50);
            this.TextBoxThuong.TabIndex = 18;
            // 
            // TextBoxViPham
            // 
            this.TextBoxViPham.BorderRadius = 6;
            this.TextBoxViPham.BorderThickness = 3;
            this.TextBoxViPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxViPham.DefaultText = "";
            this.TextBoxViPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxViPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxViPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxViPham.DisabledState.Parent = this.TextBoxViPham;
            this.TextBoxViPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxViPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxViPham.FocusedState.Parent = this.TextBoxViPham;
            this.TextBoxViPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxViPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxViPham.HoverState.Parent = this.TextBoxViPham;
            this.TextBoxViPham.Location = new System.Drawing.Point(13, 315);
            this.TextBoxViPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxViPham.Name = "TextBoxViPham";
            this.TextBoxViPham.PasswordChar = '\0';
            this.TextBoxViPham.PlaceholderText = "Vi Phạm";
            this.TextBoxViPham.SelectedText = "";
            this.TextBoxViPham.ShadowDecoration.Parent = this.TextBoxViPham;
            this.TextBoxViPham.Size = new System.Drawing.Size(300, 50);
            this.TextBoxViPham.TabIndex = 19;
            // 
            // TextBoxCong
            // 
            this.TextBoxCong.BorderRadius = 6;
            this.TextBoxCong.BorderThickness = 3;
            this.TextBoxCong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCong.DefaultText = "";
            this.TextBoxCong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCong.DisabledState.Parent = this.TextBoxCong;
            this.TextBoxCong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCong.FocusedState.Parent = this.TextBoxCong;
            this.TextBoxCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCong.HoverState.Parent = this.TextBoxCong;
            this.TextBoxCong.Location = new System.Drawing.Point(13, 391);
            this.TextBoxCong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxCong.Name = "TextBoxCong";
            this.TextBoxCong.PasswordChar = '\0';
            this.TextBoxCong.PlaceholderText = "Công";
            this.TextBoxCong.SelectedText = "";
            this.TextBoxCong.ShadowDecoration.Parent = this.TextBoxCong;
            this.TextBoxCong.Size = new System.Drawing.Size(300, 50);
            this.TextBoxCong.TabIndex = 20;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNV.Location = new System.Drawing.Point(900, 464);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(117, 45);
            this.btnXoaNV.TabIndex = 23;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaNV.Location = new System.Drawing.Point(670, 464);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(117, 45);
            this.btnSuaNV.TabIndex = 22;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // ButtonThemNV
            // 
            this.ButtonThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemNV.Location = new System.Drawing.Point(418, 464);
            this.ButtonThemNV.Name = "ButtonThemNV";
            this.ButtonThemNV.Size = new System.Drawing.Size(117, 45);
            this.ButtonThemNV.TabIndex = 21;
            this.ButtonThemNV.Text = "Thêm";
            this.ButtonThemNV.UseVisualStyleBackColor = true;
            this.ButtonThemNV.Click += new System.EventHandler(this.ButtonThemNV_Click_1);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 528);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.ButtonThemNV);
            this.Controls.Add(this.TextBoxCong);
            this.Controls.Add(this.TextBoxViPham);
            this.Controls.Add(this.TextBoxThuong);
            this.Controls.Add(this.TextBoxLuong);
            this.Controls.Add(this.TextBoxDCNV);
            this.Controls.Add(this.TextBoxHoTenNV);
            this.Controls.Add(this.TextBoxTimKiemNV);
            this.Controls.Add(this.DataGridViewNV);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNV";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTimKiemNV;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewNV;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxHoTenNV;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDCNV;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLuong;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxThuong;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxViPham;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCong;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button ButtonThemNV;
    }
}