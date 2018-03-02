using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;

namespace WindowCalc.Models
{
    public class SingleWindowModel : ObservableObjects
    {
        #region Fields
        private int width = 100;
        private int height = 120;
        private double cost;
        #endregion

        #region Properties
        public int Width
        {
            get { return width; }
            set { SetProperty(ref width, value); }
        }

        public int Height
        {
            get { return height; }
            set { SetProperty(ref height, value); }
        }

        public double Cost
        {
            get { return cost; }
            set { SetProperty(ref cost, value); }
        }
        #endregion
    }
}
