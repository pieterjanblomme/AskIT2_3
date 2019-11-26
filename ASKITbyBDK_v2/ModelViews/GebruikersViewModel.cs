using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ASKITbyBDK_v2.Models;

namespace ASKITbyBDK_v2.ModelViews
{
   
    public class GebruikersViewModel: INotifyPropertyChanged
    {
        #region InotiFyPropertyChanged_Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

        GebruikersService objgebruikersService;
        public GebruikersViewModel()
        {
            objgebruikersService = new GebruikersService();
            LoadData();
        }


        #region DisplayOperation
        private List<Gebruikers> gebruikersList;

        //private ObservableCollection<Gebruikers> gebruikers;
        //public ObservableCollection<Gebruikers> gebruikers
        //{
        //    get { return gebruikersList; }
        //    set { gebruikersList = value; }


        public List<Gebruikers> GebruikersList
        {
            get { return gebruikersList; }
            set { gebruikersList = value; OnPropertyChanged("Gebruikerslijst"); }
        }
        private void LoadData()
        {
            GebruikersList = objgebruikersService.GetAll();
        }
        #endregion



    }
}
