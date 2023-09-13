
namespace cubemesweb.dair_mobile
{
    partial class FormTableViewer
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableViewer));
            this.dataGridViewColumn8 = new Wisej.Web.DataGridViewColumn();
            this.panel2 = new Wisej.Web.Panel();
            this.gv = new Wisej.Web.DataGridView();
            this.pTabCover = new Wisej.Web.Panel();
            this.txtTab = new Wisej.Web.Label();
            this.line1 = new Wisej.Web.Line();
            this.styleSheetDAIR = new Wisej.Web.StyleSheet(this.components);
            this.panel4 = new Wisej.Web.Panel();
            this.txtTitle = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.btnReload = new Wisej.Web.Button();
            this.line2 = new Wisej.Web.Line();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pTabCover.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewColumn8
            // 
            this.dataGridViewColumn8.HeaderText = "의뢰일자";
            this.dataGridViewColumn8.Name = "dataGridViewColumn8";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gv);
            this.panel2.Controls.Add(this.pTabCover);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(10, 0, 10, 10);
            this.panel2.Size = new System.Drawing.Size(1237, 528);
            this.panel2.TabIndex = 4;
            this.panel2.TabStop = true;
            // 
            // gv
            // 
            this.gv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(122, 122, 122);
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.styleSheetDAIR.SetCssClass(this.gv, "rounded-panel");
            this.gv.Dock = Wisej.Web.DockStyle.Fill;
            this.gv.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv.Location = new System.Drawing.Point(10, 5);
            this.gv.Name = "gv";
            this.gv.RowHeadersVisible = false;
            this.gv.Size = new System.Drawing.Size(1217, 513);
            this.gv.TabIndex = 8;
            this.gv.VirtualMode = true;
            // 
            // pTabCover
            // 
            this.pTabCover.Controls.Add(this.txtTab);
            this.pTabCover.Controls.Add(this.line1);
            this.pTabCover.Dock = Wisej.Web.DockStyle.Top;
            this.pTabCover.Location = new System.Drawing.Point(10, 0);
            this.pTabCover.Name = "pTabCover";
            this.pTabCover.Size = new System.Drawing.Size(1217, 5);
            this.pTabCover.TabIndex = 2;
            this.pTabCover.TabStop = true;
            // 
            // txtTab
            // 
            this.txtTab.Dock = Wisej.Web.DockStyle.Fill;
            this.txtTab.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTab.Location = new System.Drawing.Point(0, 8);
            this.txtTab.Name = "txtTab";
            this.txtTab.Size = new System.Drawing.Size(1217, 0);
            this.txtTab.TabIndex = 2;
            this.txtTab.Text = "고객사 목록";
            this.txtTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line1
            // 
            this.line1.Dock = Wisej.Web.DockStyle.Top;
            this.line1.LineColor = System.Drawing.Color.Gainsboro;
            this.line1.Location = new System.Drawing.Point(0, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1217, 8);
            // 
            // styleSheetDAIR
            // 
            this.styleSheetDAIR.Styles = resources.GetString("styleSheetDAIR.Styles");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTitle);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnReload);
            this.panel4.Controls.Add(this.line2);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1237, 45);
            this.panel4.TabIndex = 5;
            this.panel4.TabStop = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = Wisej.Web.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.Location = new System.Drawing.Point(67, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1103, 37);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "-";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Dock = Wisej.Web.DockStyle.Left;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 37);
            this.button1.TabIndex = 5;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReload
            // 
            this.btnReload.Dock = Wisej.Web.DockStyle.Right;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(1170, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(67, 37);
            this.btnReload.TabIndex = 2;
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Bottom;
            this.line2.Location = new System.Drawing.Point(0, 37);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1237, 8);
            // 
            // FormTableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "FormTableViewer";
            this.Size = new System.Drawing.Size(1237, 573);
            this.Load += new System.EventHandler(this.FormTableViewer_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pTabCover.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.DataGridViewColumn dataGridViewColumn8;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel pTabCover;
        private Wisej.Web.Label txtTab;
        private Wisej.Web.Line line1;
        private Wisej.Web.DataGridView gv;
        private Wisej.Web.StyleSheet styleSheetDAIR;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button btnReload;
        private Wisej.Web.Line line2;
        public Wisej.Web.Label txtTitle;
    }
}
