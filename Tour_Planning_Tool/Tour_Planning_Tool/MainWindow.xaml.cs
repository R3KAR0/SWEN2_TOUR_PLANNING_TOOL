using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using Tour_Planning_Tool.DataAccessLayer.Mappers;

namespace Tour_Planning_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ConfigMapper? configMapper;
        public MainWindow()
        {
            Log.Information("Initialize MainWindow and mappers!");
            SetupMapper();
            InitializeComponent();
        }

        public static ConfigMapper? GetConfigMapper()
        {
            if (configMapper == null)
            {
                SetupMapper();
            }
            return configMapper;
        }

        private static void SetupMapper(string configMapperConfig = "..\\..\\..\\config.json")
        {
            using (var sr = new StreamReader(configMapperConfig))
            {
                try
                {
                    configMapper = JsonSerializer.Deserialize<ConfigMapper>(sr.ReadToEnd());
                    Log.Information("ConfigMapper loaded successfully!");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
