using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hw_06_03_2025
{
    public partial class Form1 : Form
    {
        private readonly string apiKey = "YOUR_API_KEY";
        private readonly string baseUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=uk";

        public Form1()
        {
            InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            string cityName = CityTextBox.Text.Trim();
            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Будь ласка, введіть назву міста.");
                return;
            }

            WeatherInfoLabel.Text = "Завантаження...";
            string weatherData = await GetWeatherData(cityName);
            WeatherInfoLabel.Text = weatherData;
        }

        private async Task<string> GetWeatherData(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = string.Format(baseUrl, city, apiKey);
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return ParseWeatherData(responseBody);
                }
                catch (Exception ex)
                {
                    return "Помилка: " + ex.Message;
                }
            }
        }

        private string ParseWeatherData(string json)
        {
            var data = JsonConvert.DeserializeObject<WeatherData>(json);
            if (data == null || data.Main == null || data.Weather == null || data.Weather.Length == 0)
                return "Не вдалося отримати інформацію про погоду.";

            string cityName = data.Name;
            string temperature = data.Main.Temp.ToString();
            string description = char.ToUpper(data.Weather[0].Description[0]) + data.Weather[0].Description.Substring(1);

            return $"Місто: {cityName}\nТемпература: {temperature}°C\nОпис: {description}";
        }

        public class WeatherData
        {
            public string Name { get; set; }
            public MainData Main { get; set; }
            public Weather[] Weather { get; set; }
        }

        public class MainData
        {
            public float Temp { get; set; }
        }

        public class Weather
        {
            public string Description { get; set; }
        }
    }
}
