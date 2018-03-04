using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;
using WindowCalc.iOS.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(IOSPhoneNumberService))]
namespace WindowCalc.iOS.Helper
{
    public class IOSPhoneNumberService : IPhoneNumberService
    {
        public string GetPhoneNumber()
        {
            return "";
        }
    }
}
