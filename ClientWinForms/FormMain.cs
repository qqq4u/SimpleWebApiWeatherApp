using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClientWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void FillWeatherDataGridView()
        {
            HttpClient httpClient = new HttpClient();

            string data = JsonConvert.SerializeObject("selectAll");

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:44303/api/Weather/GetAll", content);
            string responseJson = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                List<WeatherData> dataList = JsonConvert.DeserializeObject<List<WeatherData>>(responseJson);

                dataGridViewWeatherData.DataSource = null;

                dataGridViewWeatherData.DataSource = dataList;
            }
            else
            {
                string error = JsonConvert.DeserializeObject<string>(responseJson);
                MessageBox.Show("Ошибка при загрузке данных:\n" + (int)responseMessage.StatusCode + "  " + responseMessage.StatusCode + "   " + error);
            }
        }

        private async void buttonGetWeatherData_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            string data = JsonConvert.SerializeObject("selectAll");

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:44303/api/Weather/GetAll", content);
            string responseJson = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                List<WeatherData> dataList = JsonConvert.DeserializeObject<List<WeatherData>>(responseJson);
                MessageBox.Show("Данные успешно получены");
                dataGridViewWeatherData.DataSource = null;

                dataGridViewWeatherData.DataSource = dataList;
            }
            else
            {
                string error = JsonConvert.DeserializeObject<string>(responseJson);
                MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.StatusCode + "   " + error);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private async void buttonGetByName_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();

            string data = JsonConvert.SerializeObject(textBoxName.Text);

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:44303/api/Weather/GetByCityName", content);
            string responseJson = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseJson);
                if (weatherData == null)
                {
                    MessageBox.Show("Такой город не существует");
                }
                else
                {
                    MessageBox.Show($"{weatherData.CityName} ---  {weatherData.Temperature}");
                }

            }
            else
            {
                string error = JsonConvert.DeserializeObject<string>(responseJson);
                MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.StatusCode + "   " + error);
            }

        }

        private async void buttonAddCity_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            string cityName = "";
            int cityTemperature = int.MinValue;
            try
            {
                cityName = textBoxAddCityName.Text;
                cityTemperature = Convert.ToInt32(textBoxAddCityTemperature.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных");
            }

            WeatherData weatherData = new WeatherData()
            {
                CityName = cityName,
                Temperature = cityTemperature
            };

            string data = JsonConvert.SerializeObject(weatherData);


            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:44303/api/Weather/AddCity", content);
            string responseJson = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Город успешно добавлен");
                FillWeatherDataGridView();
            }
            else
            {
                string error = JsonConvert.DeserializeObject<string>(responseJson);
                MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.StatusCode + "   " + error);
            }

            // вопрос - если не возвращать значение листа, и метод будет войдовский, то как делать?


        }

        private async void buttonDeleteByName_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            string cityName = "";

            if (textBoxDeleteByName.Text != string.Empty)
            {
                cityName = textBoxDeleteByName.Text;

                string data = JsonConvert.SerializeObject(cityName);

                // он всё равно удаляет мразота такая
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage =
                    await httpClient.PostAsync("http://localhost:44303/api/Weather/DeleteCityByName", content);
                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show($"Город {cityName} успешно удалён!");
                    FillWeatherDataGridView();
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.StatusCode + "   " + error);
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность вводимых данных");
            }

        }

        private void dataGridViewWeatherData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.textBoxDeleteByName.Text = dataGridViewWeatherData.SelectedRows[0].Cells[0].ToString();
            //придумать
        }

        private async void buttonGiveException_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            string data = JsonConvert.SerializeObject(true);

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:44303/api/Weather/GetException", content);
            string responseJson = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                WeatherData wd = JsonConvert.DeserializeObject<WeatherData>(responseJson);
                MessageBox.Show(wd.CityName + " - - - " + wd.Temperature);
            }
            else
            {
                string error = JsonConvert.DeserializeObject<string>(responseJson);
                MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.StatusCode + "   " + error);
            }
        }

        private void dataGridViewWeatherData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxDeleteByName.Text = dataGridViewWeatherData.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
