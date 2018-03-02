using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WindowCalc.Helpers;
using WindowCalc.Models;
using WindowCalc.Views;
using Xamarin.Forms;

namespace WindowCalc.ViewModels
{
    public class SingleWindowViewModel: ObservableObjects
    {
        #region Fields
        private ObservableCollection<WindowType> windowTypes;
        private ISingleWindowPage view;
        private WindowType selectedWindowType;
        private SingleWindowModel model;
        #endregion

        #region Properties
        public ObservableCollection<WindowType> WindowTypes
        {
            get { return windowTypes; }
            set { SetProperty(ref windowTypes, value); }
        }

        public WindowType SelectedWindowType
        {
            get { return selectedWindowType; }
            set { SetProperty(ref selectedWindowType, value); }
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
            types.Add(new WindowType() { Description = "Глухое окно", Image = "k11.png" });
            types.Add(new WindowType() { Description = "Поворотное окно", Image = "k12.png" });
            types.Add(new WindowType() { Description = "Поворотно-откидное окно", Image = "k13.png" });
            WindowTypes = new ObservableCollection<WindowType>(types);
            SelectedWindowType = WindowTypes[0];
        }
    }
}
