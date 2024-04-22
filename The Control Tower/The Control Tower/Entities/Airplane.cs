using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace The_Control_Tower.Entities
{
    /// <summary>
    /// A planes data of id, name, flight time, destination
    /// And its capabilities given that defined data, 
    /// such as take off, and land. As well as, an airplanes
    /// current condition.
    /// </summary>
    public class Airplane
    {
        private DispatcherTimer timer;
        public Airplane() { }

        //Properties
        public bool CanLand{ get; set; }
        public string Destination {  get; set; }
        public string FlightID {  get; set; }
        public int FlightTime {  get; set; }
        public DateTime LocalTime {  get; set; }
        public string Name { get; set; }
        public int Altitude {  get; set; }

        //Events
        public event EventHandler<AirplaneEventArgs> Landed;
        public event EventHandler<AirplaneEventArgs> TakeOff;
        public delegate string AltitudeHandler(int altitude);

        //To invoke landing event
        public void OnLanding()
        {
            LocalTime = DateTime.Now;
            string outStr = $"{Name} has landed in {Destination} at {LocalTime}";
            AirplaneEventArgs args = new AirplaneEventArgs(outStr, Name);

            Landed?.Invoke(this, args);

            if (Destination != "home destination")
            {
                Destination = "home destination";
                CanLand = false;
            }
            else
                Destination = "the airports apron";

        }

        //To invoke take off event
        public void OnTakeOff()
        {
            SetUpTimer();
            LocalTime = DateTime.Now;
            string outStr = $"{Name}, {FlightID} set to take off to {Destination}, {LocalTime}";
            AirplaneEventArgs args = new AirplaneEventArgs(outStr, Name);
            CanLand = true;

            TakeOff?.Invoke(this, args);
        }

        //Change altitude in accordance to delegate
        public string ChangeAltitude(int altitude)
        {
            Altitude = altitude;
            string outStr = $"Altitude for {Name}, changed to {Altitude} m";

            return outStr;
        }

        //To count flight time
        public void SetUpTimer()
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(DispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, FlightTime);
            timer.Start();
        }

        //Once timer interval is reached, initiate landing event
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            CanLand = true;
            StopTimer();
            OnLanding();
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        public override string ToString()
        {
            string outStr = $"{Name}, {FlightID} heading for {Destination}";
            return outStr;
        }

    }
}
