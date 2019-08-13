using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinAppDriverUIRecorder
{
    public class Logger
    {
        public static void Write(string filePath, string text)
        {
            try
            {
                File.AppendAllText(filePath, DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + " $ " + text);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occurred while writing the report, please make sure that the report file is not open.");

            }
        }

        public static void WriteAsSimpleCSV(string filePath, string text)
        {
            try
            {
                File.AppendAllText(filePath, DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + " , " + text);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occurred while writing the report, please make sure that the report file is not open.");

            }
        }

        public static void LogError(string errorText)
        {
            try
            {
                File.AppendAllText("C:\\RecorderErrorLogs.txt", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + " , " + errorText);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occored when trying log an error");

            }
        }
    }
}
