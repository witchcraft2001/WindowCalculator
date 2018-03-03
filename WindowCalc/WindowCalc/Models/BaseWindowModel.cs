using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;

namespace WindowCalc.Models
{
    public class BaseWindowModel : ObservableObjects
    {
        #region Fields
        // Стоимость дм2 стеклопакета
        protected double glassCost = 0.2;
        // Стоимость различных видов фурнитуры
        protected double[,] fittingCost = new double[,]{
            { 0, 0, 0, 0, 0, 0, 0 },
            { 6.4, 6.38, 6.45, 6.44, 6.2, 5.8, 5.7 },
            { 6.4, 6.38, 6.45, 6.44, 6.2, 5.8, 5.7 },
        };
        // Стоимость дм2 москитной сетки
        protected double mosquitGridCost = 0.05;
        protected double[] laminateFactor = { 1, 1.26, 1.5 };
        // Стоимость 10 см отлива
        protected double tideCost = 3;
        // Стоимость 10 см подоконника
        protected double[] sillCost = { 25, 60 };

        protected int width = 100;
        protected int height = 120;
        protected double cost;
        //Фурнитура
        protected bool isFittingExist;
        //Москитная сетка
        protected bool isMosquitGridExist;
        //Отлив
        protected bool isTideExist;
        //Ламинация
        protected WindowLaminateEnum laminate;
        //Фурнитура
        protected FittingTypeEnum fitting;
        #endregion

        #region Properties
        public int Width
        {
            get { return width; }
            set {
                SetProperty(ref width, value);
                OnPropertyChanged("Cost");
            }
        }

        public int Height
        {
            get { return height; }
            set {
                SetProperty(ref height, value);
                OnPropertyChanged("Cost");
            }
        }

        public virtual double Cost
        {
            get { return cost; }
            set { SetProperty(ref cost, value); }
        }

        public bool IsFurnitureExist
        {
            get { return isFittingExist; }
            set {
                SetProperty(ref isFittingExist, value);
                OnPropertyChanged("Cost");
            }
        }

        public bool IsMosquitGridExist
        {
            get { return isMosquitGridExist; }
            set {
                SetProperty(ref isMosquitGridExist, value);
                OnPropertyChanged("Cost");
            }
        }

        public bool IsTideExist
        {
            get { return isTideExist; }
            set {
                SetProperty(ref isTideExist, value);
                OnPropertyChanged("Cost");
            }
        }

        public WindowLaminateEnum Laminate
        {
            get { return laminate; }
            set {
                SetProperty(ref laminate, value);
                OnPropertyChanged("Cost");
            }
        }

        public FittingTypeEnum Fitting
        {
            get { return fitting; }
            set {
                SetProperty(ref fitting, value);
                OnPropertyChanged("Cost");
            }
        }
        #endregion
    }
}
