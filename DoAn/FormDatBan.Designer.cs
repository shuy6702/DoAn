namespace DoAn
{
    partial class FormDatBan
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
            this.TextBoxTimKiemDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewDB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxHoTenKHDatBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxSDTDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxGC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaDB = new System.Windows.Forms.Button();
            this.btnSuaDB = new System.Windows.Forms.Button();
            this.ButtonThemDB = new System.Windows.Forms.Button();
            this.DateTimePickerDB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDB)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxTimKiemDB
            // 
            this.TextBoxTimKiemDB.BorderRadius = 6;
            this.TextBoxTimKiemDB.BorderThickness = 3;
            this.TextBoxTimKiemDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTimKiemDB.DefaultText = "";
            this.TextBoxTimKiemDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTimKiemDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTimKiemDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemDB.DisabledState.Parent = this.TextBoxTimKiemDB;
            this.TextBoxTimKiemDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemDB.FocusedState.Parent = this.TextBoxTimKiemDB;
            this.TextBoxTimKiemDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTimKiemDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemDB.HoverState.Parent = this.TextBoxTimKiemDB;
            this.TextBoxTimKiemDB.Location = new System.Drawing.Point(128, 372);
            this.TextBoxTimKiemDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTimKiemDB.Name = "TextBoxTimKiemDB";
            this.TextBoxTimKiemDB.PasswordChar = '\0';
            this.TextBoxTimKiemDB.PlaceholderText = "Tìm kiếm";
            this.TextBoxTimKiemDB.SelectedText = "";
            this.TextBoxTimKiemDB.ShadowDecoration.Parent = this.TextBoxTimKiemDB;
            this.TextBoxTimKiemDB.Size = new System.Drawing.Size(264, 50);
            this.TextBoxTimKiemDB.TabIndex = 26;
            this.TextBoxTimKiemDB.TextChanged += new System.EventHandler(this.TextBoxTimKiemDB_TextChanged);
            // 
            // DataGridViewDB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDB.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDB.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewDB.EnableHeadersVisualStyles = false;
            this.DataGridViewDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDB.Location = new System.Drawing.Point(494, 28);
            this.DataGridViewDB.Name = "DataGridViewDB";
            this.DataGridViewDB.RowHeadersVisible = false;
            this.DataGridViewDB.RowHeadersWidth = 51;
            this.DataGridViewDB.RowTemplate.Height = 24;
            this.DataGridViewDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDB.Size = new System.Drawing.Size(528, 291);
            this.DataGridViewDB.TabIndex = 25;
            this.DataGridViewDB.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewDB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewDB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewDB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewDB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewDB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewDB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewDB.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewDB.ThemeStyle.ReadOnly = false;
            this.DataGridViewDB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewDB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDB.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewDB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDB_CellClick);
            this.DataGridViewDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDB_CellContentClick);
            // 
            // TextBoxHoTenKHDatBan
            // 
            this.TextBoxHoTenKHDatBan.BorderRadius = 6;
            this.TextBoxHoTenKHDatBan.BorderThickness = 3;
            this.TextBoxHoTenKHDatBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHoTenKHDatBan.DefaultText = "";
            this.TextBoxHoTenKHDatBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxHoTenKHDatBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxHoTenKHDatBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHoTenKHDatBan.DisabledState.Parent = this.TextBoxHoTenKHDatBan;
            this.TextBoxHoTenKHDatBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHoTenKHDatBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHoTenKHDatBan.FocusedState.Parent = this.TextBoxHoTenKHDatBan;
            this.TextBoxHoTenKHDatBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHoTenKHDatBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHoTenKHDatBan.HoverState.Parent = this.TextBoxHoTenKHDatBan;
            this.TextBoxHoTenKHDatBan.Location = new System.Drawing.Point(128, 28);
            this.TextBoxHoTenKHDatBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHoTenKHDatBan.Name = "TextBoxHoTenKHDatBan";
            this.TextBoxHoTenKHDatBan.PasswordChar = '\0';
            this.TextBoxHoTenKHDatBan.PlaceholderText = "Họ Tên Khách Hàng";
            this.TextBoxHoTenKHDatBan.SelectedText = "";
            this.TextBoxHoTenKHDatBan.ShadowDecoration.Parent = this.TextBoxHoTenKHDatBan;
            this.TextBoxHoTenKHDatBan.Size = new System.Drawing.Size(264, 50);
            this.TextBoxHoTenKHDatBan.TabIndex = 30;
            // 
            // TextBoxSDTDB
            // 
            this.TextBoxSDTDB.BorderRadius = 6;
            this.TextBoxSDTDB.BorderThickness = 3;
            this.TextBoxSDTDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSDTDB.DefaultText = "";
            this.TextBoxSDTDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSDTDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSDTDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSDTDB.DisabledState.Parent = this.TextBoxSDTDB;
            this.TextBoxSDTDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSDTDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSDTDB.FocusedState.Parent = this.TextBoxSDTDB;
            this.TextBoxSDTDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSDTDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSDTDB.HoverState.Parent = this.TextBoxSDTDB;
            this.TextBoxSDTDB.Location = new System.Drawing.Point(128, 110);
            this.TextBoxSDTDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSDTDB.Name = "TextBoxSDTDB";
            this.TextBoxSDTDB.PasswordChar = '\0';
            this.TextBoxSDTDB.PlaceholderText = "Số Điện Thoại";
            this.TextBoxSDTDB.SelectedText = "";
            this.TextBoxSDTDB.ShadowDecoration.Parent = this.TextBoxSDTDB;
            this.TextBoxSDTDB.Size = new System.Drawing.Size(264, 50);
            this.TextBoxSDTDB.TabIndex = 31;
            // 
            // TextBoxGC
            // 
            this.TextBoxGC.BorderRadius = 6;
            this.TextBoxGC.BorderThickness = 3;
            this.TextBoxGC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGC.DefaultText = "";
            this.TextBoxGC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxGC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxGC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxGC.DisabledState.Parent = this.TextBoxGC;
            this.TextBoxGC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxGC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxGC.FocusedState.Parent = this.TextBoxGC;
            this.TextBoxGC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxGC.HoverState.Parent = this.TextBoxGC;
            this.TextBoxGC.Location = new System.Drawing.Point(128, 269);
            this.TextBoxGC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxGC.Name = "TextBoxGC";
            this.TextBoxGC.PasswordChar = '\0';
            this.TextBoxGC.PlaceholderText = "Ghi chú";
            this.TextBoxGC.SelectedText = "";
            this.TextBoxGC.ShadowDecoration.Parent = this.TextBoxGC;
            this.TextBoxGC.Size = new System.Drawing.Size(264, 50);
            this.TextBoxGC.TabIndex = 33;
            // 
            // btnXoaDB
            // 
            this.btnXoaDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDB.Location = new System.Drawing.Point(905, 372);
            this.btnXoaDB.Name = "btnXoaDB";
            this.btnXoaDB.Size = new System.Drawing.Size(117, 45);
            this.btnXoaDB.TabIndex = 37;
            this.btnXoaDB.Text = "Xóa";
            this.btnXoaDB.UseVisualStyleBackColor = true;
            this.btnXoaDB.Click += new System.EventHandler(this.btnXoaDB_Click);
            // 
            // btnSuaDB
            // 
            this.btnSuaDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDB.Location = new System.Drawing.Point(703, 372);
            this.btnSuaDB.Name = "btnSuaDB";
            this.btnSuaDB.Size = new System.Drawing.Size(117, 45);
            this.btnSuaDB.TabIndex = 36;
            this.btnSuaDB.Text = "Sửa";
            this.btnSuaDB.UseVisualStyleBackColor = true;
            this.btnSuaDB.Click += new System.EventHandler(this.btnSuaDB_Click);
            // 
            // ButtonThemDB
            // 
            this.ButtonThemDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemDB.Location = new System.Drawing.Point(494, 372);
            this.ButtonThemDB.Name = "ButtonThemDB";
            this.ButtonThemDB.Size = new System.Drawing.Size(117, 45);
            this.ButtonThemDB.TabIndex = 35;
            this.ButtonThemDB.Text = "Thêm";
            this.ButtonThemDB.UseVisualStyleBackColor = true;
            this.ButtonThemDB.Click += new System.EventHandler(this.ButtonThemDB_Click_1);
            // 
            // DateTimePickerDB
            // 
            this.DateTimePickerDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDB.Location = new System.Drawing.Point(128, 199);
            this.DateTimePickerDB.Name = "DateTimePickerDB";
            this.DateTimePickerDB.Size = new System.Drawing.Size(264, 34);
            this.DateTimePickerDB.TabIndex = 38;
            // 
            // FormDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.DateTimePickerDB);
            this.Controls.Add(this.btnXoaDB);
            this.Controls.Add(this.btnSuaDB);
            this.Controls.Add(this.ButtonThemDB);
            this.Controls.Add(this.TextBoxGC);
            this.Controls.Add(this.TextBoxSDTDB);
            this.Controls.Add(this.TextBoxHoTenKHDatBan);
            this.Controls.Add(this.TextBoxTimKiemDB);
            this.Controls.Add(this.DataGridViewDB);
            this.Name = "FormDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDatBan";
            this.Load += new System.EventHandler(this.FormDatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTimKiemDB;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewDB;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxHoTenKHDatBan;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSDTDB;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxGC;
        private System.Windows.Forms.Button btnXoaDB;
        private System.Windows.Forms.Button btnSuaDB;
        private System.Windows.Forms.Button ButtonThemDB;
        private System.Windows.Forms.DateTimePicker DateTimePickerDB;
    }
}