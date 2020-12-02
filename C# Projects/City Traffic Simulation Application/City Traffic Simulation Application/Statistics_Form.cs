using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Traffic_Simulation_Application
{
    public partial class Statistics_Form : Form
    {
        int x, y, z,p;

        public double waittime;
            
        public Statistics_Form()
        {
            InitializeComponent();
        }

        public void SetTotalCars(int crossingNumber, int numberOfCars)
        {   
            switch (crossingNumber)
            {
                case 1:
                    lblTotalCarsInCrossing1.Text = numberOfCars.ToString();
                    x = Convert.ToInt32(lblTotalCarsInCrossing1.Text);
                    break;
                case 2:
                    lblTotalCarsInCrossing2.Text = numberOfCars.ToString();
                    y = Convert.ToInt32(lblTotalCarsInCrossing2.Text);
                    break;
                case 3:
                    lblTotalCarsInCrossing3.Text = numberOfCars.ToString();
                    z= Convert.ToInt32(lblTotalCarsInCrossing3.Text);
                    break;
                case 4:
                    lblTotalCarsInCrossing4.Text = numberOfCars.ToString();
                    p= Convert.ToInt32(lblTotalCarsInCrossing4.Text);
                    break;
            }
        }

        public void SetTotalWaitingCars(int crossingNumber, int waitingCarsNumber)
        {
            switch (crossingNumber)
            {
                case 1:
                    lblWaitingCarsCrossing1.Text = waitingCarsNumber.ToString();
                    break;
                case 2:
                    lblWaitingCarsCrossing2.Text = waitingCarsNumber.ToString();
                    break;
                case 3:
                    lblWaitingCarsCrossing3.Text = waitingCarsNumber.ToString();
                    break;
                case 4:
                    lblWaitingCarsCrossing4.Text = waitingCarsNumber.ToString();
                    break;
            }
        }

        public void SetTotalWaitingCarsInEast(int crossingNumber, int waitingCarsNumber)
        {
            switch (crossingNumber)
            {
                case 1:
                    lblTotalWaitingCarsInEastCrossing1.Text = waitingCarsNumber.ToString();
                    break;
                case 2:
                    lblTotalWaitingCarsInEastCrossing2.Text = waitingCarsNumber.ToString();
                    break;
                case 3:
                    lblTotalWaitingCarsInEastCrossing3.Text = waitingCarsNumber.ToString();
                    break;
                case 4:
                    lblTotalWaitingCarsInEastCrossing4.Text = waitingCarsNumber.ToString();
                    break;
            }
        }
        public void SetTotalWaitingCarsInWest(int crossingNumber, int waitingCarsNumber)
        {
            switch (crossingNumber)
            {
                case 1:
                    lblTotalWaitingCarsInWestCrossing1.Text = waitingCarsNumber.ToString();
                    break;
                case 2:
                    lblTotalWaitingCarsInWestCrossing2.Text = waitingCarsNumber.ToString();
                    break;
                case 3:
                    lblTotalWaitingCarsInWestCrossing3.Text = waitingCarsNumber.ToString();
                    break;
                case 4:
                    lblTotalWaitingCarsInWestCrossing4.Text = waitingCarsNumber.ToString();
                    break;
            }
        }
        public void SetTotalWaitingCarsInNorth(int crossingNumber, int waitingCarsNumber)
        {
            switch (crossingNumber)
            {
                case 1:
                    lblTotalWaitingCarsInNorthCrossing1.Text = waitingCarsNumber.ToString();
                    break;
                case 2:
                    lblTotalWaitingCarsInNorthCrossing2.Text = waitingCarsNumber.ToString();
                    break;
                case 3:
                    lblTotalWaitingCarsInNorthCrossing3.Text = waitingCarsNumber.ToString();
                    break;
                case 4:
                    lblTotalWaitingCarsInNorthCrossing4.Text = waitingCarsNumber.ToString();
                    break;
            }
        }
        public void SetTotalWaitingCarsInSouth(int crossingNumber, int waitingCarsNumber)
        {
            switch (crossingNumber)
            {
                case 1:
                    lblTotalWaitingCarsInSouthCrossing1.Text = waitingCarsNumber.ToString();
                    break;
                case 2:
                    lblTotalWaitingCarsInSouthCrossing2.Text = waitingCarsNumber.ToString();
                    break;
                case 3:
                    lblTotalWaitingCarsInSouthCrossing3.Text = waitingCarsNumber.ToString();
                    break;
                case 4:
                    lblTotalWaitingCarsInSouthCrossing4.Text = waitingCarsNumber.ToString();
                    break;
            }
        }

        private void lblTotalWaitingCarsInSouthCrossing3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalWaitingCarsInNorthCrossing3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalWaitingCarsInWestCrossing3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Hide();
            chart2.Show();
            chart2.Series[0].Points.AddY(waittime/1000);
        }

        private void lblTotalWaitingCarsInEastCrossing3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart2.Hide();
            chart1.Show();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            this.chart1.Series["Crossings"].Points.AddXY("crossing 1", x);
            this.chart1.Series["Crossings"].Points.AddXY("crossing 2", y);
            this.chart1.Series["Crossings"].Points.AddXY("crossing 3", z);
            this.chart1.Series["Crossings"].Points.AddXY("crossing 4", p);
        }

    }
}
