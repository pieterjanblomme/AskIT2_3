using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ASKITbyBDK_v2.Models
{
    public class Gebruikers : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

        }


        private int Id;
        private string gebruikersID;
        private string rolcode;
        private string naam;
        private string voornaam;
        private string adres;
        private int postcode;
        private string iban;
        private int stamboeknummer;

        public int ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); }
        }

        public string GebruikersID
        {
            get { return gebruikersID; }
            set { gebruikersID = value; OnPropertyChanged("GebruikersID"); }
        }

        public string Rolcode
        {
            get { return rolcode; }
            set { rolcode = value; OnPropertyChanged("Rolcode"); }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; OnPropertyChanged("Naam"); }
        }
        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; OnPropertyChanged("Voornaam"); }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; OnPropertyChanged("Adres"); }
        }
        public int Postcode
        {
            get { return postcode; }
            set { postcode = value; OnPropertyChanged("Postcode"); }
        }
        public string IBAN
        {
            get { return iban; }
            set { iban = value; OnPropertyChanged("IBAN"); }
        }
        public int Stamboeknummer
        {
            get { return stamboeknummer; }
            set { stamboeknummer = value; OnPropertyChanged("Stamboeknummer"); }
        }
    }
}
