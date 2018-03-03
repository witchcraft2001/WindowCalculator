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
        protected WindowSillTypeEnum sill;
        protected int windType;
        #endregion

        #region Properties
        public WindowSillTypeEnum Sill
        {
            get { return sill; }
            set {
                SetProperty(ref sill, value);
                OnPropertyChanged("Cost");
            }
        }

        public int WindType
        {
            get { return windType; }
            set
            {
                SetProperty(ref windType, value);
                OnPropertyChanged("Cost");
            }
        }

        public override double Cost {
            get
            {
                double result = Width * Height * glassCost;
                // Ламинация профиля
                result *= laminateFactor[(int)Laminate];
                // москитная сетка
                result += (IsMosquitGridExist) ? Width * Height * mosquitGridCost : 0;
                // фурнитура
                result += fittingCost[WindType, (int)Fitting] * (Width + Height) * 2;
                // отлив
                result += (IsTideExist) ? Width * tideCost : 0;
                // Подоконник
                result += sillCost[(int)Sill] * (Width / 10);
                // Монтажные работы
                result += (IsMontageExist) ? montageCost : 0;
                return result;
            }
        }
        #endregion
    }
}
