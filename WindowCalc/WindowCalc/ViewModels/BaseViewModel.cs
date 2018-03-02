using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;

namespace WindowCalc.ViewModels
{
    public class BaseViewModel: ObservableObjects
    {
        #region Fields
        string title = string.Empty;
        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        #endregion
    }
}
