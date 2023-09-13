
namespace cubemesweb.dair_msl
{
    partial class FormEmpOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpOverview));
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
            this.panel19 = new Wisej.Web.Panel();
            this.btnCSVStep = new Wisej.Web.Button();
            this.panel17 = new Wisej.Web.Panel();
            this.btnCSVDistance = new Wisej.Web.Button();
            this.panel16 = new Wisej.Web.Panel();
            this.btnCSVCal = new Wisej.Web.Button();
            this.panel15 = new Wisej.Web.Panel();
            this.btnEmpARRDataViewer = new Wisej.Web.Button();
            this.panel14 = new Wisej.Web.Panel();
            this.btnEmpChartViewer = new Wisej.Web.Button();
            this.panel13 = new Wisej.Web.Panel();
            this.btnCSVTemp = new Wisej.Web.Button();
            this.panel7 = new Wisej.Web.Panel();
            this.panel11 = new Wisej.Web.Panel();
            this.flowLayoutPanel2 = new Wisej.Web.FlowLayoutPanel();
            this.txtBPM = new Wisej.Web.Label();
            this.txtHRV = new Wisej.Web.Label();
            this.txtCal = new Wisej.Web.Label();
            this.txtCalexe = new Wisej.Web.Label();
            this.txtStep = new Wisej.Web.Label();
            this.txtDistance = new Wisej.Web.Label();
            this.txtArrcnt = new Wisej.Web.Label();
            this.panel12 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.txtName = new Wisej.Web.Label();
            this.txtEmpName = new Wisej.Web.Label();
            this.txtBPMTime = new Wisej.Web.Label();
            this.txtTemp = new Wisej.Web.Label();
            this.panel8 = new Wisej.Web.Panel();
            this.panel10 = new Wisej.Web.Panel();
            this.btnReport = new Wisej.Web.Button();
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
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.pBack1.Size = new System.Drawing.Size(1237, 512);
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
            this.panel6.Size = new System.Drawing.Size(1197, 213);
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
            this.chartBPM.Size = new System.Drawing.Size(1197, 193);
            this.chartBPM.TabIndex = 0;
            this.chartBPM.Text = "chartJS1";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel9.Controls.Add(this.tableLayoutPanel1);
            this.styleSheetDAIR.SetCssClass(this.panel9, "rounded-panel");
            this.panel9.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(20, 359);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new Wisej.Web.Padding(10);
            this.panel9.Size = new System.Drawing.Size(1197, 133);
            this.panel9.TabIndex = 4;
            this.panel9.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel19, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel17, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 5, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnCSVStep);
            this.panel19.Dock = Wisej.Web.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(783, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(189, 105);
            this.panel19.TabIndex = 5;
            // 
            // btnCSVStep
            // 
            this.btnCSVStep.Dock = Wisej.Web.DockStyle.Fill;
            this.btnCSVStep.Image = ((System.Drawing.Image)(resources.GetObject("btnCSVStep.Image")));
            this.btnCSVStep.Location = new System.Drawing.Point(0, 0);
            this.btnCSVStep.Name = "btnCSVStep";
            this.btnCSVStep.Size = new System.Drawing.Size(189, 105);
            this.btnCSVStep.TabIndex = 3;
            this.btnCSVStep.Text = "걸음걸이";
            this.btnCSVStep.Click += new System.EventHandler(this.btnCSVStep_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnCSVDistance);
            this.panel17.Dock = Wisej.Web.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(588, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(189, 105);
            this.panel17.TabIndex = 4;
            // 
            // btnCSVDistance
            // 
            this.btnCSVDistance.Dock = Wisej.Web.DockStyle.Fill;
            this.btnCSVDistance.Image = ((System.Drawing.Image)(resources.GetObject("btnCSVDistance.Image")));
            this.btnCSVDistance.Location = new System.Drawing.Point(0, 0);
            this.btnCSVDistance.Name = "btnCSVDistance";
            this.btnCSVDistance.Size = new System.Drawing.Size(189, 105);
            this.btnCSVDistance.TabIndex = 2;
            this.btnCSVDistance.Text = "이동거리";
            this.btnCSVDistance.Click += new System.EventHandler(this.btnCSVDistance_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnCSVCal);
            this.panel16.Dock = Wisej.Web.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(393, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(189, 105);
            this.panel16.TabIndex = 3;
            // 
            // btnCSVCal
            // 
            this.btnCSVCal.Dock = Wisej.Web.DockStyle.Fill;
            this.btnCSVCal.Image = ((System.Drawing.Image)(resources.GetObject("btnCSVCal.Image")));
            this.btnCSVCal.Location = new System.Drawing.Point(0, 0);
            this.btnCSVCal.Name = "btnCSVCal";
            this.btnCSVCal.Size = new System.Drawing.Size(189, 105);
            this.btnCSVCal.TabIndex = 2;
            this.btnCSVCal.Text = "칼로리";
            this.btnCSVCal.Click += new System.EventHandler(this.btnCSVCal_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnEmpARRDataViewer);
            this.panel15.Dock = Wisej.Web.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(198, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(189, 105);
            this.panel15.TabIndex = 2;
            // 
            // btnEmpARRDataViewer
            // 
            this.btnEmpARRDataViewer.Dock = Wisej.Web.DockStyle.Fill;
            this.btnEmpARRDataViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpARRDataViewer.Image")));
            this.btnEmpARRDataViewer.Location = new System.Drawing.Point(0, 0);
            this.btnEmpARRDataViewer.Name = "btnEmpARRDataViewer";
            this.btnEmpARRDataViewer.Size = new System.Drawing.Size(189, 105);
            this.btnEmpARRDataViewer.TabIndex = 2;
            this.btnEmpARRDataViewer.Text = "심장 리듬 이상 데이터 이력보기";
            this.btnEmpARRDataViewer.Click += new System.EventHandler(this.btnEmpARRDataViewer_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnEmpChartViewer);
            this.panel14.Dock = Wisej.Web.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(189, 105);
            this.panel14.TabIndex = 1;
            // 
            // btnEmpChartViewer
            // 
            this.btnEmpChartViewer.Dock = Wisej.Web.DockStyle.Fill;
            this.btnEmpChartViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpChartViewer.Image")));
            this.btnEmpChartViewer.Location = new System.Drawing.Point(0, 0);
            this.btnEmpChartViewer.Name = "btnEmpChartViewer";
            this.btnEmpChartViewer.Size = new System.Drawing.Size(189, 105);
            this.btnEmpChartViewer.TabIndex = 1;
            this.btnEmpChartViewer.Text = "맥박 / 심전도 데이터";
            this.btnEmpChartViewer.Click += new System.EventHandler(this.btnEmpChartViewer_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnCSVTemp);
            this.panel13.Dock = Wisej.Web.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(978, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(194, 105);
            this.panel13.TabIndex = 0;
            // 
            // btnCSVTemp
            // 
            this.btnCSVTemp.Dock = Wisej.Web.DockStyle.Fill;
            this.btnCSVTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnCSVTemp.Image")));
            this.btnCSVTemp.Location = new System.Drawing.Point(0, 0);
            this.btnCSVTemp.Name = "btnCSVTemp";
            this.btnCSVTemp.Size = new System.Drawing.Size(194, 105);
            this.btnCSVTemp.TabIndex = 1;
            this.btnCSVTemp.Text = "체온";
            this.btnCSVTemp.Click += new System.EventHandler(this.btnCSVTemp_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.flowLayoutPanel2);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.flowLayoutPanel1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnReport);
            this.styleSheetDAIR.SetCssClass(this.panel7, "rounded-panel");
            this.panel7.Dock = Wisej.Web.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1197, 81);
            this.panel7.TabIndex = 3;
            this.panel7.TabStop = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(214, 214, 214);
            this.panel11.Dock = Wisej.Web.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(84, 71);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(987, 1);
            this.panel11.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtBPM);
            this.flowLayoutPanel2.Controls.Add(this.txtHRV);
            this.flowLayoutPanel2.Controls.Add(this.txtCal);
            this.flowLayoutPanel2.Controls.Add(this.txtCalexe);
            this.flowLayoutPanel2.Controls.Add(this.txtStep);
            this.flowLayoutPanel2.Controls.Add(this.txtDistance);
            this.flowLayoutPanel2.Controls.Add(this.txtArrcnt);
            this.flowLayoutPanel2.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(84, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(987, 35);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // txtBPM
            // 
            this.txtBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBPM.Location = new System.Drawing.Point(3, 3);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(75, 30);
            this.txtBPM.TabIndex = 2;
            this.txtBPM.Text = "-";
            this.txtBPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHRV
            // 
            this.txtHRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtHRV.Location = new System.Drawing.Point(84, 3);
            this.txtHRV.Name = "txtHRV";
            this.txtHRV.Size = new System.Drawing.Size(75, 30);
            this.txtHRV.TabIndex = 3;
            this.txtHRV.Text = "-";
            this.txtHRV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCal
            // 
            this.txtCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCal.Location = new System.Drawing.Point(165, 3);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(75, 30);
            this.txtCal.TabIndex = 4;
            this.txtCal.Text = "-";
            this.txtCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCalexe
            // 
            this.txtCalexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalexe.Location = new System.Drawing.Point(246, 3);
            this.txtCalexe.Name = "txtCalexe";
            this.txtCalexe.Size = new System.Drawing.Size(83, 30);
            this.txtCalexe.TabIndex = 5;
            this.txtCalexe.Text = "-";
            this.txtCalexe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtStep.Location = new System.Drawing.Point(335, 3);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(87, 30);
            this.txtStep.TabIndex = 6;
            this.txtStep.Text = "-";
            this.txtStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtDistance.Location = new System.Drawing.Point(428, 3);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(87, 30);
            this.txtDistance.TabIndex = 7;
            this.txtDistance.Text = "-";
            this.txtDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArrcnt
            // 
            this.txtArrcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArrcnt.Location = new System.Drawing.Point(521, 3);
            this.txtArrcnt.Name = "txtArrcnt";
            this.txtArrcnt.Size = new System.Drawing.Size(75, 30);
            this.txtArrcnt.TabIndex = 8;
            this.txtArrcnt.Text = "-";
            this.txtArrcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(214, 214, 214);
            this.panel12.Dock = Wisej.Web.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(84, 35);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(987, 1);
            this.panel12.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtName);
            this.flowLayoutPanel1.Controls.Add(this.txtEmpName);
            this.flowLayoutPanel1.Controls.Add(this.txtBPMTime);
            this.flowLayoutPanel1.Controls.Add(this.txtTemp);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(84, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(987, 35);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "-";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpName.Location = new System.Drawing.Point(183, 3);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(79, 30);
            this.txtEmpName.TabIndex = 16;
            this.txtEmpName.Text = "-";
            this.txtEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBPMTime
            // 
            this.txtBPMTime.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBPMTime.Location = new System.Drawing.Point(268, 3);
            this.txtBPMTime.Name = "txtBPMTime";
            this.txtBPMTime.Size = new System.Drawing.Size(94, 30);
            this.txtBPMTime.TabIndex = 11;
            this.txtBPMTime.Text = "0000-00-00 00:00:00";
            this.txtBPMTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTemp.Location = new System.Drawing.Point(368, 3);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(75, 30);
            this.txtTemp.TabIndex = 17;
            this.txtTemp.Text = "-";
            this.txtTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = Wisej.Web.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new Wisej.Web.Padding(10);
            this.panel8.Size = new System.Drawing.Size(84, 79);
            this.panel8.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Dock = Wisej.Web.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(10, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(64, 59);
            this.panel10.TabIndex = 1;
            this.panel10.TabStop = true;
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
            this.pLoading.Location = new System.Drawing.Point(561, 442);
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
            this.panel2.Location = new System.Drawing.Point(0, 560);
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
            // FormEmpOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.pLoading);
            this.Controls.Add(this.pBack1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpOverview";
            this.Size = new System.Drawing.Size(1220, 573);
            this.Load += new System.EventHandler(this.FormEmpOverview_Load);
            this.panel4.ResumeLayout(false);
            this.pBack1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
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
        private Wisej.Web.Label txtName;
        private Wisej.Web.ProgressBar pLoading;
        private Wisej.Web.Panel panel9;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.Button btnEmpChartViewer;
        private Wisej.Web.Timer timerTick;
        private Wisej.Web.Label txtBPMTime;
        private Wisej.Web.Button btnEmpARRDataViewer;
        private Wisej.Web.Button btnReport;
        private Wisej.Web.Label txtEmpName;
        private Wisej.Web.Panel panel8;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Panel panel11;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel2;
        private Wisej.Web.Label txtBPM;
        private Wisej.Web.Label txtHRV;
        private Wisej.Web.Label txtCal;
        private Wisej.Web.Label txtCalexe;
        private Wisej.Web.Label txtStep;
        private Wisej.Web.Label txtDistance;
        private Wisej.Web.Label txtArrcnt;
        private Wisej.Web.Panel panel12;
        private Wisej.Web.Label txtTemp;
        private Wisej.Web.Panel panel19;
        private Wisej.Web.Panel panel17;
        private Wisej.Web.Panel panel16;
        private Wisej.Web.Panel panel15;
        private Wisej.Web.Panel panel14;
        private Wisej.Web.Panel panel13;
        private Wisej.Web.Button btnCSVTemp;
        private Wisej.Web.Button btnCSVStep;
        private Wisej.Web.Button btnCSVDistance;
        private Wisej.Web.Button btnCSVCal;
    }
}
