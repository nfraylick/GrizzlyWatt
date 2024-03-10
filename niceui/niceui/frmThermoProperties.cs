using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace niceui
{
    public partial class frmThermoProperties : Form
    {

        private const int MatrixSize = 8; // Matrix size for 8x8 grid
        private double[,] GenerateBatteryData(int rows, int cols)
        {
            Random rand = new Random();
            double[,] data = new double[rows, cols];

            // Populate the array with simulated battery temperatures
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Generate a random temperature value, for example, between 20 and 50 degrees Celsius
                    data[i, j] = rand.Next(20, 51);
                }
            }

            return data;
        }

        public frmThermoProperties()
        {
            InitializeComponent();

            double[,] batteryTemps = GenerateNominalVoltageBatteryData(MatrixSize, MatrixSize, 3.7, 0.1);


            // Convert data to heatmap
            Bitmap heatmap = CreateHeatMap(batteryTemps, pictureBox1.Width, pictureBox1.Height);

            // Set the PictureBox's Image property to the heatmap
            pictureBox1.Image = heatmap;

        }
        private double[,] GenerateNominalVoltageBatteryData(int rows, int cols, double nominalVoltage, double voltageRange)
        {
            double[,] data = new double[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Generate voltage data that fluctuates around the nominal voltage
                    double fluctuation = (rand.NextDouble() * 2 - 1) * voltageRange; // Random fluctuation within the range
                    data[i, j] = nominalVoltage + fluctuation;
                }
            }

            return data;
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        static Bitmap CreateHeatMap(double[,] data, int width, int height)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            double max = Double.MinValue;
            double min = Double.MaxValue;

            // Find the max and min values of the data
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] > max) max = data[i, j];
                    if (data[i, j] < min) min = data[i, j];
                }
            }

            // Create a bitmap to draw the heatmap
            Bitmap bmp = new Bitmap(width, height);

            // Calculate the size of each cell in the heatmap
            int cellWidth = width / cols;
            int cellHeight = height / rows;

            // Use Graphics to draw the heatmap
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        // Normalize the data between 0 and 1
                        double normalizedValue = (data[i, j] - min) / (max - min);
                        // Choose a color based on the normalized value
                        Color color = ColorFromValue(normalizedValue);
                        // Fill a rectangle with the chosen color
                        g.FillRectangle(new SolidBrush(color), j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    }
                }
            }

            return bmp;
        }


        static Color ColorFromValue(double value)
        {
            // value is expected to be in the range [0, 1]

            // Define colors at significant points (cooler to hotter)
            Color coolColor = Color.Blue;
            Color mediumColor = Color.Green;
            Color hotColor = Color.Red;

            // Determine the color by interpolating between the defined significant colors
            int r, g, b;

            if (value < 0.5) // Cooler to medium range
            {
                // Interpolate between cool and medium colors
                r = (int)(coolColor.R * (0.5 - value) * 2 + mediumColor.R * value * 2);
                g = (int)(coolColor.G * (0.5 - value) * 2 + mediumColor.G * value * 2);
                b = (int)(coolColor.B * (0.5 - value) * 2 + mediumColor.B * value * 2);
            }
            else // Medium to hot range
            {
                // Adjust the value to fall in the 0-1 range after the 0.5 midpoint
                value = (value - 0.5) * 2;

                // Interpolate between medium and hot colors
                r = (int)(mediumColor.R * (1 - value) + hotColor.R * value);
                g = (int)(mediumColor.G * (1 - value) + hotColor.G * value);
                b = (int)(mediumColor.B * (1 - value) + hotColor.B * value);
            }

            // Ensure the channels are within the color bounds
            r = Math.Min(255, Math.Max(0, r));
            g = Math.Min(255, Math.Max(0, g));
            b = Math.Min(255, Math.Max(0, b));

            return Color.FromArgb(255, r, g, b); // Color with full opacity
        }

        private void buttonHeatMap_Click(object sender, EventArgs e)
        {
            double[,] batteryTemps = GenerateBatteryData(MatrixSize, MatrixSize);


            // Convert data to heatmap
            Bitmap heatmap = CreateHeatMap(batteryTemps, pictureBox1.Width, pictureBox1.Height);

            // Set the PictureBox's Image property to the heatmap
            pictureBox1.Image = heatmap;
        }

        private void frmThermoProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
