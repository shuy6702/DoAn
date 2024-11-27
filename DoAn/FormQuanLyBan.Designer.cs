namespace DoAn
{
    partial class FormQuanLyBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBoxTimKiemBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewQuanLyBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLoaiBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxStatusQLB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXoaB = new System.Windows.Forms.Button();
            this.btnSuaB = new System.Windows.Forms.Button();
            this.ButtonThemB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewQuanLyBan)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxTimKiemBan
            // 
            this.TextBoxTimKiemBan.BorderRadius = 6;
            this.TextBoxTimKiemBan.BorderThickness = 3;
            this.TextBoxTimKiemBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTimKiemBan.DefaultText = "";
            this.TextBoxTimKiemBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTimKiemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTimKiemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemBan.DisabledState.Parent = this.TextBoxTimKiemBan;
            this.TextBoxTimKiemBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTimKiemBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemBan.FocusedState.Parent = this.TextBoxTimKiemBan;
            this.TextBoxTimKiemBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTimKiemBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTimKiemBan.HoverState.Parent = this.TextBoxTimKiemBan;
            this.TextBoxTimKiemBan.Location = new System.Drawing.Point(13, 393);
            this.TextBoxTimKiemBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTimKiemBan.Name = "TextBoxTimKiemBan";
            this.TextBoxTimKiemBan.PasswordChar = '\0';
            this.TextBoxTimKiemBan.PlaceholderText = "Tìm kiếm";
            this.TextBoxTimKiemBan.SelectedText = "";
            this.TextBoxTimKiemBan.ShadowDecoration.Parent = this.TextBoxTimKiemBan;
            this.TextBoxTimKiemBan.Size = new System.Drawing.Size(300, 50);
            this.TextBoxTimKiemBan.TabIndex = 6;
            this.TextBoxTimKiemBan.TextChanged += new System.EventHandler(this.TextBoxTimKiemBan_TextChanged);
            // 
            // DataGridViewQuanLyBan
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridViewQuanLyBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewQuanLyBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewQuanLyBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewQuanLyBan.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewQuanLyBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewQuanLyBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewQuanLyBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewQuanLyBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewQuanLyBan.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewQuanLyBan.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewQuanLyBan.EnableHeadersVisualStyles = false;
            this.DataGridViewQuanLyBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewQuanLyBan.Location = new System.Drawing.Point(438, 79);
            this.DataGridViewQuanLyBan.Name = "DataGridViewQuanLyBan";
            this.DataGridViewQuanLyBan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewQuanLyBan.RowHeadersVisible = false;
            this.DataGridViewQuanLyBan.RowHeadersWidth = 100;
            this.DataGridViewQuanLyBan.RowTemplate.Height = 24;
            this.DataGridViewQuanLyBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewQuanLyBan.Size = new System.Drawing.Size(512, 291);
            this.DataGridViewQuanLyBan.TabIndex = 5;
            this.DataGridViewQuanLyBan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewQuanLyBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewQuanLyBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewQuanLyBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewQuanLyBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewQuanLyBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewQuanLyBan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewQuanLyBan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewQuanLyBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewQuanLyBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewQuanLyBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewQuanLyBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewQuanLyBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewQuanLyBan.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewQuanLyBan.ThemeStyle.ReadOnly = false;
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewQuanLyBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewQuanLyBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewQuanLyBan_CellClick);
            // 
            // TextBoxTenBan
            // 
            this.TextBoxTenBan.BorderRadius = 6;
            this.TextBoxTenBan.BorderThickness = 3;
            this.TextBoxTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTenBan.DefaultText = "";
            this.TextBoxTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTenBan.DisabledState.Parent = this.TextBoxTenBan;
            this.TextBoxTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTenBan.FocusedState.Parent = this.TextBoxTenBan;
            this.TextBoxTenBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTenBan.HoverState.Parent = this.TextBoxTenBan;
            this.TextBoxTenBan.Location = new System.Drawing.Point(53, 79);
            this.TextBoxTenBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTenBan.Name = "TextBoxTenBan";
            this.TextBoxTenBan.PasswordChar = '\0';
            this.TextBoxTenBan.PlaceholderText = "Tên Bàn";
            this.TextBoxTenBan.SelectedText = "";
            this.TextBoxTenBan.ShadowDecoration.Parent = this.TextBoxTenBan;
            this.TextBoxTenBan.Size = new System.Drawing.Size(240, 50);
            this.TextBoxTenBan.TabIndex = 11;
            // 
            // TextBoxLoaiBan
            // 
            this.TextBoxLoaiBan.BorderRadius = 6;
            this.TextBoxLoaiBan.BorderThickness = 3;
            this.TextBoxLoaiBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLoaiBan.DefaultText = "";
            this.TextBoxLoaiBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxLoaiBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxLoaiBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLoaiBan.DisabledState.Parent = this.TextBoxLoaiBan;
            this.TextBoxLoaiBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLoaiBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLoaiBan.FocusedState.Parent = this.TextBoxLoaiBan;
            this.TextBoxLoaiBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoaiBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLoaiBan.HoverState.Parent = this.TextBoxLoaiBan;
            this.TextBoxLoaiBan.Location = new System.Drawing.Point(53, 165);
            this.TextBoxLoaiBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxLoaiBan.Name = "TextBoxLoaiBan";
            this.TextBoxLoaiBan.PasswordChar = '\0';
            this.TextBoxLoaiBan.PlaceholderText = "Loại bàn";
            this.TextBoxLoaiBan.SelectedText = "";
            this.TextBoxLoaiBan.ShadowDecoration.Parent = this.TextBoxLoaiBan;
            this.TextBoxLoaiBan.Size = new System.Drawing.Size(240, 50);
            this.TextBoxLoaiBan.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status Bàn";
            // 
            // ComboBoxStatusQLB
            // 
            this.ComboBoxStatusQLB.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxStatusQLB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStatusQLB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatusQLB.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxStatusQLB.FocusedState.Parent = this.ComboBoxStatusQLB;
            this.ComboBoxStatusQLB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxStatusQLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxStatusQLB.FormattingEnabled = true;
            this.ComboBoxStatusQLB.HoverState.Parent = this.ComboBoxStatusQLB;
            this.ComboBoxStatusQLB.ItemHeight = 30;
            this.ComboBoxStatusQLB.Items.AddRange(new object[] {
            "Có khách",
            "Trống"});
            this.ComboBoxStatusQLB.ItemsAppearance.Parent = this.ComboBoxStatusQLB;
            this.ComboBoxStatusQLB.Location = new System.Drawing.Point(53, 290);
            this.ComboBoxStatusQLB.Name = "ComboBoxStatusQLB";
            this.ComboBoxStatusQLB.ShadowDecoration.Parent = this.ComboBoxStatusQLB;
            this.ComboBoxStatusQLB.Size = new System.Drawing.Size(240, 36);
            this.ComboBoxStatusQLB.TabIndex = 13;
            // 
            // btnXoaB
            // 
            this.btnXoaB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaB.Location = new System.Drawing.Point(833, 431);
            this.btnXoaB.Name = "btnXoaB";
            this.btnXoaB.Size = new System.Drawing.Size(117, 45);
            this.btnXoaB.TabIndex = 17;
            this.btnXoaB.Text = "Xóa";
            this.btnXoaB.UseVisualStyleBackColor = true;
            this.btnXoaB.Click += new System.EventHandler(this.btnXoaB_Click);
            // 
            // btnSuaB
            // 
            this.btnSuaB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaB.Location = new System.Drawing.Point(635, 431);
            this.btnSuaB.Name = "btnSuaB";
            this.btnSuaB.Size = new System.Drawing.Size(117, 45);
            this.btnSuaB.TabIndex = 16;
            this.btnSuaB.Text = "Sửa";
            this.btnSuaB.UseVisualStyleBackColor = true;
            this.btnSuaB.Click += new System.EventHandler(this.btnSuaB_Click);
            // 
            // ButtonThemB
            // 
            this.ButtonThemB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemB.Location = new System.Drawing.Point(438, 431);
            this.ButtonThemB.Name = "ButtonThemB";
            this.ButtonThemB.Size = new System.Drawing.Size(117, 45);
            this.ButtonThemB.TabIndex = 15;
            this.ButtonThemB.Text = "Thêm";
            this.ButtonThemB.UseVisualStyleBackColor = true;
            this.ButtonThemB.Click += new System.EventHandler(this.ButtonThemB_Click);
            // 
            // FormQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 553);
            this.Controls.Add(this.btnXoaB);
            this.Controls.Add(this.btnSuaB);
            this.Controls.Add(this.ButtonThemB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxStatusQLB);
            this.Controls.Add(this.TextBoxLoaiBan);
            this.Controls.Add(this.TextBoxTenBan);
            this.Controls.Add(this.TextBoxTimKiemBan);
            this.Controls.Add(this.DataGridViewQuanLyBan);
            this.Name = "FormQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQuanLyBan";
            this.Load += new System.EventHandler(this.FormQuanLyBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewQuanLyBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTimKiemBan;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewQuanLyBan;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTenBan;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLoaiBan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxStatusQLB;
        private System.Windows.Forms.Button btnXoaB;
        private System.Windows.Forms.Button btnSuaB;
        private System.Windows.Forms.Button ButtonThemB;
    }
}