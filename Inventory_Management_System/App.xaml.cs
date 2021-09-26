using Inventory_Management_System.Helpers;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory_Management_System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            var config = new NLog.Config.LoggingConfiguration();
            NLog.Targets.FileTarget logfile = new NLog.Targets.FileTarget("logfile") { FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Inventory", "Logs", DateTime.Today.ToString("yyyyMMdd", DateTimeFormatInfo.InvariantInfo) + ".txt") };

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;


            NLogger.Logger.Info("Program basladi");
            
            
        }
    }
}
