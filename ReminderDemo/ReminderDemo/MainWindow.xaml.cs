using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ReminderDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Meeting> meetings;
        public MainWindow()
        {
            InitializeComponent();
            meetings = new ObservableCollection<Meeting>();
            DateTime currentDate = DateTime.Now;
            schedule.EnableReminderTimer = true;

           meetings.Add(new Meeting()

            {

                StartTime = DateTime.Now.Date.AddHours(9),

                EndTime = DateTime.Now.Date.AddHours(12),

                AppointmentColor = new SolidColorBrush(Color.FromArgb(0xFf, 0xA2, 0xC1, 0x39)),

                Subject = "Business Meeting",

                ReminderTime = ReminderTimeType.TenHours

            });

            meetings.Add(new Meeting()

            {

                StartTime = currentDate.Date.AddDays(1).AddHours(10),

                EndTime = currentDate.Date.AddDays(1).AddHours(16),

                AppointmentColor = new SolidColorBrush(Color.FromArgb(0xFf, 0xD8, 0x00, 0x73)),

                Subject = "Auditing",

                ReminderTime = ReminderTimeType.TwoDays

            });

            meetings.Add(new Meeting()

            {

                StartTime = DateTime.Now.Date.AddDays(7).AddHours(10),

                EndTime = DateTime.Now.Date.AddDays(7).AddHours(13),

                AppointmentColor = new SolidColorBrush(Color.FromArgb(0xFf, 0xF0, 0x96, 0x09)),

                Subject = "Conference",

                ReminderTime = ReminderTimeType.TwoWeeks

            });

            this.schedule.ItemsSource = meetings;
        }
    }
}
