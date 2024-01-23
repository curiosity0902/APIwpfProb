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
 
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string city1 = "Zocca";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city1}&appid=1cc53945dd6f158c393852119db967f0&units=metric";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
           

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb1.Text = weatherResponse.Name;
            tb2.Text = weatherResponse.Main.Temp.ToString();
            tb3.Text = weatherResponse.Main.feels_like.ToString();
            tb4.Text = weatherResponse.Main.pressure.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string city2 = "Kazan"; 
            string url1 = $"https://api.openweathermap.org/data/2.5/weather?q={city2}&appid=1cc53945dd6f158c393852119db967f0&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url1);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();


            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb11.Text = weatherResponse.Name;
            tb22.Text = weatherResponse.Main.Temp.ToString();
            tb33.Text = weatherResponse.Main.feels_like.ToString();
            tb44.Text = weatherResponse.Main.pressure.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string city3 = "Seoul";
            string url2 = $"https://api.openweathermap.org/data/2.5/weather?q={city3}&appid=1cc53945dd6f158c393852119db967f0&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url2);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();


            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb1t.Text = weatherResponse.Name;
            tb2t.Text = weatherResponse.Main.Temp.ToString();
            tb3t.Text = weatherResponse.Main.feels_like.ToString();
            tb4t.Text = weatherResponse.Main.pressure.ToString();
        }
    }
}

