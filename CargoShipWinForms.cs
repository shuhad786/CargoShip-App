using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStoreApp
{
    public partial class CargoShipWinForms : Form
    {
        CargoShip NewShip = new CargoShip(); 
        
        public CargoShipWinForms()
        {
            InitializeComponent();
        }

        private void CargoShipWinForms_Load(object sender, EventArgs e)
        {
            ship_progressBar.Style = ProgressBarStyle.Continuous;
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            NewShip = new CargoShip();
            ControlUI();
        }

        private void ControlUI() // Controls all the properties of the CargoShip class 
        {
            ship_progressBar.Maximum = NewShip.ShipCapacity;

            if (NewShip.getCargoLoad() <= NewShip.ShipCapacity)
            
            ship_progressBar.Value = NewShip.getCargoLoad();
            ship_labels.Text = NewShip.ToString();
            MT_label.Text = NewShip.ToString();
            CT_label.Text = NewShip.ToString();
            TKT_label.Text = NewShip.ToString();
            TNT_label.Text = NewShip.ToString();

            if (NewShip.CargoOverLoad() == 0)
            {
                ship_progressBar.ForeColor = Color.GreenYellow;
            }

            if (NewShip.CargoOverLoad() > 0)
            {
                ship_progressBar.ForeColor = Color.YellowGreen;
            }

            if (NewShip.CargoOverLoad() < 0)
            {
                ship_progressBar.ForeColor = Color.Red;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MotorBike_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.MotorBikeCount = MotorBike_trackBar.Value;
            ControlUI(); 
        }

        private void Car_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.CarCount = Car_trackBar.Value;
            ControlUI();
        }
           
        private void Train_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.TrainCount = Train_trackBar.Value;
            ControlUI();
        }

        private void Truck_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.TruckCount = Truck_trackBar.Value;
            ControlUI();
        }
    }

}
