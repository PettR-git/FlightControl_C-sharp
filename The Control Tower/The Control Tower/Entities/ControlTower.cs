using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WTS.Entities.Main;
using static The_Control_Tower.Entities.Airplane;

namespace The_Control_Tower.Entities
{
    /// <summary>
    /// Tracks each airplane and provide methods for setting airplane properties
    /// Main communicator with MainWindow to construct views
    /// </summary>
    public class ControlTower
    {
        private ListManager<Airplane> airplaneList;
        private ListView lvwEvents;
        public ControlTower(ListView lvwEvents)
        {
            airplaneList = new ListManager<Airplane>();
            this.lvwEvents = lvwEvents;
        }

        public Airplane GetAirplaneAt(int index)
        {
            Airplane airplane = airplaneList.getListItemAt(index);

            return airplane;
        }

        //Add airplane to list, subscribe to events, update UI
        public void AddAirplane(Airplane airplane)
        {
            string outStr;

            if(airplane != null)
            {
                airplaneList.addItem(airplane);
                airplane.Landed += OnDisplayInfo;
                airplane.TakeOff += OnDisplayInfo;
                outStr = airplane.ToString() + " is sent to runway";

                lvwEvents.Items.Add(outStr);
            }
        }

        //Update event UI info 
        private void OnDisplayInfo(object sender, AirplaneEventArgs e)
        {
            lvwEvents.Items.Add(e.Message);
        }

        //To order take off if valid
        public void OrderTakeOff(int index)
        {
            Airplane airplane = airplaneList.getListItemAt(index);

            if (!airplane.CanLand)
                airplane.OnTakeOff();
            else
                MessageBox.Show("Plane is currently not scheduled for take off!");
        }

        //To order altitude change if valid
        public void OrderAltitudeChange(int altitude, int index)
        {
            Airplane airplane = airplaneList.getListItemAt(index);
            if (airplane.CanLand)
            {
                AltitudeHandler changeAlt = new AltitudeHandler(airplane.ChangeAltitude);
                lvwEvents.Items.Add(changeAlt(altitude));   
            }            
        }

        //Test values
        public void AddTestValues()
        {
            AddAirplane(new Airplane { Name = "Boeing 737 Max", FlightID = "LH56", Destination = "New York", FlightTime = 30 });
            AddAirplane(new Airplane { Name = "Airbus A380", FlightID = "EM428", Destination = "Dubai", FlightTime = 25 });
            AddAirplane(new Airplane { Name = "Boeing 737", FlightID = "MH370", Destination = "Beijing", FlightTime = 20 });
        }

    }
}
