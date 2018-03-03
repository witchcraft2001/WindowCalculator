using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;

namespace WindowCalc.Models
{
    public class SingleWindowModel : BaseWindowModel
    {
        #region Fields
        //Подоконник
        private WindowSillTypeEnum sill;
        //Тип окна
        private WindowTypeEnum windType;
        #endregion

        #region Properties
        public WindowSillTypeEnum Sill
        {
            get { return sill; }
            set { SetProperty(ref sill, value); }
        }
        #endregion
    }
}
