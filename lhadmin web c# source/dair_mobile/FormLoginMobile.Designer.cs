
namespace cubemesweb
{
    partial class FormLoginMobile
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginMobile));
            this.pLogin = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.btnRegister = new Wisej.Web.Button();
            this.btnLogin = new Wisej.Web.Button();
            this.chkAutoLogin = new Wisej.Web.CheckBox();
            this.panel2 = new Wisej.Web.Panel();
            this.edtPW = new Wisej.Web.TextBox();
            this.pLogo = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.edtID = new Wisej.Web.TextBox();
            this.txtTitle = new Wisej.Web.Label();
            this.styleSheetDAIR = new Wisej.Web.StyleSheet(this.components);
            this.pBackTop = new Wisej.Web.Panel();
            this.pLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.Transparent;
            this.pLogin.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.pLogin.Controls.Add(this.panel3);
            this.pLogin.Controls.Add(this.txtTitle);
            this.pLogin.Location = new System.Drawing.Point(536, 245);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(360, 640);
            this.pLogin.TabIndex = 0;
            this.pLogin.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.Controls.Add(this.btnRegister);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.chkAutoLogin);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pLogo);
            this.panel3.Controls.Add(this.panel1);
            this.styleSheetDAIR.SetCssClass(this.panel3, "rounded-panel");
            this.panel3.CssClass = "rounded-panel";
            this.panel3.Location = new System.Drawing.Point(41, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 455);
            this.panel3.TabIndex = 7;
            this.panel3.TabStop = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(248, 103, 141);
            this.styleSheetDAIR.SetCssClass(this.btnRegister, "rounded-button");
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(26, 382);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(235, 36);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "회원가입";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(117, 88, 230);
            this.styleSheetDAIR.SetCssClass(this.btnLogin, "rounded-button");
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(26, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(235, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "로그인";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.Appearance = Wisej.Web.Appearance.Switch;
            this.chkAutoLogin.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkAutoLogin.Location = new System.Drawing.Point(26, 298);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(135, 24);
            this.chkAutoLogin.TabIndex = 4;
            this.chkAutoLogin.Text = "비밀번호 저장";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel2.Controls.Add(this.edtPW);
            this.styleSheetDAIR.SetCssClass(this.panel2, "rounded-panel");
            this.panel2.Location = new System.Drawing.Point(26, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 36);
            this.panel2.TabIndex = 3;
            this.panel2.TabStop = true;
            // 
            // edtPW
            // 
            this.edtPW.BorderStyle = Wisej.Web.BorderStyle.None;
            this.edtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edtPW.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.edtPW.Location = new System.Drawing.Point(18, 8);
            this.edtPW.Name = "edtPW";
            this.edtPW.PasswordChar = '*';
            this.edtPW.Size = new System.Drawing.Size(196, 22);
            this.edtPW.TabIndex = 0;
            this.edtPW.Text = "admin";
            this.edtPW.Watermark = "비밀번호";
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLogo.BackgroundImage")));
            this.pLogo.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.pLogo.Location = new System.Drawing.Point(26, 21);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(235, 157);
            this.pLogo.TabIndex = 2;
            this.pLogo.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Controls.Add(this.edtID);
            this.styleSheetDAIR.SetCssClass(this.panel1, "rounded-panel");
            this.panel1.Location = new System.Drawing.Point(26, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 36);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // edtID
            // 
            this.edtID.BorderStyle = Wisej.Web.BorderStyle.None;
            this.edtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edtID.Location = new System.Drawing.Point(18, 8);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(196, 22);
            this.edtID.TabIndex = 0;
            this.edtID.Text = "admin";
            this.edtID.Watermark = "아이디";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(28, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(315, 54);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "온도/SpO2 관리자";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTitle.Visible = false;
            // 
            // styleSheetDAIR
            // 
            this.styleSheetDAIR.Styles = ".rounded-groupbox .qx-groupbox-frame\r\n{\r\n    border-radius: 10px\r\n}\r\n\r\n.rounded-p" +
    "anel\r\n{\r\n    border-radius: 10px\r\n}\r\n\r\n.rounded-button\r\n{\r\n    border-radius: 10" +
    "px\r\n}";
            // 
            // pBackTop
            // 
            this.pBackTop.BackColor = System.Drawing.Color.FromArgb(0, 132, 198);
            this.pBackTop.Dock = Wisej.Web.DockStyle.Top;
            this.pBackTop.Location = new System.Drawing.Point(0, 0);
            this.pBackTop.Name = "pBackTop";
            this.pBackTop.Size = new System.Drawing.Size(1262, 239);
            this.pBackTop.TabIndex = 1;
            this.pBackTop.TabStop = true;
            this.pBackTop.Visible = false;
            // 
            // FormLoginMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pBackTop);
            this.Name = "FormLoginMobile";
            this.Size = new System.Drawing.Size(1245, 573);
            this.Resize += new System.EventHandler(this.FormLoginMobile_Resize);
            this.pLogin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pLogin;
        private Wisej.Web.Label txtTitle;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.StyleSheet styleSheetDAIR;
        private Wisej.Web.Panel pBackTop;
        private Wisej.Web.Panel pLogo;
        private Wisej.Web.TextBox edtID;
        private Wisej.Web.CheckBox chkAutoLogin;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.TextBox edtPW;
        private Wisej.Web.Button btnLogin;
        private Wisej.Web.Button btnRegister;
        private Wisej.Web.Panel panel3;
    }
}
