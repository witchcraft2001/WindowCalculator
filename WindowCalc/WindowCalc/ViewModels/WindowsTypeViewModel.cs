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
            pages.Add(new WindowType() { Description = "Одинарное глухое окно", Image = "k11.png" });
            pages.Add(new WindowType() { Description = "Одинарное окно с поворотной створкой", Image = "k12.png" });
            pages.Add(new WindowType() { Description = "Одинарное окно с поворотно-откидной створкой", Image = "k13.png" });
            pages.Add(new WindowType() { Description = "Двойное окно с поворотной створкой", Image = "k21.png" });
            pages.Add(new WindowType() { Description = "Двойное окно с поворотно-откидной створкой", Image = "k22.png" });
            pages.Add(new WindowType() { Description = "Тройное окно с одной поворотной створкой", Image = "k31.png" });
            pages.Add(new WindowType() { Description = "Тройное окно с одной поворотно-откидной створкой", Image = "k32.png" });
            pages.Add(new WindowType() { Description = "Тройное окно с двумя поворотными створками", Image = "k33.png" });
            pages.Add(new WindowType() { Description = "Тройное окно с двумя поворотно-откидными створками", Image = "k34.png" });
            pages.Add(new WindowType() { Description = "Балконная поворотная дверь", Image = "k41.png" });
            pages.Add(new WindowType() { Description = "Балконный блок с глухим окном и поворотной дверью", Image = "k42.png" });
            pages.Add(new WindowType() { Description = "Балконный блок с глухим окном и поворотно-откидной дверью", Image = "k43.png" });
            Pages = new ObservableCollection<WindowType>(pages);
        }

        #region Commands
        private void DoSelect()
        {
            view.ShowAlert(selectedPosition.ToString());
        } 
        #endregion
    }
}
