using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WindowCalc.Models;
using WindowCalc.Views;
using Xamarin.Forms;

namespace WindowCalc.ViewModels
{
    public class WindowsTypeViewModel: BaseViewModel
    {
        #region Fields
        private ObservableCollection<WindowType> pages;
        private IMainPage view;
        private int selectedPosition;
        #endregion

        #region Properties
        public ObservableCollection<WindowType> Pages
        {
            get { return pages; }
            set { SetProperty(ref pages, value); }
        }

        public int SelectedPosition
        {
            get { return selectedPosition; }
            set { SetProperty(ref selectedPosition, value); }
        }

        public Command OnSelectCommand { get; set; }
        #endregion

        public WindowsTypeViewModel(IMainPage view)
        {
            this.view = view;
            OnSelectCommand = new Command(DoSelect);
            List<WindowType> pages = new List<WindowType>();
            pages.Add(new WindowType() { Description = "Одинарное окно", Image = "k12.png" });
            pages.Add(new WindowType() { Description = "Двойное окно", Image = "k21.png" });
            pages.Add(new WindowType() { Description = "Тройное окно", Image = "k31.png" });
            pages.Add(new WindowType() { Description = "Балконная дверь", Image = "k41.png" });
            pages.Add(new WindowType() { Description = "Балконный блок с дверью", Image = "k42.png" });
            Pages = new ObservableCollection<WindowType>(pages);
        }

        #region Commands
        private void DoSelect()
        {
            //view.ShowAlert(selectedPosition.ToString());
            view.NavigateToSingleWindowCalculator();
        } 
        #endregion
    }
}
