using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASKITbyBDK_v2.Models
{
    public class GebruikersService
    {
        private static List<Gebruikers> ObjGebruikersList;

        public GebruikersService()
        {
            
        }

        public List<Gebruikers> GetAll()
        {
            
        }

 

        public bool Add(Gebruikers objNieuweGebruiker)
        {
            ObjGebruikersList.Add(objNieuweGebruiker);
            return true;
        }

        public bool Update(Gebruikers objGebruikerUpdate)
        {
            bool IsUpdated = false;
 
            return IsUpdated;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            
            return true;
        }

        public bool Search(int id)
        {
            bool isGevonden = false;
            
            return true;
        }

    }
}
