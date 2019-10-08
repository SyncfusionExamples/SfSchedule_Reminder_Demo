using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ReminderDemo
{
    /// <summary>
    /// Represents custom data properties.
    /// </summary>
    public class Meeting
    {
        public String Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Brush AppointmentColor { get; set; }
        public ReminderTimeType ReminderTime { get; set; }
    }
}
