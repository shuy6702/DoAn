namespace DoAn
{
    partial class FormKhachHang
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
            this.TextBoxTimKiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxHoTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxSDTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.ButtonThemKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxTimKiemKH
            // 
            this.TextBoxTimKiemKH.BorderRadius = 6;
            this.TextBoxTimKiemKH.BorderThickness = 3;
            this.TextBoxTimKiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTimKiemKH.DefaultText = "";
            this.TextBoxTimKiemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTimKiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTimKiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemKH.DisabledState.Parent = this.TextBoxTimKiemKH;
            this.TextBoxTimKiemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemKH.FocusedState.Parent = this.TextBoxTimKiemKH;
            this.TextBoxTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTimKiemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemKH.HoverState.Parent = this.TextBoxTimKiemKH;
            this.TextBoxTimKiemKH.Location = new System.Drawing.Point(111, 401);
            this.TextBoxTimKiemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTimKiemKH.Name = "TextBoxTimKiemKH";
            this.TextBoxTimKiemKH.PasswordChar = '\0';
            this.TextBoxTimKiemKH.PlaceholderText = "Tìm kiếm";
            this.TextBoxTimKiemKH.SelectedText = "";
            this.TextBoxTimKiemKH.ShadowDecoration.Parent = this.TextBoxTimKiemKH;
            this.TextBoxTimKiemKH.Size = new System.Drawing.Size(243, 50);
            this.TextBoxTimKiemKH.TabIndex = 16;
            this.TextBoxTimKiemKH.TextChanged += new System.EventHandler(this.TextBoxTimKiemKH_TextChanged);
            // 
            // DataGridViewKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewKH.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewKH.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewKH.EnableHeadersVisualStyles = false;
            this.DataGridViewKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewKH.Location = new System.Drawing.Point(431, 57);
            this.DataGridViewKH.Name = "DataGridViewKH";
            this.DataGridViewKH.RowHeadersVisible = false;
            this.DataGridViewKH.RowHeadersWidth = 51;
            this.DataGridViewKH.RowTemplate.Height = 24;
            this.DataGridViewKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewKH.Size = new System.Drawing.Size(520, 336);
            this.DataGridViewKH.TabIndex = 15;
            this.DataGridViewKH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewKH.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewKH.ThemeStyle.ReadOnly = false;
            this.DataGridViewKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewKH.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKH_CellClick);
            // 
            // TextBoxHoTenKH
            // 
            this.TextBoxHoTenKH.BorderRadius = 6;
            this.TextBoxHoTenKH.BorderThickness = 3;
            this.TextBoxHoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHoTenKH.DefaultText = "";
            this.TextBoxHoTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxHoTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxHoTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHoTenKH.DisabledState.Parent = this.TextBoxHoTenKH;
            this.TextBoxHoTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHoTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHoTenKH.FocusedState.Parent = this.TextBoxHoTenKH;
            this.TextBoxHoTenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHoTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHoTenKH.HoverState.Parent = this.TextBoxHoTenKH;
            this.TextBoxHoTenKH.Location = new System.Drawing.Point(112, 57);
            this.TextBoxHoTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHoTenKH.Name = "TextBoxHoTenKH";
            this.TextBoxHoTenKH.PasswordChar = '\0';
            this.TextBoxHoTenKH.PlaceholderText = "Họ Tên";
            this.TextBoxHoTenKH.SelectedText = "";
            this.TextBoxHoTenKH.ShadowDecoration.Parent = this.TextBoxHoTenKH;
            this.TextBoxHoTenKH.Size = new System.Drawing.Size(242, 50);
            this.TextBoxHoTenKH.TabIndex = 20;
            // 
            // TextBoxDiemKH
            // 
            this.TextBoxDiemKH.BorderRadius = 6;
            this.TextBoxDiemKH.BorderThickness = 3;
            this.TextBoxDiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDiemKH.DefaultText = "";
            this.TextBoxDiemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDiemKH.DisabledState.Parent = this.TextBoxDiemKH;
            this.TextBoxDiemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDiemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDiemKH.FocusedState.Parent = this.TextBoxDiemKH;
            this.TextBoxDiemKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDiemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDiemKH.HoverState.Parent = this.TextBoxDiemKH;
            this.TextBoxDiemKH.Location = new System.Drawing.Point(112, 298);
            this.TextBoxDiemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDiemKH.Name = "TextBoxDiemKH";
            this.TextBoxDiemKH.PasswordChar = '\0';
            this.TextBoxDiemKH.PlaceholderText = "Điểm";
            this.TextBoxDiemKH.SelectedText = "";
            this.TextBoxDiemKH.ShadowDecoration.Parent = this.TextBoxDiemKH;
            this.TextBoxDiemKH.Size = new System.Drawing.Size(242, 50);
            this.TextBoxDiemKH.TabIndex = 21;
            // 
            // TextBoxSDTKH
            // 
            this.TextBoxSDTKH.BorderRadius = 6;
            this.TextBoxSDTKH.BorderThickness = 3;
            this.TextBoxSDTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSDTKH.DefaultText = "";
            this.TextBoxSDTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSDTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSDTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSDTKH.DisabledState.Parent = this.TextBoxSDTKH;
            this.TextBoxSDTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSDTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSDTKH.FocusedState.Parent = this.TextBoxSDTKH;
            this.TextBoxSDTKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSDTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSDTKH.HoverState.Parent = this.TextBoxSDTKH;
            this.TextBoxSDTKH.Location = new System.Drawing.Point(112, 138);
            this.TextBoxSDTKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSDTKH.Name = "TextBoxSDTKH";
            this.TextBoxSDTKH.PasswordChar = '\0';
            this.TextBoxSDTKH.PlaceholderText = "Số Điện thoại";
            this.TextBoxSDTKH.SelectedText = "";
            this.TextBoxSDTKH.ShadowDecoration.Parent = this.TextBoxSDTKH;
            this.TextBoxSDTKH.Size = new System.Drawing.Size(242, 50);
            this.TextBoxSDTKH.TabIndex = 22;
            // 
            // TextBoxCCCD
            // 
            this.TextBoxCCCD.BorderRadius = 6;
            this.TextBoxCCCD.BorderThickness = 3;
            this.TextBoxCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCCCD.DefaultText = "";
            this.TextBoxCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCCCD.DisabledState.Parent = this.TextBoxCCCD;
            this.TextBoxCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCCCD.FocusedState.Parent = this.TextBoxCCCD;
            this.TextBoxCCCD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCCCD.HoverState.Parent = this.TextBoxCCCD;
            this.TextBoxCCCD.Location = new System.Drawing.Point(112, 215);
            this.TextBoxCCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxCCCD.Name = "TextBoxCCCD";
            this.TextBoxCCCD.PasswordChar = '\0';
            this.TextBoxCCCD.PlaceholderText = "CCCD";
            this.TextBoxCCCD.SelectedText = "";
            this.TextBoxCCCD.ShadowDecoration.Parent = this.TextBoxCCCD;
            this.TextBoxCCCD.Size = new System.Drawing.Size(242, 50);
            this.TextBoxCCCD.TabIndex = 23;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Location = new System.Drawing.Point(834, 423);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(117, 45);
            this.btnXoaKH.TabIndex = 26;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Location = new System.Drawing.Point(636, 423);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(117, 45);
            this.btnSuaKH.TabIndex = 25;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // ButtonThemKH
            // 
            this.ButtonThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThemKH.Location = new System.Drawing.Point(431, 423);
            this.ButtonThemKH.Name = "ButtonThemKH";
            this.ButtonThemKH.Size = new System.Drawing.Size(117, 45);
            this.ButtonThemKH.TabIndex = 24;
            this.ButtonThemKH.Text = "Thêm";
            this.ButtonThemKH.UseVisualStyleBackColor = true;
            this.ButtonThemKH.Click += new System.EventHandler(this.ButtonThemKH_Click_1);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 495);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.ButtonThemKH);
            this.Controls.Add(this.TextBoxCCCD);
            this.Controls.Add(this.TextBoxSDTKH);
            this.Controls.Add(this.TextBoxDiemKH);
            this.Controls.Add(this.TextBoxHoTenKH);
            this.Controls.Add(this.TextBoxTimKiemKH);
            this.Controls.Add(this.DataGridViewKH);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTimKiemKH;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewKH;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxHoTenKH;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDiemKH;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSDTKH;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCCCD;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button ButtonThemKH;
    }
}