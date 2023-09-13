
namespace cubemesweb.dair_msl
{
    partial class FormEmpECGDataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpECGDataViewer));
            this.btnReload = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.panel4 = new Wisej.Web.Panel();
            this.btnExcel = new Wisej.Web.Button();
            this.btnBack = new Wisej.Web.Button();
            this.line1 = new Wisej.Web.Line();
            this.pBack1 = new Wisej.Web.Panel();
            this.pChart = new Wisej.Web.Panel();
            this.chartBPM = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.btnShowData = new Wisej.Web.Button();
            this.panel7 = new Wisej.Web.Panel();
            this.dtpTimeTo = new Wisej.Web.DateTimePicker();
            this.dtpTimeFrom = new Wisej.Web.DateTimePicker();
            this.dtpTo = new Wisej.Web.DateTimePicker();
            this.label2 = new Wisej.Web.Label();
            this.dtpFrom = new Wisej.Web.DateTimePicker();
            this.pData = new Wisej.Web.Panel();
            this.gvDataList = new Wisej.Web.DataGridView();
            this.Column1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column0 = new Wisej.Web.DataGridViewColumn();
            this.styleSheetDAIR = new Wisej.Web.StyleSheet(this.components);
            this.pLoading = new Wisej.Web.ProgressBar();
            this.panel3 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.panel18 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.panel5 = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.panel4.SuspendLayout();
            this.pBack1.SuspendLayout();
            this.pChart.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Dock = Wisej.Web.DockStyle.Right;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(1130, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(67, 37);
            this.btnReload.TabIndex = 2;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(73, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ECG 기록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExcel);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnReload);
            this.panel4.Controls.Add(this.line1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1197, 45);
            this.panel4.TabIndex = 1;
            this.panel4.TabStop = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = Wisej.Web.DockStyle.Right;
            this.btnExcel.Location = new System.Drawing.Point(1009, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(121, 37);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "엑셀저장";
            
            // 
            // btnBack
            // 
            this.btnBack.Dock = Wisej.Web.DockStyle.Left;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // line1
            // 
            this.line1.Dock = Wisej.Web.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1197, 8);
            // 
            // pBack1
            // 
            this.pBack1.Controls.Add(this.pChart);
            this.pBack1.Controls.Add(this.panel7);
            this.pBack1.Controls.Add(this.panel4);
            this.pBack1.Controls.Add(this.pData);
            this.pBack1.Dock = Wisej.Web.DockStyle.Fill;
            this.pBack1.Location = new System.Drawing.Point(0, 48);
            this.pBack1.Name = "pBack1";
            this.pBack1.Padding = new Wisej.Web.Padding(20);
            this.pBack1.Size = new System.Drawing.Size(1237, 477);
            this.pBack1.TabIndex = 17;
            this.pBack1.TabStop = true;
            // 
            // pChart
            // 
            this.pChart.Controls.Add(this.chartBPM);
            this.pChart.Controls.Add(this.btnShowData);
            this.pChart.Dock = Wisej.Web.DockStyle.Fill;
            this.pChart.Location = new System.Drawing.Point(20, 146);
            this.pChart.Name = "pChart";
            this.pChart.Size = new System.Drawing.Size(1197, 0);
            this.pChart.TabIndex = 2;
            this.pChart.TabStop = true;
            // 
            // chartBPM
            // 
            this.chartBPM.Dock = Wisej.Web.DockStyle.Fill;
            this.chartBPM.Name = "chartBPM";
            this.chartBPM.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartBPM.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartBPM.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartBPM.Options.DataLabel.Opacity = 1F;
            this.chartBPM.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartBPM.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartBPM.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartBPM.Size = new System.Drawing.Size(1197, 0);
            this.chartBPM.TabIndex = 0;
            this.chartBPM.Text = "chartJS1";
            // 
            // btnShowData
            // 
            this.btnShowData.Dock = Wisej.Web.DockStyle.Bottom;
            this.btnShowData.Location = new System.Drawing.Point(0, -46);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(1197, 46);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "데이터 목록 보기";
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel7.Controls.Add(this.dtpTimeTo);
            this.panel7.Controls.Add(this.dtpTimeFrom);
            this.panel7.Controls.Add(this.dtpTo);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.dtpFrom);
            this.styleSheetDAIR.SetCssClass(this.panel7, "rounded-panel");
            this.panel7.Dock = Wisej.Web.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1197, 81);
            this.panel7.TabIndex = 3;
            this.panel7.TabStop = true;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Checked = false;
            this.dtpTimeTo.CustomFormat = "HH:mm:ss";
            this.dtpTimeTo.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTimeTo.Format = Wisej.Web.DateTimePickerFormat.Custom;
            this.dtpTimeTo.Location = new System.Drawing.Point(201, 45);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowCalendar = false;
            this.dtpTimeTo.Size = new System.Drawing.Size(97, 22);
            this.dtpTimeTo.TabIndex = 4;
            this.dtpTimeTo.Value = new System.DateTime(2022, 2, 16, 17, 31, 49, 267);
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Checked = false;
            this.dtpTimeFrom.CustomFormat = "HH:mm:ss";
            this.dtpTimeFrom.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTimeFrom.Format = Wisej.Web.DateTimePickerFormat.Custom;
            this.dtpTimeFrom.Location = new System.Drawing.Point(201, 12);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.ShowCalendar = false;
            this.dtpTimeFrom.Size = new System.Drawing.Size(97, 22);
            this.dtpTimeFrom.TabIndex = 3;
            this.dtpTimeFrom.Value = new System.DateTime(2022, 2, 16, 17, 31, 49, 267);
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTo.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(72, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(123, 22);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.Value = new System.DateTime(2022, 2, 16, 17, 31, 49, 267);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "기간";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFrom.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(72, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(123, 22);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Value = new System.DateTime(2022, 2, 16, 17, 31, 49, 267);
            // 
            // pData
            // 
            this.pData.Controls.Add(this.gvDataList);
            this.pData.Dock = Wisej.Web.DockStyle.Bottom;
            this.pData.Location = new System.Drawing.Point(20, 106);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(1197, 351);
            this.pData.TabIndex = 4;
            this.pData.TabStop = true;
            // 
            // gvDataList
            // 
            this.gvDataList.AllowUserToResizeColumns = false;
            this.gvDataList.AllowUserToResizeRows = false;
            this.gvDataList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column1,
            this.Column0});
            this.gvDataList.Dock = Wisej.Web.DockStyle.Fill;
            this.gvDataList.Location = new System.Drawing.Point(0, 0);
            this.gvDataList.MultiSelect = false;
            this.gvDataList.Name = "gvDataList";
            this.gvDataList.RowHeadersVisible = false;
            this.gvDataList.Size = new System.Drawing.Size(1197, 351);
            this.gvDataList.TabIndex = 1;
            this.gvDataList.VirtualMode = true;
            this.gvDataList.CellValueNeeded += new Wisej.Web.DataGridViewCellValueEventHandler(this.gvEmpList_CellValueNeeded);
            this.gvDataList.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.gvEmpList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "측정시각";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "ECG";
            this.Column0.Name = "Column0";
            // 
            // styleSheetDAIR
            // 
            this.styleSheetDAIR.Styles = ".rounded-groupbox .qx-groupbox-frame\r\n{\r\n    border-radius: 10px\r\n}\r\n\r\n.rounded-p" +
    "anel\r\n{\r\n    border-radius: 10px\r\n}\r\n\r\n.rounded-button\r\n{\r\n    border-radius: 10" +
    "px\r\n}";
            // 
            // pLoading
            // 
            this.pLoading.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.styleSheetDAIR.SetCssClass(this.pLoading, "rounded-panel");
            this.pLoading.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pLoading.Location = new System.Drawing.Point(40, 200);
            this.pLoading.Name = "pLoading";
            this.pLoading.Size = new System.Drawing.Size(310, 118);
            this.pLoading.TabIndex = 18;
            this.pLoading.Text = "데이터 로딩 중...";
            this.pLoading.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel3.Dock = Wisej.Web.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(719, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 48);
            this.panel3.TabIndex = 4;
            this.panel3.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(32, 35, 49);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 48);
            this.panel2.TabIndex = 16;
            this.panel2.TabStop = true;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel18.BackgroundImage")));
            this.panel18.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel18.Dock = Wisej.Web.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(172, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(943, 48);
            this.panel18.TabIndex = 5;
            this.panel18.TabStop = true;
            this.panel18.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(32, 35, 49);
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.button1.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button1.Dock = Wisej.Web.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(1115, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel5.Dock = Wisej.Web.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 48);
            this.panel5.TabIndex = 3;
            this.panel5.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(32, 35, 49);
            this.panel1.Controls.Add(this.panel18);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 48);
            this.panel1.TabIndex = 15;
            this.panel1.TabStop = true;
            // 
            // FormEmpECGDataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.pLoading);
            this.Controls.Add(this.pBack1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpECGDataViewer";
            this.Size = new System.Drawing.Size(1237, 573);
            this.Load += new System.EventHandler(this.FormEmpECGDataViewer_Load);
            this.panel4.ResumeLayout(false);
            this.pBack1.ResumeLayout(false);
            this.pChart.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button btnReload;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Line line1;
        private Wisej.Web.Panel pBack1;
        private Wisej.Web.StyleSheet styleSheetDAIR;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel18;
        private Wisej.Web.Button button1;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel pChart;
        private Wisej.Web.Ext.ChartJS.ChartJS chartBPM;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.Label label2;
        private Wisej.Web.DateTimePicker dtpFrom;
        private Wisej.Web.DateTimePicker dtpTo;
        private Wisej.Web.ProgressBar pLoading;
        private Wisej.Web.DateTimePicker dtpTimeTo;
        private Wisej.Web.DateTimePicker dtpTimeFrom;
        private Wisej.Web.Button btnBack;
        private Wisej.Web.Button btnShowData;
        private Wisej.Web.Panel pData;
        private Wisej.Web.DataGridView gvDataList;
        private Wisej.Web.DataGridViewTextBoxColumn Column1;
        private Wisej.Web.DataGridViewColumn Column0;
        private Wisej.Web.Button btnExcel;
    }
}
