
namespace cubemesweb.dair_msl
{
    partial class FormEmpInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpInfo));
            this.btnReload = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.panel4 = new Wisej.Web.Panel();
            this.btnBack = new Wisej.Web.Button();
            this.line1 = new Wisej.Web.Line();
            this.pBack1 = new Wisej.Web.Panel();
            this.panel6 = new Wisej.Web.Panel();
            this.chartBPM = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.panel9 = new Wisej.Web.Panel();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.btnEmpARRDataViewer = new Wisej.Web.Button();
            this.btnEmpChartViewer = new Wisej.Web.Button();
            this.btnEmpDataViewer = new Wisej.Web.Button();
            this.panel7 = new Wisej.Web.Panel();
            this.txtEmpName = new Wisej.Web.Label();
            this.btnReport = new Wisej.Web.Button();
            this.txtBPMTime = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.txtBPMMinMax = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.txtBPMNow = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.txtName = new Wisej.Web.Label();
            this.panel8 = new Wisej.Web.Panel();
            this.styleSheetDAIR = new Wisej.Web.StyleSheet(this.components);
            this.pLoading = new Wisej.Web.ProgressBar();
            this.panel3 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.panel18 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.panel5 = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.timerTick = new Wisej.Web.Timer(this.components);
            this.panel4.SuspendLayout();
            this.pBack1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.label1.Text = "실시간 모니터링";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
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
            this.pBack1.Controls.Add(this.panel6);
            this.pBack1.Controls.Add(this.panel9);
            this.pBack1.Controls.Add(this.panel7);
            this.pBack1.Controls.Add(this.panel4);
            this.pBack1.Dock = Wisej.Web.DockStyle.Fill;
            this.pBack1.Location = new System.Drawing.Point(0, 48);
            this.pBack1.Name = "pBack1";
            this.pBack1.Padding = new Wisej.Web.Padding(20);
            this.pBack1.Size = new System.Drawing.Size(1237, 659);
            this.pBack1.TabIndex = 17;
            this.pBack1.TabStop = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chartBPM);
            this.panel6.Dock = Wisej.Web.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(20, 146);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Wisej.Web.Padding(0, 10, 0, 10);
            this.panel6.Size = new System.Drawing.Size(1197, 360);
            this.panel6.TabIndex = 2;
            this.panel6.TabStop = true;
            // 
            // chartBPM
            // 
            this.chartBPM.Dock = Wisej.Web.DockStyle.Fill;
            this.chartBPM.Location = new System.Drawing.Point(0, 10);
            this.chartBPM.Name = "chartBPM";
            this.chartBPM.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartBPM.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartBPM.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartBPM.Options.DataLabel.Opacity = 1F;
            this.chartBPM.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartBPM.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartBPM.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartBPM.Size = new System.Drawing.Size(1197, 340);
            this.chartBPM.TabIndex = 0;
            this.chartBPM.Text = "chartJS1";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel9.Controls.Add(this.tableLayoutPanel1);
            this.styleSheetDAIR.SetCssClass(this.panel9, "rounded-panel");
            this.panel9.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(20, 506);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new Wisej.Web.Padding(10);
            this.panel9.Size = new System.Drawing.Size(1197, 133);
            this.panel9.TabIndex = 4;
            this.panel9.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnEmpARRDataViewer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEmpChartViewer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEmpDataViewer, 0, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // btnEmpARRDataViewer
            // 
            this.btnEmpARRDataViewer.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnEmpARRDataViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpARRDataViewer.Image")));
            this.btnEmpARRDataViewer.Location = new System.Drawing.Point(493, 18);
            this.btnEmpARRDataViewer.Name = "btnEmpARRDataViewer";
            this.btnEmpARRDataViewer.Size = new System.Drawing.Size(186, 74);
            this.btnEmpARRDataViewer.TabIndex = 2;
            this.btnEmpARRDataViewer.Text = "심장 리듬 이상 데이터 이력보기";
            this.btnEmpARRDataViewer.Click += new System.EventHandler(this.btnEmpARRDataViewer_Click);
            // 
            // btnEmpChartViewer
            // 
            this.btnEmpChartViewer.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnEmpChartViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpChartViewer.Image")));
            this.btnEmpChartViewer.Location = new System.Drawing.Point(892, 18);
            this.btnEmpChartViewer.Name = "btnEmpChartViewer";
            this.btnEmpChartViewer.Size = new System.Drawing.Size(173, 74);
            this.btnEmpChartViewer.TabIndex = 1;
            this.btnEmpChartViewer.Text = "일일 맥박 데이터";
            this.btnEmpChartViewer.Click += new System.EventHandler(this.btnEmpChartViewer_Click);
            // 
            // btnEmpDataViewer
            // 
            this.btnEmpDataViewer.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnEmpDataViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpDataViewer.Image")));
            this.btnEmpDataViewer.Location = new System.Drawing.Point(102, 18);
            this.btnEmpDataViewer.Name = "btnEmpDataViewer";
            this.btnEmpDataViewer.Size = new System.Drawing.Size(186, 74);
            this.btnEmpDataViewer.TabIndex = 0;
            this.btnEmpDataViewer.Text = "심전도 데이터";
            this.btnEmpDataViewer.Click += new System.EventHandler(this.btnEmpDataViewer_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel7.Controls.Add(this.txtEmpName);
            this.panel7.Controls.Add(this.btnReport);
            this.panel7.Controls.Add(this.txtBPMTime);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.line2);
            this.panel7.Controls.Add(this.txtBPMMinMax);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txtBPMNow);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtName);
            this.panel7.Controls.Add(this.panel8);
            this.styleSheetDAIR.SetCssClass(this.panel7, "rounded-panel");
            this.panel7.Dock = Wisej.Web.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1197, 81);
            this.panel7.TabIndex = 3;
            this.panel7.TabStop = true;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpName.Location = new System.Drawing.Point(243, 8);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(79, 30);
            this.txtEmpName.TabIndex = 16;
            this.txtEmpName.Text = "-";
            this.txtEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReport
            // 
            this.btnReport.Dock = Wisej.Web.DockStyle.Right;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(1071, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(124, 79);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "보고서 출력";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtBPMTime
            // 
            this.txtBPMTime.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBPMTime.Location = new System.Drawing.Point(442, 42);
            this.txtBPMTime.Name = "txtBPMTime";
            this.txtBPMTime.Size = new System.Drawing.Size(94, 30);
            this.txtBPMTime.TabIndex = 11;
            this.txtBPMTime.Text = "0000-00-00 00:00:00";
            this.txtBPMTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(442, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "성별     남성";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(93, 35);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(439, 10);
            // 
            // txtBPMMinMax
            // 
            this.txtBPMMinMax.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBPMMinMax.Location = new System.Drawing.Point(344, 42);
            this.txtBPMMinMax.Name = "txtBPMMinMax";
            this.txtBPMMinMax.Size = new System.Drawing.Size(92, 30);
            this.txtBPMMinMax.TabIndex = 7;
            this.txtBPMMinMax.Text = "-";
            this.txtBPMMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(243, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "금일 최소/최대";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBPMNow
            // 
            this.txtBPMNow.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBPMNow.Location = new System.Drawing.Point(180, 42);
            this.txtBPMNow.Name = "txtBPMNow";
            this.txtBPMNow.Size = new System.Drawing.Size(57, 30);
            this.txtBPMNow.TabIndex = 5;
            this.txtBPMNow.Text = "-";
            this.txtBPMNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(79, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "현재 BPM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "나이     비공개";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Location = new System.Drawing.Point(79, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "-";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.Location = new System.Drawing.Point(9, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(64, 64);
            this.panel8.TabIndex = 0;
            this.panel8.TabStop = true;
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
            this.pLoading.Location = new System.Drawing.Point(561, 589);
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
            this.panel2.Location = new System.Drawing.Point(0, 707);
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
            // timerTick
            // 
            this.timerTick.Interval = 2000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // FormEmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.pLoading);
            this.Controls.Add(this.pBack1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpInfo";
            this.Size = new System.Drawing.Size(1220, 573);
            this.Load += new System.EventHandler(this.FormEmpInfo_Load);
            this.panel4.ResumeLayout(false);
            this.pBack1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private Wisej.Web.Panel panel6;
        private Wisej.Web.Ext.ChartJS.ChartJS chartBPM;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.Button btnBack;
        private Wisej.Web.Panel panel8;
        private Wisej.Web.Label txtBPMNow;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label txtName;
        private Wisej.Web.Label txtBPMMinMax;
        private Wisej.Web.Label label6;
        private Wisej.Web.Line line2;
        private Wisej.Web.Label label4;
        private Wisej.Web.ProgressBar pLoading;
        private Wisej.Web.Panel panel9;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.Button btnEmpDataViewer;
        private Wisej.Web.Button btnEmpChartViewer;
        private Wisej.Web.Timer timerTick;
        private Wisej.Web.Label txtBPMTime;
        private Wisej.Web.Button btnEmpARRDataViewer;
        private Wisej.Web.Button btnReport;
        private Wisej.Web.Label txtEmpName;
    }
}
