using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;
using WindowCalc.Views;
using Xamarin.Forms;

namespace WindowCalc.ViewModels
{
    public class OrderViewModel: ObservableObjects
    {
        #region Fields
        private string phone;
        private string name;
        private IOrderPage view;
        #endregion

        #region Properties
        public string Phone
        {
            get { return phone; }
            set { SetProperty(ref phone, value); }
        }

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        #endregion

        public OrderViewModel(IOrderPage view)
        {
            this.view = view;
            Phone = DependencyService.Get<IPhoneNumberService>().GetPhoneNumber();
            Name = Environment.UserName;
        }
    }
}
