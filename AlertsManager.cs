using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteVehicleManager
{
    internal class AlertsManager
    {
        // Store alert data as list
        private readonly List<(string IconKey, string Time, string Description)> alerts;

        // Constructor
        public AlertsManager()
        {
            alerts = new List<(string, string, string)>();
        }

        // Add a new alert
        public void AddAlert(string iconKey, string time, string description)
        {
            alerts.Add((iconKey, time, description));
        }

        // Get alerts and sort by time
        public List<(string IconKey, string Time, string Description)> GetAlerts()
        {
            return alerts.OrderBy(a => DateTime.Parse(a.Time)).ToList();
        }

        // Clear all alerts
        public void ClearAlerts()
        {
            alerts.Clear();
        }
    }
}
