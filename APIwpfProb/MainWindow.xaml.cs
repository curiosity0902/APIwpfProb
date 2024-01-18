using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using System.Net;
using Newtonsoft.Json;

namespace APIwpfProb
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid=1cc53945dd6f158c393852119db967f0&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            TextBoxxx.Text = response;

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb1.Text = weatherResponse.Name;
            tb2.Text = weatherResponse.Main.Temp.ToString();

        }
    }
}

