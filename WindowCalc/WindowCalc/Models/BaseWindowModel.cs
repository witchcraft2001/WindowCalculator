using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;

namespace WindowCalc.Models
{
    public class BaseWindowModel : ObservableObjects
    {
        #region Fields
        private int width = 100;
        private int height = 120;
        private double cost;
        //Фурнитура
        private bool isFurnitureExist;
        //Москитная сетка
        private bool isMosquitGridExist;
        //Отлив
        private bool isTideExist;
        //Ламинация
        private WindowLaminateEnum laminate;
        //Фурнитура
        private FittingTypeEnum fitting;
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

        public bool IsFurnitureExist
        {
            get { return isFurnitureExist; }
            set { SetProperty(ref isFurnitureExist, value); }
        }

        public bool IsMosquitGridExist
        {
            get { return isMosquitGridExist; }
            set { SetProperty(ref isMosquitGridExist, value); }
        }

        public bool IsTideExist
        {
            get { return isTideExist; }
            set { SetProperty(ref isTideExist, value); }
        }

        public WindowLaminateEnum Laminate
        {
            get { return laminate; }
            set { SetProperty(ref laminate, value); }
        }

        public FittingTypeEnum Fitting
        {
            get { return fitting; }
            set { SetProperty(ref fitting, value); }
        }
        #endregion
    }
}
