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
            pages.Add(new WindowType() { Description = "Одностворчатое окно", Image = "k12_big.png" });
            pages.Add(new WindowType() { Description = "Двустворчатое окно", Image = "k21_big.png" });
            pages.Add(new WindowType() { Description = "Трёхстворчатое окно", Image = "k31_big.png" });
            pages.Add(new WindowType() { Description = "Балконная дверь", Image = "k41_big.png" });
            pages.Add(new WindowType() { Description = "Балконный блок с дверью", Image = "k42_big.png" });
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
