using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Control_Tower.Entities
{
    /// <summary>
    /// Event handler for airplanes.
    /// Providing information about 
    /// specific airplanes on events
    /// </summary>
    public class AirplaneEventArgs : EventArgs
    {
        public AirplaneEventArgs(string info, string name)
        {
            Message = info;
            Flight = name;
        }

        public string Flight {  get; set; }
        public string Message { get; set; }
    }
}
