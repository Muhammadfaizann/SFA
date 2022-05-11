using Newtonsoft.Json;
using SFA.Models;
using SFA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFA.Views
{
    public partial class Addnewproject : ContentPage
    {
      

        public Addnewproject()
        {
            InitializeComponent();
            LoadClientsfromJson();
            
        }

        protected override void OnAppearing()
        {

            base.OnAppearing();
            
        }
        private void LoadClientsfromJson()
        {
            try
            {
                Assembly assembly = typeof(App).Assembly;
                using (Stream stream = assembly.GetManifestResourceStream("SFA.client.json"))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        var jsonString = reader.ReadToEnd();
                        var clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
                        clientList.DataSource = clients;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}