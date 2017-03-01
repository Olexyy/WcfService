using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceClient.ServiceReference;

namespace WCFServiceClient
{
    public partial class WeatherInfo : Form
    {
        Timer timer;
        private User User { get; set; }
        public WeatherInfo()
        {
            this.InitializeComponent();
            this.timer = new Timer();
            this.timer.Tick += this.GetWeatherInfo;
            this.timer.Interval = 600000;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.User = loginForm.User;

            this.timer.Start();
            this.ValuesUpdating();
            this.GetWeatherInfoAsync();
        }
        private void GetWeatherInfo(object sender = null, EventArgs args = null)
        {
            using (ContractClient client = new ContractClient())
            {
                WeathersCo weathersCo = client.GetWeather("Lviv");
                this.Invoke(new Action(() => { this.UpdateValues(weathersCo); }));
            }
        }
        private void GetWeatherInfoAsync(object sender = null, EventArgs args = null)
        {
            Task.Run(() => this.GetWeatherInfo(sender, args));
        }
        private void ValuesUpdating(string message = "updating")
        {
            this.textBoxDate.Text = message;
            this.textBoxDay.Text = message;
            this.textBoxHumidity.Text = message;
            this.textBoxLocation.Text = message;
            this.textBoxSkyText.Text = message;
            this.textBoxTemperature.Text = message;
            this.textBoxWind.Text = message;
        }
        private void UpdateValues(WeathersCo weathersCo)
        {
            this.textBoxDate.Text = weathersCo.data.date;
            this.textBoxDay.Text = weathersCo.data.day;
            this.textBoxHumidity.Text = weathersCo.data.humidity;
            this.textBoxLocation.Text = weathersCo.data.location;
            this.textBoxSkyText.Text = weathersCo.data.skytext;
            this.textBoxTemperature.Text = weathersCo.data.temperature;
            this.textBoxWind.Text = weathersCo.data.wind;
        }
        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            using (ContractClient client = new ContractClient())
            {
                if (client.DeleteUser(this.User))
                {
                    MessageBox.Show("User deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LogOut();
                }
                else
                    MessageBox.Show("User can't be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.User = null;
            this.LogOut();
        }
        private void LogOut()
        {
            this.Hide();
            this.timer.Stop();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.User = loginForm.User;
            this.Show();
        }
        private void UpdateUser(User user = null)
        {
            if (user == null)
                user = this.User;
            using (ContractClient client = new ContractClient())
            {
                if (client.UpdateUser(this.User))
                    MessageBox.Show("User updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User can't be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            var changeProfileForm = new ChangeProfileForm(this.User);
            changeProfileForm.ShowDialog();
            if (changeProfileForm.Result == ChangeProfileForm.Results.Apply)
                this.UpdateUser(changeProfileForm.User);
        }
    }
}
