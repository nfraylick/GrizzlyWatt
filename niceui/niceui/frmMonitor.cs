using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace niceui
{
    public partial class frmMonitor : Form
    {
        SerialPort serialPort;
        public frmMonitor()
        {
            InitializeComponent();

            
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {

        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            timer1.Start();

            serialPort = new SerialPort("COM4", 9600);
            try
            {
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    serialPort.Write("1");
                }
                serialPort.Close();
            }
            catch
            {
                Console.WriteLine("Unable to open COM port - check it's not in use.");
            }

            

            string dataFilePath = @"C://Users//29nei//source//repos//niceui//runtest.txt";
            int numberOfDataPoints = 100; // Replace with a realistic number of data points you need
            int timeSpanInSeconds = 6;
            WriteRandomDataToFile(dataFilePath, timeSpanInSeconds, numberOfDataPoints);

            Thread.Sleep(3000);
            this.labelMonitorCellVoltage.Text = String.Format("{0:0.00}", GetCellVoltage());
            this.labelMonitorCellTemp.Text = String.Format("{0:0}", GetCellTemp());
            this.labelMonitorPackCurrent.Text = String.Format("{0:0}", GetPackCurrent());
            this.labelMonitorPackTemp.Text = String.Format("{0:0.00}", GetPackTemp());
            this.labelMonitorSOC.Text = String.Format("{0:0.00}", GetSOCEstimate());
            this.labelSOHEstimation.Text = String.Format("{0:0.00}", GetSOHEstimate());

            GetSecondData();

        }

        public async Task GetSecondData()
        {
            await Task.Delay(5000);
            this.labelAccelTime.Text = String.Format("{0:0.0}", GetAccelerationTime());
            this.labelEnergyRec.Text = String.Format("{0:0.0}", GetEnergyRecov());
            this.labelPowerLevel.Text = String.Format("{0:0.00}", GetPowerLevel());
            this.labelSOCImpact.Text = String.Format("{0:0.00}", GetSOCImpact());
        }

        private static readonly Random _rand = new Random();

        public static void WriteRandomDataToFile(string filePath, int timeSpanInSeconds, int recordingFrequencyInHz)
        {
            int totalDataPoints = timeSpanInSeconds * recordingFrequencyInHz;
            using (var file = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write headers
                file.WriteLine("Time (s),Pack Voltage (V),Pack Current (A),Pack Power (kW),Avg Cell Temperature (C),SOC (%),Max Cell Voltage (V),Min Cell Voltage (V),Max Cell Resistance (mOhm)");

                // Define additional variables for data simulation
                double packVoltage;
                double packCurrent;
                double packPower;
                double averageCellTemp;
                double soc;
                double maxCellVoltage;
                double minCellVoltage;
                double maxCellResistance;

                for (int i = 0; i < totalDataPoints; i++)
                {
                    var time = i / (double)recordingFrequencyInHz;
                    packVoltage = SimulatePackVoltage(); // normally around 400V for many EVs
                    packCurrent = SimulatePackCurrent(); // Can peak during acceleration
                    packPower = packVoltage * packCurrent / 1000.0; // Power in kW
                    averageCellTemp = SimulateCellTemperature();
                    soc = SimulateStateOfCharge();
                    maxCellVoltage = SimulateMaxCellVoltage();
                    minCellVoltage = SimulateMinCellVoltage();
                    maxCellResistance = SimulateMaxCellResistance();

                    // Write comma-separated values on each line
                    file.WriteLine($"{time:F2},{packVoltage:F1},{packCurrent:F0},{packPower:F2},{averageCellTemp:F1},{soc:F2},{maxCellVoltage:F2},{minCellVoltage:F2},{maxCellResistance:F2}");
                }
            }
        }

        private static double GetRandomVoltage()
        {
            // Realistic voltage range for a typical Li-ion cell under load
            return _rand.NextDouble() * (4.2 - 3.0) + 3.0; // For example, 3.0V to 4.2V
        }
        private static double GetCellVoltage()
        {
            
            return _rand.NextDouble() * (375 - 340) + 340; 
        }

        private static double GetCellTemp()
        {
            
            return _rand.NextDouble() * (30 - 25) + 25; 
        }

        private static double GetPackCurrent()
        {

            return _rand.NextDouble() * (500 - 200) + 200;
        }

        private static double GetPackTemp()
        {

            return _rand.NextDouble() * (40 - 20) + 20;
        }

        public static double SOCEst;
        private static double GetSOCEstimate()
        {
            SOCEst = _rand.NextDouble() * (90 - 75) + 75;
            return SOCEst;
        }

        private static double GetSOHEstimate()
        {

            return _rand.NextDouble() * (100 - 70) + 70;
        }

        private static double GetAccelerationTime()
        {

            return _rand.NextDouble() * (5 - 3) + 3;
        }

        private static double GetEnergyRecov()
        {

            return _rand.NextDouble() * (2 - 0) + 0;
        }

        private static double GetPowerLevel()
        {

            return _rand.NextDouble() * (250 - 150) + 150;
        }

        private static double GetSOCImpact()
        {

            return 100 - SOCEst;
        }

        private static double GetRandomCurrent()
        {
            // Assuming the battery pack can output high currents
            return _rand.NextDouble() * (1000 - 100) + 100; // For example, 100A to 1000A
        }

        private static double GetRandomTemperature()
        {
            // Assuming the temperature increases under hard acceleration
            return _rand.NextDouble() * (50 - 20) + 20; // For example, 20C to 50C
        }

        private static double GetRandomStateOfCharge()
        {
            // SOC might drop under hard acceleration
            return _rand.NextDouble() * (100 - 90) + 90; // For example, 90% to 100%
        }

        // Note: The following simulation methods should reflect realistic scenarios; adjust the values as needed for your scenario.
        private static double SimulatePackVoltage() => 300 + _rand.NextDouble() * 100; // For example, 300V to 400V
        private static double SimulatePackCurrent() => 50 + _rand.NextDouble() * 250; // For example, 50A to 300A
        private static double SimulateCellTemperature() => 20 + _rand.NextDouble() * 30; // For example, 20C to 50C
        private static double SimulateStateOfCharge() => 80 + _rand.NextDouble() * 20; // For example, 80% to 100%
        private static double SimulateMaxCellVoltage() => 3.7 + _rand.NextDouble() * 0.5; // For example, 3.7V to 4.2V
        private static double SimulateMinCellVoltage() => 3.7 - _rand.NextDouble() * 0.5; // For example, 3.2V to 3.7V
        private static double SimulateMaxCellResistance() => 10 + _rand.NextDouble() * 40; // For example, 10mOhm to 50mOhm


        float angle, angle1;
        Bitmap image = Properties.Resources.wheel;
        Bitmap frontWheel = Properties.Resources.wheel1;

        Bitmap carImage = Properties.Resources.car;

        int cx = 408, cy = 425, rx = 100, ry = 100;

        private void buttonGetReport_Click(object sender, EventArgs e)
        {
            string file = @"C://Users//29nei//source//repos//niceui//runtest.txt";
            Process.Start(file);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frmMonitor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.DrawImage(carImage, 310, 300, 570, 170);

            g.RotateTransform(angle, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.TranslateTransform(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.DrawImage(image, -rx / 2, -ry / 2, rx, ry);

            //g.RotateTransform(angle1, System.Drawing.Drawing2D.MatrixOrder.Append);
            //g.TranslateTransform(cx1, cy1, System.Drawing.Drawing2D.MatrixOrder.Append);
            //g.DrawImage(frontWheel, -rx1 / 2, -ry1 / 2, rx1, ry1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 100;
            angle1 += 100;
            Invalidate();
        }

        int cx1 = 755, cy1 = 425, rx1 = 100, ry1 = 100;
    }
}
