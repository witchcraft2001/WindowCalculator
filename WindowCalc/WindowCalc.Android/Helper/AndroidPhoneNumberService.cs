using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Telephony;
using Android.Views;
using Android.Widget;
using WindowCalc.Droid.Helper;
using WindowCalc.Helpers;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidPhoneNumberService))]
namespace WindowCalc.Droid.Helper
{
    public class AndroidPhoneNumberService : IPhoneNumberService
    {
        public string GetPhoneNumber()
        {
            TelephonyManager telephonyManager;
            telephonyManager = Application.Context.GetSystemService(Context.TelephonyService) as TelephonyManager;
            return telephonyManager.Line1Number;
        }
    }
}