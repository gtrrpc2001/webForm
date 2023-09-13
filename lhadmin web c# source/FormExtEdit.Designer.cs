namespace cubemesweb
{
    partial class FormExtEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtEdit));
            this.g = new Wisej.Web.DataGridView();
            this.panel1 = new Wisej.Web.Panel();
            this.btnReload = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.menuGrid = new Wisej.Web.ContextMenu();
            this.menuGridSave = new Wisej.Web.MenuItem();
            this.tmrTick = new Wisej.Web.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.Dock = Wisej.Web.DockStyle.Fill;
            this.g.Location = new System.Drawing.Point(10, 10);
            this.g.Name = "g";
            this.g.RowHeadersVisible = false;
            this.g.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1212, 774);
            this.g.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromName("@highlight");
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1232, 64);
            this.panel1.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Dock = Wisej.Web.DockStyle.Left;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(135, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(102, 54);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "새로고침";
            // 
            // label1
            // 
            this.label1.Dock = Wisej.Web.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "포염 의뢰서";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.ContextMenu = this.menuGrid;
            this.panel2.Controls.Add(this.g);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1232, 794);
            this.panel2.TabIndex = 8;
            // 
            // menuGrid
            // 
            this.menuGrid.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuGridSave});
            this.menuGrid.Name = "menuGrid";
            this.menuGrid.RightToLeft = Wisej.Web.RightToLeft.No;
            // 
            // menuGridSave
            // 
            this.menuGridSave.Index = 0;
            this.menuGridSave.Name = "menuGridSave";
            this.menuGridSave.Text = "상태 저장";
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 10000;
            // 
            // FormExtEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormExtEdit";
            this.Size = new System.Drawing.Size(1232, 794);
            this.Load += new System.EventHandler(this.FormExtEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView g;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button btnReload;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.ContextMenu menuGrid;
        private Wisej.Web.MenuItem menuGridSave;
        private Wisej.Web.Timer tmrTick;
    }
}
