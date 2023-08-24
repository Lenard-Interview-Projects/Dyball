/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   The DateManager is used to get and update the current zoo date as well
|   as updating the UI on the screen for the user.
|
|--------------------------------------*/
using System;
using System.Windows.Forms;

namespace ZooSimulator.Utils
{
    public class DateManager
    {
        private DateTime currentDate;
        public DateTime CurrentDate { get => currentDate; }

        public string GetDate       { get { return currentDate.ToString("MMMM yyyy");   }}
        public string GetDay        { get { return currentDate.DayOfWeek.ToString();    }}
        
        public string GetTime       { get { return currentDate.ToString("HH:mm");   }}
        public string GetTimeStamp  { get { return currentDate.ToString("tt");      }}

        public DateManager()
        {
            currentDate = DateTime.Now;
        }

        public void AddMinutes()
        {
            currentDate = currentDate.AddMinutes(1.0);
        }

        public void AddHours()
        {
            currentDate = CurrentDate.AddHours(1.0);
        }

        public void UpdateDateUI(Label monthYear, Label day, Label time, Label stamp)
        {
            monthYear.Text  = GetDate;
            day.Text        = GetDay;
            time.Text       = GetTime;
            stamp.Text      = GetTimeStamp;
        }
    }
}
