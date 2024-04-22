using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using The_Control_Tower.Entities;

namespace The_Control_Tower
{
    /// Author: Petter Rignell
    /// Created: 2024-04-12
    /// Updated: 2024-04-19
    ///
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Initialize, Update, and UI-components related events, 
    /// for the application in its entirety
    /// </summary>
    public partial class MainWindow : Window
    {
        private ControlTower controlTower;
        public MainWindow()
        {
            InitializeComponent();
            controlTower = new ControlTower(lvwEvents);
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            controlTower.AddTestValues();
            UpdateGUI();
        }

        //Add plane object to flight list
        private void btnAddPlane_Click(object sender, RoutedEventArgs e)
        {
            bool okFlightTime = int.TryParse(tbxFlightTime.Text, out int val);
            bool flightTbxsEmpty = tbxName.Text == string.Empty || tbxDestination.Text == string.Empty ||
                                    tbxFlightID.Text == string.Empty || tbxFlightTime.Text == string.Empty;

            if (flightTbxsEmpty || !okFlightTime)
            {
                MessageBox.Show("Invalid flight information!");               
                return;
            }

            Airplane airplane = new Airplane();
            airplane.Name = tbxName.Text;
            airplane.FlightID = tbxFlightID.Text;
            airplane.Destination = tbxDestination.Text;
            airplane.FlightTime = val;

            controlTower.AddAirplane(airplane);
            EmptyTextBoxes();
            UpdateGUI();
        }

        //Initialize take off sequence
        private void btnTakeOff_Click(object sender, RoutedEventArgs e)
        {
            int index = lvwFlights.SelectedIndex;

            if(index == -1)
            {
                MessageBox.Show("Choose a flight that is to take off");
                return;
            }
                
            controlTower.OrderTakeOff(index);
            UpdateGUI();
        }

        //Change altitude of plane
        private void btnAltitude_Click(object sender, RoutedEventArgs e)
        {
            int index = lvwFlights.SelectedIndex;
            bool okAltitude = int.TryParse(tbxAltitude.Text, out int value);

            if(okAltitude && index != -1)
                controlTower.OrderAltitudeChange(value, index);
            else
                MessageBox.Show("Invalid altitude change!");

        }

        //Update UI of flight listview
        private void UpdateGUI()
        {
            lvwFlights.Items.Clear();

            for (int i = 0; ; i++)
            {
                Airplane airplane = controlTower.GetAirplaneAt(i);
                if (airplane == null)
                    break;

                lvwFlights.Items.Add(airplane.ToString());
            }
        }

        private void EmptyTextBoxes()
        {
            tbxAltitude.Text = string.Empty;
            tbxDestination.Text = string.Empty;
            tbxFlightID.Text = string.Empty;
            tbxFlightTime.Text = string.Empty;
            tbxName.Text = string.Empty; 
        }
    }
}
