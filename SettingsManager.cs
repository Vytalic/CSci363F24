using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteVehicleManager
{
    internal class SettingsManager
    {
        public static string FontSize { get; set; } = "12";
        public static string Theme { get; set; } = "Dark";
        public static string Temperature { get; set; } = "Fahrenheit";
        public static string TimeFormat { get; set; } = "12-Hour";
        public static string UpdateFrequency { get; set; } = "Daily";
        public static string Vibration { get; set; } = "Off";
        

        public static void LoadSettings(string filePath)
        {
            if(File.Exists(filePath))
            {
                var line = File.ReadAllLines(filePath).FirstOrDefault();
                if (line != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length>= 6)
                    {
                        FontSize = parts[0];
                        Temperature = parts[1];
                        Theme = parts[2];
                        TimeFormat = parts[3];
                        UpdateFrequency = parts[4];
                        Vibration = parts[5];
                    }
                }
            }
        }

        public static void SaveSettings(string filePath)
        {
            var settings = $"{FontSize},{Temperature},{Theme},{TimeFormat},{UpdateFrequency},{Vibration}";
            File.WriteAllText(filePath, settings);
        }
    }
}
