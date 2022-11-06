using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Button = Xamarin.Forms.Button;

namespace PageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private string ButtonName;
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            ButtonName = button.Text;
            if (ButtonName == "Espresso")
            await Navigation.PushAsync(new EspressoPage());
            if (ButtonName == "Hot Drinks")
            await Navigation.PushAsync(new HotPage());
            if (ButtonName == "Cold Drinks")
            await Navigation.PushAsync(new ColdPage());
            if (ButtonName == "Quick Bites")
            await Navigation.PushAsync(new BitesPage());
        }
        public async void FbButtonClicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("http://facebook.com"), BrowserLaunchMode.SystemPreferred);
        }

        public async void InstaButtonClicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("http://instagram.com"), BrowserLaunchMode.SystemPreferred);
        }

    }
}