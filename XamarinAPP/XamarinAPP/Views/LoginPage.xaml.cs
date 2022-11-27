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

        private void Button_Login(object render, EventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:7104");
            var request = client.GetAsync("/api/Auth/Login").Result;

            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Task<LoginResponse>>(responseJson);
            }

        }

        private void TapGestureRecognizer_Tapped(object render, EventArgs e)
        {

        }
    }
}