
namespace cubemesweb.dair_wrapdust
{
    partial class FormLHReport
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
            this.styleSheetDAIR = new Wisej.Web.StyleSheet(this.components);
            this.panel1 = new Wisej.Web.Panel();
            this.btnLogin = new Wisej.Web.Button();
            this.dtpTo = new Wisej.Web.DateTimePicker();
            this.label2 = new Wisej.Web.Label();
            this.dtpFrom = new Wisej.Web.DateTimePicker();
            this.btnRegister = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleSheetDAIR
            // 
            this.styleSheetDAIR.Styles = ".rounded-groupbox .qx-groupbox-frame\r\n{\r\n    border-radius: 10px\r\n}\r\n\r\n.rounded-p" +
    "anel\r\n{\r\n    border-radius: 10px\r\n}\r\n\r\n.rounded-button\r\n{\r\n    border-radius: 10" +
    "px\r\n}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFrom);
            this.styleSheetDAIR.SetCssClass(this.panel1, "rounded-panel");
            this.panel1.Location = new System.Drawing.Point(30, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(455, 97);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(117, 88, 230);
            this.styleSheetDAIR.SetCssClass(this.btnLogin, "rounded-button");
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(240, 18);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 62);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "보고서 만들기(pdf)";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTo.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(92, 56);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(123, 22);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.Value = new System.DateTime(2022, 2, 16, 17, 31, 49, 267);
            this.dtpTo.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "기간";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFrom.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(92, 40);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(123, 22);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.Value = new System.DateTime(2022, 2, 16, 17, 31, 49, 267);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(248, 103, 141);
            this.styleSheetDAIR.SetCssClass(this.btnRegister, "rounded-button");
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(270, 154);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(215, 62);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "닫기";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormLHReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(32, 35, 49);
            this.ClientSize = new System.Drawing.Size(516, 240);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.Name = "FormLHReport";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "확인";
            this.Shown += new System.EventHandler(this.FormLHReport_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.StyleSheet styleSheetDAIR;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button btnRegister;
        private Wisej.Web.Button btnLogin;
        private Wisej.Web.DateTimePicker dtpTo;
        private Wisej.Web.Label label2;
        private Wisej.Web.DateTimePicker dtpFrom;
    }
}