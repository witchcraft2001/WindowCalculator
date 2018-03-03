using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using WindowCalc.Helpers;
using WindowCalc.Models;
using WindowCalc.Views;
using Xamarin.Forms;
using Java.Util;
using System.Reflection;
using System.ComponentModel;

namespace WindowCalc.ViewModels
{
    public class SingleWindowViewModel: ObservableObjects
    {
        #region Fields
        private ObservableCollection<WindowType> windowTypes;
        private ISingleWindowPage view;
        private WindowType selectedWindowType;
        private SingleWindowModel model;
        private ObservableCollection<String> fittings;
        private ObservableCollection<String> laminates;
        private ObservableCollection<String> sills;
        private int selectedSill;
        private int selectedFitting;
        private int selectedLaminate;
        #endregion

        #region Properties
        public int SelectedSill
        {
            get { return selectedSill; }
            set {
                Model.Sill = (WindowSillTypeEnum)value;
                SetProperty(ref selectedSill, value);
            }
        }

        public int SelectedFitting
        {
            get { return selectedFitting; }
            set
            {
                Model.Fitting = (FittingTypeEnum)value;
                SetProperty(ref selectedFitting, value);
            }
        }

        public int SelectedLaminate
        {
            get { return selectedLaminate; }
            set
            {
                Model.Laminate = (WindowLaminateEnum)value;
                SetProperty(ref selectedLaminate, value);
            }
        }

        public ObservableCollection<String> Fittings {
            get { return fittings; }
            set { SetProperty(ref fittings, value); }
        }

        public ObservableCollection<String> Laminates
        {
            get { return laminates; }
            set { SetProperty(ref laminates, value); }
        }

        public ObservableCollection<String> Sills
        {
            get { return sills; }
            set { SetProperty(ref sills, value); }
        }

        public ObservableCollection<WindowType> WindowTypes
        {
            get { return windowTypes; }
            set { SetProperty(ref windowTypes, value); }
        }

        public WindowType SelectedWindowType
        {
            get { return selectedWindowType; }
            set {
                Model.WindType = value.Id;
                SetProperty(ref selectedWindowType, value);
            }
        }

        public SingleWindowModel Model
        {
            get {
                if (model == null)
                {
                    model = new SingleWindowModel();
                }
                return model;
            }
            set { SetProperty(ref model, value); }
        }

        public Command OnCalcCommand { get; set; }
        #endregion

        public SingleWindowViewModel(ISingleWindowPage view)
        {
            this.view = view;
            List<WindowType> types = new List<WindowType>();
            types.Add(new WindowType() { Id = 0, Description = "Глухое окно", Image = "k11.png" });
            types.Add(new WindowType() { Id = 1, Description = "Поворотное окно", Image = "k12.png" });
            types.Add(new WindowType() { Id = 2, Description = "Поворотно-откидное окно", Image = "k13.png" });
            WindowTypes = new ObservableCollection<WindowType>(types);
            SelectedWindowType = WindowTypes[0];
            var sills = new List<String>();
            foreach (WindowSillTypeEnum item in Enum.GetValues(typeof(WindowSillTypeEnum)))
            {
                sills.Add(GetDescriptionEnum(item));
            }
            Sills = new ObservableCollection<string>(sills);
            SelectedSill = 0;
            
            var fittings = new List<String>();
            foreach (FittingTypeEnum item in Enum.GetValues(typeof(FittingTypeEnum)))
            {
                fittings.Add(GetDescriptionEnum(item));
            }
            Fittings = new ObservableCollection<string>(fittings);
            SelectedFitting = 0;

            var laminatings = new List<String>();
            foreach (WindowLaminateEnum item in Enum.GetValues(typeof(WindowLaminateEnum)))
            {
                laminatings.Add(GetDescriptionEnum(item));
            }
            Laminates = new ObservableCollection<string>(laminatings);
            SelectedLaminate = 0;
        }

        public string GetDescriptionEnum(Enum item){
            FieldInfo fi = item.GetType().GetField(item.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return item.ToString();
            }
        }
    }
}
