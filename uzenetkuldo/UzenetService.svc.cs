using System.Collections.Generic;
using uzenetkuldo.Models;
using uzenetkuldo.Services;

namespace uzenetkuldo
{

    public class UzenetService : IUzenetService
    {
        public string CreateUzenet(Uzenet uzenet)
        {
            return new UzenetServices().Create(uzenet);
        }
        public string DeleteUzenet(int id)
        {
            return new UzenetServices().Delete(id);
        }
        public List<Uzenet> GetAllUzenet()
        {
            List<Tablazat> tablazatok = new UzenetServices().Read();
            List<Uzenet> uzenetlista = new List<Uzenet>();
            foreach (Tablazat elem in tablazatok)
            {
                uzenetlista.Add(elem as Uzenet);
            }
            return uzenetlista;
        }
        public string UpdateUzenet(Uzenet uzenet)
        {
            return new UzenetServices().Update(uzenet);
        }

    }
}
