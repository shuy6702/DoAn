namespace DoAn
{
    partial class FormDichVu
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
            this.TextBoxTimKiemDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxTenDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDVT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.ButtonThemDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDV)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxTimKiemDV
            // 
            this.TextBoxTimKiemDV.BorderRadius = 6;
            this.TextBoxTimKiemDV.BorderThickness = 3;
            this.TextBoxTimKiemDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTimKiemDV.DefaultText = "";
            this.TextBoxTimKiemDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTimKiemDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTimKiemDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemDV.DisabledState.Parent = this.TextBoxTimKiemDV;
            this.TextBoxTimKiemDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemDV.FocusedState.Parent = this.TextBoxTimKiemDV;
            this.TextBoxTimKiemDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTimKiemDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemDV.HoverState.Parent = this.TextBoxTimKiemDV;
            this.TextBoxTimKiemDV.Location = new System.Drawing.Point(95, 395);
            this.TextBoxTimKiemDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTimKiemDV.Name = "TextBoxTimKiemDV";
            this.TextBoxTimKiemDV.PasswordChar = '\0';
            this.TextBoxTimKiemDV.PlaceholderText = "Tìm kiếm";
            this.TextBoxTimKiemDV.SelectedText = "";
            this.TextBoxTimKiemDV.ShadowDecoration.Parent = this.TextBoxTimKiemDV;
            this.TextBoxTimKiemDV.Size = new System.Drawing.Size(238, 50);
            this.TextBoxTimKiemDV.TabIndex = 21;
            this.TextBoxTimKiemDV.TextChanged += new System.EventHandler(this.TextBoxTimKiemDV_TextChanged);
            // 
            // DataGridViewDV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDV.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewDV.EnableHeadersVisualStyles = false;
            this.DataGridViewDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDV.Location = new System.Drawing.Point(389, 28);
            this.DataGridViewDV.Name = "DataGridViewDV";
            this.DataGridViewDV.RowHeadersVisible = false;
            this.DataGridViewDV.RowHeadersWidth = 51;
            this.DataGridViewDV.RowTemplate.Height = 24;
            this.DataGridViewDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDV.Size = new System.Drawing.Size(483, 291);
            this.DataGridViewDV.TabIndex = 20;
            this.DataGridViewDV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewDV.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewDV.ThemeStyle.ReadOnly = false;
            this.DataGridViewDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDV.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDV_CellClick);
            // 
            // TextBoxTenDV
            // 
            this.TextBoxTenDV.BorderRadius = 6;
            this.TextBoxTenDV.BorderThickness = 3;
            this.TextBoxTenDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTenDV.DefaultText = "";
            this.TextBoxTenDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTenDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTenDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTenDV.DisabledState.Parent = this.TextBoxTenDV;
            this.TextBoxTenDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTenDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTenDV.FocusedState.Parent = this.TextBoxTenDV;
            this.TextBoxTenDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTenDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTenDV.HoverState.Parent = this.TextBoxTenDV;
            this.TextBoxTenDV.Location = new System.Drawing.Point(95, 28);
            this.TextBoxTenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTenDV.Name = "TextBoxTenDV";
            this.TextBoxTenDV.PasswordChar = '\0';
            this.TextBoxTenDV.PlaceholderText = "Tên Dịch Vụ";
            this.TextBoxTenDV.SelectedText = "";
            this.TextBoxTenDV.ShadowDecoration.Parent = this.TextBoxTenDV;
            this.TextBoxTenDV.Size = new System.Drawing.Size(238, 50);
            this.TextBoxTenDV.TabIndex = 25;
            // 
            // TextBoxDonGia
            // 
            this.TextBoxDonGia.BorderRadius = 6;
            this.TextBoxDonGia.BorderThickness = 3;
            this.TextBoxDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDonGia.DefaultText = "";
            this.TextBoxDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDonGia.DisabledState.Parent = this.TextBoxDonGia;
            this.TextBoxDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDonGia.FocusedState.Parent = this.TextBoxDonGia;
            this.TextBoxDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDonGia.HoverState.Parent = this.TextBoxDonGia;
            this.TextBoxDonGia.Location = new System.Drawing.Point(95, 110);
            this.TextBoxDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDonGia.Name = "TextBoxDonGia";
            this.TextBoxDonGia.PasswordChar = '\0';
            this.TextBoxDonGia.PlaceholderText = "Đơn Giá";
            this.TextBoxDonGia.SelectedText = "";
            this.TextBoxDonGia.ShadowDecoration.Parent = this.TextBoxDonGia;
            this.TextBoxDonGia.Size = new System.Drawing.Size(238, 50);
            this.TextBoxDonGia.TabIndex = 26;
            // 
            // TextBoxDVT
            // 
            this.TextBoxDVT.BorderRadius = 6;
            this.TextBoxDVT.BorderThickness = 3;
            this.TextBoxDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDVT.DefaultText = "";
            this.TextBoxDVT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDVT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDVT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDVT.DisabledState.Parent = this.TextBoxDVT;
            this.TextBoxDVT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDVT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDVT.FocusedState.Parent = this.TextBoxDVT;
            this.TextBoxDVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDVT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDVT.HoverState.Parent = this.TextBoxDVT;
            this.TextBoxDVT.Location = new System.Drawing.Point(95, 197);
            this.TextBoxDVT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDVT.Name = "TextBoxDVT";
            this.TextBoxDVT.PasswordChar = '\0';
            this.TextBoxDVT.PlaceholderText = "Đơn Vị Tính";
            this.TextBoxDVT.SelectedText = "";
            this.TextBoxDVT.ShadowDecoration.Parent = this.TextBoxDVT;
            this.TextBoxDVT.Size = new System.Drawing.Size(238, 50);
            this.TextBoxDVT.TabIndex = 27;
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDV.Location = new System.Drawing.Point(755, 400);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(117, 45);
            this.btnXoaDV.TabIndex = 30;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDV.Location = new System.Drawing.Point(573, 400);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(117, 45);
            this.btnSuaDV.TabIndex = 29;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // ButtonThemDV
            // 
            this.ButtonThemDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemDV.Location = new System.Drawing.Point(389, 400);
            this.ButtonThemDV.Name = "ButtonThemDV";
            this.ButtonThemDV.Size = new System.Drawing.Size(117, 45);
            this.ButtonThemDV.TabIndex = 28;
            this.ButtonThemDV.Text = "Thêm";
            this.ButtonThemDV.UseVisualStyleBackColor = true;
            this.ButtonThemDV.Click += new System.EventHandler(this.ButtonThemDV_Click_1);
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 478);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.ButtonThemDV);
            this.Controls.Add(this.TextBoxDVT);
            this.Controls.Add(this.TextBoxDonGia);
            this.Controls.Add(this.TextBoxTenDV);
            this.Controls.Add(this.TextBoxTimKiemDV);
            this.Controls.Add(this.DataGridViewDV);
            this.Name = "FormDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDichVu";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTimKiemDV;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewDV;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTenDV;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDonGia;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDVT;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button ButtonThemDV;
    }
}