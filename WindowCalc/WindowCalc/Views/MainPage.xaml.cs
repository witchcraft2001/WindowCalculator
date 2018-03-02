using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowCalc.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindowCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage, IMainPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new WindowsTypeViewModel(this);
		}

        public async void NavigateToSingleWindowCalculator()
        {
            await Navigation.PushAsync(new SingleWindowPage());
        }

        public void ShowAlert(string text)
        {
            DisplayAlert("Сообщение", $"Выбрано окно с номером {text}", "OK");
        }
    }
}
