namespace DoAn
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(12, 86);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(306, 291);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 22;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Đăng nhập";
            // 
            // buttonExit
            // 
            this.buttonExit.BorderRadius = 9;
            this.buttonExit.CheckedState.Parent = this.buttonExit;
            this.buttonExit.CustomImages.Parent = this.buttonExit;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.HoverState.Parent = this.buttonExit;
            this.buttonExit.Location = new System.Drawing.Point(647, 369);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.ShadowDecoration.Parent = this.buttonExit;
            this.buttonExit.Size = new System.Drawing.Size(180, 45);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BorderRadius = 9;
            this.ButtonLogin.CheckedState.Parent = this.ButtonLogin;
            this.ButtonLogin.CustomImages.Parent = this.ButtonLogin;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.HoverState.Parent = this.ButtonLogin;
            this.ButtonLogin.Location = new System.Drawing.Point(412, 369);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.ShadowDecoration.Parent = this.ButtonLogin;
            this.ButtonLogin.Size = new System.Drawing.Size(180, 45);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Đăng nhập";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderRadius = 18;
            this.TextBoxPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextBoxPassword.BorderThickness = 3;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.Parent = this.TextBoxPassword;
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.FocusedState.Parent = this.TextBoxPassword;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.HoverState.Parent = this.TextBoxPassword;
            this.TextBoxPassword.Location = new System.Drawing.Point(412, 248);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Mật khẩu";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.ShadowDecoration.Parent = this.TextBoxPassword;
            this.TextBoxPassword.Size = new System.Drawing.Size(415, 67);
            this.TextBoxPassword.TabIndex = 18;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.BorderRadius = 18;
            this.TextBoxUserName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextBoxUserName.BorderThickness = 3;
            this.TextBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserName.DefaultText = "";
            this.TextBoxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserName.DisabledState.Parent = this.TextBoxUserName;
            this.TextBoxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserName.FocusedState.Parent = this.TextBoxUserName;
            this.TextBoxUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserName.HoverState.Parent = this.TextBoxUserName;
            this.TextBoxUserName.Location = new System.Drawing.Point(412, 119);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.PasswordChar = '\0';
            this.TextBoxUserName.PlaceholderText = "Tên đăng nhập";
            this.TextBoxUserName.SelectedText = "";
            this.TextBoxUserName.ShadowDecoration.Parent = this.TextBoxUserName;
            this.TextBoxUserName.Size = new System.Drawing.Size(415, 67);
            this.TextBoxUserName.TabIndex = 17;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(895, 483);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonExit;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUserName;
    }
}

