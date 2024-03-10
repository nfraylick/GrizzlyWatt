namespace niceui
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.labelDashCurrent = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDashPowerOutput = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelDashPowerInput = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDashSOH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDashboardPercent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.labelIndividualCell = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDashVoltage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDashEnergyContent = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDashCellBalanceStatus = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pnlBatteryCap = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlBatteryCover = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.labelDashCurrent);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(540, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(313, 103);
            this.panel7.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label17.Location = new System.Drawing.Point(20, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(217, 34);
            this.label17.TabIndex = 3;
            this.label17.Text = "Negative value indicates the battery\r\nis discharging";
            // 
            // labelDashCurrent
            // 
            this.labelDashCurrent.AutoSize = true;
            this.labelDashCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDashCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashCurrent.Location = new System.Drawing.Point(104, 15);
            this.labelDashCurrent.Name = "labelDashCurrent";
            this.labelDashCurrent.Size = new System.Drawing.Size(82, 24);
            this.labelDashCurrent.TabIndex = 2;
            this.labelDashCurrent.Text = "-37.5  A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Current:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.labelDashPowerOutput);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.labelDashPowerInput);
            this.panel6.Location = new System.Drawing.Point(12, 259);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(291, 154);
            this.panel6.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label10.Location = new System.Drawing.Point(15, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Output when discharging";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Power Output:";
            // 
            // labelDashPowerOutput
            // 
            this.labelDashPowerOutput.AutoSize = true;
            this.labelDashPowerOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDashPowerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashPowerOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashPowerOutput.Location = new System.Drawing.Point(151, 75);
            this.labelDashPowerOutput.Name = "labelDashPowerOutput";
            this.labelDashPowerOutput.Size = new System.Drawing.Size(67, 24);
            this.labelDashPowerOutput.TabIndex = 9;
            this.labelDashPowerOutput.Text = "35 kW";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(13, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 25);
            this.label19.TabIndex = 8;
            this.label19.Text = "Power Input:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label20.Location = new System.Drawing.Point(15, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 34);
            this.label20.TabIndex = 7;
            this.label20.Text = "Input when charging\r\n\r\n";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // labelDashPowerInput
            // 
            this.labelDashPowerInput.AutoSize = true;
            this.labelDashPowerInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDashPowerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashPowerInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashPowerInput.Location = new System.Drawing.Point(136, 16);
            this.labelDashPowerInput.Name = "labelDashPowerInput";
            this.labelDashPowerInput.Size = new System.Drawing.Size(21, 24);
            this.labelDashPowerInput.TabIndex = 6;
            this.labelDashPowerInput.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.labelDashSOH);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(276, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 130);
            this.panel5.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(22, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Details of Last 2 Seconds";
            // 
            // labelDashSOH
            // 
            this.labelDashSOH.AutoSize = true;
            this.labelDashSOH.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashSOH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashSOH.Location = new System.Drawing.Point(19, 56);
            this.labelDashSOH.Name = "labelDashSOH";
            this.labelDashSOH.Size = new System.Drawing.Size(74, 32);
            this.labelDashSOH.TabIndex = 1;
            this.labelDashSOH.Text = "92%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "State of Health (SOH)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblDashboardPercent);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 130);
            this.panel4.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(22, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Details of Last 2 Seconds";
            // 
            // lblDashboardPercent
            // 
            this.lblDashboardPercent.AutoSize = true;
            this.lblDashboardPercent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDashboardPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.lblDashboardPercent.Location = new System.Drawing.Point(19, 49);
            this.lblDashboardPercent.Name = "lblDashboardPercent";
            this.lblDashboardPercent.Size = new System.Drawing.Size(74, 32);
            this.lblDashboardPercent.TabIndex = 1;
            this.lblDashboardPercent.Text = "65%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "State of Charge (SOC)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.labelIndividualCell);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelDashVoltage);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 105);
            this.panel1.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Individual Cell Voltage:";
            // 
            // labelIndividualCell
            // 
            this.labelIndividualCell.AutoSize = true;
            this.labelIndividualCell.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelIndividualCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndividualCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelIndividualCell.Location = new System.Drawing.Point(224, 41);
            this.labelIndividualCell.Name = "labelIndividualCell";
            this.labelIndividualCell.Size = new System.Drawing.Size(58, 24);
            this.labelIndividualCell.TabIndex = 4;
            this.labelIndividualCell.Text = "3.7 V";
            this.labelIndividualCell.Click += new System.EventHandler(this.label16_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Voltage:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "multiple times for a pack of many cells";
            // 
            // labelDashVoltage
            // 
            this.labelDashVoltage.AutoSize = true;
            this.labelDashVoltage.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDashVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashVoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashVoltage.Location = new System.Drawing.Point(99, 16);
            this.labelDashVoltage.Name = "labelDashVoltage";
            this.labelDashVoltage.Size = new System.Drawing.Size(63, 24);
            this.labelDashVoltage.TabIndex = 1;
            this.labelDashVoltage.Text = "350 V";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.labelDashEnergyContent);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(540, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 74);
            this.panel2.TabIndex = 18;
            // 
            // labelDashEnergyContent
            // 
            this.labelDashEnergyContent.AutoSize = true;
            this.labelDashEnergyContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDashEnergyContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashEnergyContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashEnergyContent.Location = new System.Drawing.Point(168, 15);
            this.labelDashEnergyContent.Name = "labelDashEnergyContent";
            this.labelDashEnergyContent.Size = new System.Drawing.Size(79, 24);
            this.labelDashEnergyContent.TabIndex = 9;
            this.labelDashEnergyContent.Text = "42 kWh";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label22.Location = new System.Drawing.Point(20, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(240, 34);
            this.label22.TabIndex = 8;
            this.label22.Text = "The total energy available in the battery\r\n\r\n";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Energy Content:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelDashCellBalanceStatus);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Location = new System.Drawing.Point(540, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 91);
            this.panel3.TabIndex = 19;
            // 
            // labelDashCellBalanceStatus
            // 
            this.labelDashCellBalanceStatus.AutoSize = true;
            this.labelDashCellBalanceStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDashCellBalanceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashCellBalanceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelDashCellBalanceStatus.Location = new System.Drawing.Point(203, 15);
            this.labelDashCellBalanceStatus.Name = "labelDashCellBalanceStatus";
            this.labelDashCellBalanceStatus.Size = new System.Drawing.Size(67, 24);
            this.labelDashCellBalanceStatus.TabIndex = 9;
            this.labelDashCellBalanceStatus.Text = "Active";
            this.labelDashCellBalanceStatus.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label25.Location = new System.Drawing.Point(20, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(287, 34);
            this.label25.TabIndex = 8;
            this.label25.Text = "Status of any active cell balancing that is being \r\ndone to maximize battery life" +
    " and performance.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(20, 15);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(191, 25);
            this.label26.TabIndex = 0;
            this.label26.Text = "Cell Balancing Status:";
            // 
            // pnlBatteryCap
            // 
            this.pnlBatteryCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlBatteryCap.Location = new System.Drawing.Point(395, 180);
            this.pnlBatteryCap.Name = "pnlBatteryCap";
            this.pnlBatteryCap.Size = new System.Drawing.Size(52, 95);
            this.pnlBatteryCap.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStart.Location = new System.Drawing.Point(117, 432);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 42);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start Steady Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlBatteryCover
            // 
            this.pnlBatteryCover.Location = new System.Drawing.Point(395, 180);
            this.pnlBatteryCover.Name = "pnlBatteryCover";
            this.pnlBatteryCover.Size = new System.Drawing.Size(52, 103);
            this.pnlBatteryCover.TabIndex = 23;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(881, 546);
            this.Controls.Add(this.pnlBatteryCover);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlBatteryCap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmDashboard_Paint);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDashSOH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDashboardPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDashVoltage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelIndividualCell;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelDashCurrent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelDashPowerOutput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelDashPowerInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelDashEnergyContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDashCellBalanceStatus;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBatteryCap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlBatteryCover;
        private System.Windows.Forms.Timer timer2;
    }
}