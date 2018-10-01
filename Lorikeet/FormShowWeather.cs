using DevExpress.XtraSplashScreen;
using Lorikeet.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormShowWeather : Form
    {
        private WeatherModel weather;
        private ForecastModel forecast;
        private WeatherAndForecast weatherAndForecast;
        private List<TempForecastModel> tempForecast;

        public FormShowWeather()
        {
            InitializeComponent();

            weatherAndForecast = new WeatherAndForecast();
            tempForecast = new List<TempForecastModel>();
        }

        private Bitmap GetIconFromInternet(string code)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create("http://openweathermap.org/img/w/" + code + ".png");
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();
            Bitmap bitmap2 = new Bitmap(responseStream);
            return bitmap2;
        }

        private void setIcons(int startCount)
        {
            pictureBox2.Image = GetIconFromInternet(weather.List[0].Weather[0].Icon);

            pictureBox1.Image = GetIconFromInternet(forecast.List[startCount + 4].Weather[0].Icon);
            pictureBox3.Image = GetIconFromInternet(forecast.List[startCount + 12].Weather[0].Icon);
            pictureBox4.Image = GetIconFromInternet(forecast.List[startCount + 20].Weather[0].Icon);
        }

        private void SetLabelsVisible()
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label30.Visible = true;
            label11.Visible = true;
            label20.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            label31.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label12.Visible = true;
            label15.Visible = true;
            label17.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label16.Visible = true;
            label21.Visible = true;
            label24.Visible = true;
            label26.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label25.Visible = true;
        }

        private void SetLabels()
        {
            if (MiscStuff.CheckForInternetConnection())
            {
                var TempDay1 = new List<double>();
                var TempDay2 = new List<double>();
                var TempDay3 = new List<double>();

                var day1 = DateTime.Today.AddDays(1);
                var startCount = 0;

                foreach (var fcast in forecast.List)
                {
                    if (MiscStuff.GetDateTimeFromUnixTime(fcast.Dt).Day == day1.Day && MiscStuff.GetDateTimeFromUnixTime(fcast.Dt).ToString("h:mm:ss tt").Equals("12:00:00 AM"))
                        break;
                    startCount++;
                }

                for (int x = startCount; x < forecast.List.Count; x++)
                {
                    if (x > (startCount - 1) && x < (startCount + 9))
                    {
                        TempDay1.Add(forecast.List[x].Main.Temp);
                    }
                    if (x > (startCount + 7) && x < (startCount + 17))
                    {
                        TempDay2.Add(forecast.List[x].Main.Temp);
                    }
                    if (x > (startCount + 15) && x < (startCount + 25))
                    {
                        TempDay3.Add(forecast.List[x].Main.Temp);
                    }
                }

                label1.Text = Convert.ToInt32(weather.List[0].Main.Temp) + string.Format("\u00B0") + "C";
                var date = MiscStuff.GetDateTimeFromUnixTime(weather.List[0].Dt);
                label11.Text = "" + date.DayOfWeek + ", " + date.Day + MiscStuff.GetSuffix(date.Day) + " " + date.ToString("MMMM") + ", " + date.Year;
                var date2 = date.AddDays(1);
                label9.Text = "" + date2.DayOfWeek + ", " + date2.Day + MiscStuff.GetSuffix(date2.Day) + " " + date2.ToString("MMMM") + ", " + date2.Year;
                var date3 = date2.AddDays(1);
                label32.Text = "" + date3.DayOfWeek + ", " + date3.Day + MiscStuff.GetSuffix(date3.Day) + " " + date3.ToString("MMMM") + ", " + date3.Year;
                var date4 = date3.AddDays(1);
                label33.Text = "" + date4.DayOfWeek + ", " + date4.Day + MiscStuff.GetSuffix(date4.Day) + " " + date4.ToString("MMMM") + ", " + date4.Year;

                label20.Text = "Australia";
                label2.Text = "Perth, WA";
                label6.Text = weather.List[0].Weather[0].Main;
                label31.Text = weather.List[0].Weather[0].Description;               
                label7.Text = weather.List[0].Main.Humidity + "%";
                label8.Text = weather.List[0].Wind.Speed + "km/h";
                label12.Text = forecast.List[startCount + 4].Weather[0].Main;
                label15.Text = forecast.List[startCount + 12].Weather[0].Main;
                label17.Text = forecast.List[startCount + 20].Weather[0].Main;
                
                label13.Text = forecast.List[startCount + 4].Weather[0].Description;
                label14.Text = forecast.List[startCount + 12].Weather[0].Description;
                label16.Text = forecast.List[startCount + 20].Weather[0].Description;

                TempDay1.Sort();
                TempDay2.Sort();
                TempDay3.Sort();
 
                label21.Text = TempDay1[TempDay1.Count - 1] + string.Format("\u00B0") + "C";
                label24.Text = TempDay2[TempDay2.Count - 1] + string.Format("\u00B0") + "C";
                label26.Text = TempDay3[TempDay3.Count - 1] + string.Format("\u00B0") + "C";

                label22.Text = TempDay1[0] + string.Format("\u00B0") + "C";
                label23.Text = TempDay2[0] + string.Format("\u00B0") + "C";
                label25.Text = TempDay3[0] + string.Format("\u00B0") + "C";
                setIcons(startCount);
            }
            else
            {
                MessageBox.Show("Internet connection is down, try again later");
                this.Close();
            }
        }

        private object GetDateTimeFromUnixTime(long dt)
        {
            throw new NotImplementedException();
        }

        private async void FormShowWeather_LoadAsync(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            var wandf = await weatherAndForecast.GetData("Perth,AU");

            weather = weatherAndForecast.Weather;
            forecast = weatherAndForecast.Forecast;

            SetLabels();
            SplashScreenManager.CloseForm();
            SetLabelsVisible();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
