using System;
using System.IO;

namespace Vending_Machine_Blake_Hunt
{
    public static class Logger
    {
        private const string LOG_FILE = "vending_activity.txt";

        public static void LogVendingActivity(string itemName)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"{timestamp} - Vended: {itemName}\n";
            
            try
            {
                File.AppendAllText(LOG_FILE, logEntry);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }

        public static string GetVendingHistory()
        {
            try
            {
                if (File.Exists(LOG_FILE))
                {
                    return File.ReadAllText(LOG_FILE);
                }
                return "No vending history found.";
            }
            catch (Exception ex)
            {
                return $"Error reading log file: {ex.Message}";
            }
        }
    }
}
