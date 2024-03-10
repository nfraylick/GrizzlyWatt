namespace niceui
{
    partial class frmMonitor
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMonitorPackCurrent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMonitorCellTemp = new System.Windows.Forms.Label();
            this.labelMonitorCellVoltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelMonitorPackTemp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelMonitorSOC = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelSOHEstimation = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSOCImpact = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labelPowerLevel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.labelEnergyRec = new System.Windows.Forms.Label();
            this.labelAccelTime = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.buttonGetReport = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.labelSOHEstimation);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.labelMonitorSOC);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.labelMonitorPackTemp);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.labelMonitorPackCurrent);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.labelMonitorCellTemp);
            this.panel4.Controls.Add(this.labelMonitorCellVoltage);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 306);
            this.panel4.TabIndex = 30;
            // 
            // labelMonitorPackCurrent
            // 
            this.labelMonitorPackCurrent.AutoSize = true;
            this.labelMonitorPackCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMonitorPackCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonitorPackCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelMonitorPackCurrent.Location = new System.Drawing.Point(140, 138);
            this.labelMonitorPackCurrent.Name = "labelMonitorPackCurrent";
            this.labelMonitorPackCurrent.Size = new System.Drawing.Size(21, 24);
            this.labelMonitorPackCurrent.TabIndex = 26;
            this.labelMonitorPackCurrent.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pack Current:";
            // 
            // labelMonitorCellTemp
            // 
            this.labelMonitorCellTemp.AutoSize = true;
            this.labelMonitorCellTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMonitorCellTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonitorCellTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelMonitorCellTemp.Location = new System.Drawing.Point(185, 97);
            this.labelMonitorCellTemp.Name = "labelMonitorCellTemp";
            this.labelMonitorCellTemp.Size = new System.Drawing.Size(21, 24);
            this.labelMonitorCellTemp.TabIndex = 24;
            this.labelMonitorCellTemp.Text = "0";
            // 
            // labelMonitorCellVoltage
            // 
            this.labelMonitorCellVoltage.AutoSize = true;
            this.labelMonitorCellVoltage.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMonitorCellVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonitorCellVoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelMonitorCellVoltage.Location = new System.Drawing.Point(140, 54);
            this.labelMonitorCellVoltage.Name = "labelMonitorCellVoltage";
            this.labelMonitorCellVoltage.Size = new System.Drawing.Size(21, 24);
            this.labelMonitorCellVoltage.TabIndex = 10;
            this.labelMonitorCellVoltage.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cell Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cell Voltage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monitoring";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(221, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "degC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(209, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "V";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Pack Temp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "SOC Estimation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "SOH Estimation:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(181, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "A";
            // 
            // labelMonitorPackTemp
            // 
            this.labelMonitorPackTemp.AutoSize = true;
            this.labelMonitorPackTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMonitorPackTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonitorPackTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelMonitorPackTemp.Location = new System.Drawing.Point(140, 175);
            this.labelMonitorPackTemp.Name = "labelMonitorPackTemp";
            this.labelMonitorPackTemp.Size = new System.Drawing.Size(21, 24);
            this.labelMonitorPackTemp.TabIndex = 33;
            this.labelMonitorPackTemp.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label18.Location = new System.Drawing.Point(198, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 24);
            this.label18.TabIndex = 34;
            this.label18.Text = "degC";
            // 
            // labelMonitorSOC
            // 
            this.labelMonitorSOC.AutoSize = true;
            this.labelMonitorSOC.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMonitorSOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonitorSOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelMonitorSOC.Location = new System.Drawing.Point(182, 223);
            this.labelMonitorSOC.Name = "labelMonitorSOC";
            this.labelMonitorSOC.Size = new System.Drawing.Size(21, 24);
            this.labelMonitorSOC.TabIndex = 35;
            this.labelMonitorSOC.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label19.Location = new System.Drawing.Point(255, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 24);
            this.label19.TabIndex = 36;
            this.label19.Text = "%";
            // 
            // labelSOHEstimation
            // 
            this.labelSOHEstimation.AutoSize = true;
            this.labelSOHEstimation.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSOHEstimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSOHEstimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelSOHEstimation.Location = new System.Drawing.Point(182, 260);
            this.labelSOHEstimation.Name = "labelSOHEstimation";
            this.labelSOHEstimation.Size = new System.Drawing.Size(21, 24);
            this.labelSOHEstimation.TabIndex = 37;
            this.labelSOHEstimation.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label20.Location = new System.Drawing.Point(255, 259);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 24);
            this.label20.TabIndex = 38;
            this.label20.Text = "%";
            // 
            // btnRunTest
            // 
            this.btnRunTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRunTest.FlatAppearance.BorderSize = 0;
            this.btnRunTest.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRunTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunTest.Location = new System.Drawing.Point(61, 407);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(186, 42);
            this.btnRunTest.TabIndex = 31;
            this.btnRunTest.Text = "Run 0-60mph Test";
            this.btnRunTest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonGetReport);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.labelSOCImpact);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.labelPowerLevel);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.labelEnergyRec);
            this.panel1.Controls.Add(this.labelAccelTime);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(305, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 219);
            this.panel1.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label16.Location = new System.Drawing.Point(198, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 24);
            this.label16.TabIndex = 34;
            this.label16.Text = "%";
            // 
            // labelSOCImpact
            // 
            this.labelSOCImpact.AutoSize = true;
            this.labelSOCImpact.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSOCImpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSOCImpact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelSOCImpact.Location = new System.Drawing.Point(140, 175);
            this.labelSOCImpact.Name = "labelSOCImpact";
            this.labelSOCImpact.Size = new System.Drawing.Size(21, 24);
            this.labelSOCImpact.TabIndex = 33;
            this.labelSOCImpact.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label21.Location = new System.Drawing.Point(220, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 24);
            this.label21.TabIndex = 32;
            this.label21.Text = "kW";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(20, 175);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 25);
            this.label24.TabIndex = 29;
            this.label24.Text = "SOC Impact:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Cursor = System.Windows.Forms.Cursors.Default;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label25.Location = new System.Drawing.Point(238, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 24);
            this.label25.TabIndex = 28;
            this.label25.Text = "seconds";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Cursor = System.Windows.Forms.Cursors.Default;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label26.Location = new System.Drawing.Point(238, 96);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 24);
            this.label26.TabIndex = 27;
            this.label26.Text = "Wh";
            // 
            // labelPowerLevel
            // 
            this.labelPowerLevel.AutoSize = true;
            this.labelPowerLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPowerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPowerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelPowerLevel.Location = new System.Drawing.Point(140, 138);
            this.labelPowerLevel.Name = "labelPowerLevel";
            this.labelPowerLevel.Size = new System.Drawing.Size(21, 24);
            this.labelPowerLevel.TabIndex = 26;
            this.labelPowerLevel.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(20, 137);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 25);
            this.label28.TabIndex = 25;
            this.label28.Text = "Power Level";
            // 
            // labelEnergyRec
            // 
            this.labelEnergyRec.AutoSize = true;
            this.labelEnergyRec.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelEnergyRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergyRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelEnergyRec.Location = new System.Drawing.Point(185, 97);
            this.labelEnergyRec.Name = "labelEnergyRec";
            this.labelEnergyRec.Size = new System.Drawing.Size(21, 24);
            this.labelEnergyRec.TabIndex = 24;
            this.labelEnergyRec.Text = "0";
            // 
            // labelAccelTime
            // 
            this.labelAccelTime.AutoSize = true;
            this.labelAccelTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAccelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelAccelTime.Location = new System.Drawing.Point(198, 53);
            this.labelAccelTime.Name = "labelAccelTime";
            this.labelAccelTime.Size = new System.Drawing.Size(21, 24);
            this.labelAccelTime.TabIndex = 10;
            this.labelAccelTime.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(20, 96);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(166, 25);
            this.label31.TabIndex = 7;
            this.label31.Text = "Energy Recovered:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(20, 53);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(172, 25);
            this.label32.TabIndex = 6;
            this.label32.Text = "Acceleration Time: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(20, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 25);
            this.label33.TabIndex = 0;
            this.label33.Text = "Monitoring";
            // 
            // buttonGetReport
            // 
            this.buttonGetReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGetReport.FlatAppearance.BorderSize = 0;
            this.buttonGetReport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonGetReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGetReport.Location = new System.Drawing.Point(320, 158);
            this.buttonGetReport.Name = "buttonGetReport";
            this.buttonGetReport.Size = new System.Drawing.Size(186, 42);
            this.buttonGetReport.TabIndex = 40;
            this.buttonGetReport.Text = "Get Report";
            this.buttonGetReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGetReport.UseVisualStyleBackColor = true;
            this.buttonGetReport.Click += new System.EventHandler(this.buttonGetReport_Click);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(865, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRunTest);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonitor";
            this.Text = "frmMonitor";
            this.Load += new System.EventHandler(this.frmMonitor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMonitor_Paint);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelMonitorPackCurrent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMonitorCellTemp;
        private System.Windows.Forms.Label labelMonitorCellVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelMonitorSOC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelMonitorPackTemp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelSOHEstimation;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSOCImpact;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelPowerLevel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelEnergyRec;
        private System.Windows.Forms.Label labelAccelTime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button buttonGetReport;
    }
}