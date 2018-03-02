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
    public partial class MainPage : CarouselPage, IMainPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new WindowsTypeViewModel(this);
		}
	}
}
