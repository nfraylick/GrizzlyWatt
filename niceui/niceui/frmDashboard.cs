using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace niceui
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            string batterySOC = "84";
            this.lblDashboardPercent.Text = $"{batterySOC}%";
            this.pnlBatteryCover.Height = 100 - int.Parse(batterySOC);


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 100;
            angle1 += 100;
            Invalidate();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            serialPort = new SerialPort("COM4", 9600);
            try
            {
                serialPort.Open();
                SteadyStateSimulation();
            }
            catch
            {
                Console.WriteLine("Unable to open COM port - check it's not in use.");
            }
            

        }
        SerialPort serialPort;
        private void SteadyStateSimulation()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("ss");
                serialPort.Close();
            }

            /*double soc = 100;
            this.lblDashboardPercent.Text = soc.ToString();
            double soh = 100;
            this.labelDashSOH.Text = soh.ToString();
            double current = 37.5;
            this.labelDashCurrent.Text = current.ToString();
            double voltage = 400;
            this.labelDashVoltage.Text = "100";
            double cellCount = 96;
            double individualCellVoltage = voltage / cellCount;
            this.labelIndividualCell.Text = String.Format("{0:0.00}", individualCellVoltage); 
            double energyContent = 60;
            this.labelDashEnergyContent.Text = energyContent.ToString();
            double power_output = voltage * current;
            this.labelDashPowerOutput.Text = power_output.ToString();
            int time_interval = 1000;
            int cuttoff_soc = 0;
            double max_cell_voltage = 400;
            string cell_balancing_status;/*

            /*
            while (soc > cuttoff_soc)
            {
                power_output = voltage * current;
                double energy_to_discharge = (power_output / 60) / 1000;
                energyContent = energyContent - energy_to_discharge;
                if (energyContent < 0)
                {
                    energyContent = 0;
                }
                soc = (energyContent / 60) * 100;
                individualCellVoltage = (soc / 100) * (max_cell_voltage);

                cell_balancing_status = "Active";

                voltage = individualCellVoltage * cellCount;

                this.lblDashboardPercent.Text = soc.ToString();
                this.labelDashSOH.Text = soh.ToString();
                this.labelDashCurrent.Text = current.ToString();
                this.labelDashVoltage.Text = voltage.ToString();
                this.labelIndividualCell.Text = String.Format("{0:0.00}", individualCellVoltage);
                this.labelDashEnergyContent.Text = energyContent.ToString();
                labelDashPowerOutput.Text = power_output.ToString();
                this.labelDashCellBalanceStatus.Text = cell_balancing_status;

                Thread.Sleep(time_interval);
            }*/



        }



        float angle, angle1;
        Bitmap image = Properties.Resources.wheel;
        Bitmap frontWheel = Properties.Resources.wheel1;

        Bitmap carImage = Properties.Resources.car;

        int cx = 408, cy = 425, rx = 100, ry = 100;
        int cx1 = 755, cy1 = 425, rx1 = 100, ry1 = 100;

        private void frmDashboard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.DrawImage(carImage, 310, 300, 570,170);

            g.RotateTransform(angle, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.TranslateTransform(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.DrawImage(image, -rx / 2, -ry / 2, rx, ry);

            //g.RotateTransform(angle1, System.Drawing.Drawing2D.MatrixOrder.Append);
            //g.TranslateTransform(cx1, cy1, System.Drawing.Drawing2D.MatrixOrder.Append);
            //g.DrawImage(frontWheel, -rx1 / 2, -ry1 / 2, rx1, ry1);


        }

    }
}
