 using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAPP.Models;
using XamarinAPP.ViewModels;

namespace XamarinAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private async void Button_Login(object render, EventArgs e)
        {
            LoginResponse log = new LoginResponse()
            {
                username = txtUsername.Text,
                password = txtPassword.Text
            };

            Uri uri = new Uri("https://localhost:7104/api/Auth/Login");
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(log);
            var Contentjson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri, Contentjson);

            if (response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                await Navigation.PushAsync(new Home());
            }
            else
            {
                await DisplayAlert("Mensaje", "Datos de usuario invalidos", "OK");
            }

        }

        private void TapGestureRecognizer_Tapped(object render, EventArgs e)
        {

        }
    }
}