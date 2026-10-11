using System.Collections.Generic;
using uzenetkuldo.Models;

namespace uzenetkuldo.Interfaces
{
    public interface ICRUD
    {
        string Create(Tablazat tablazat);
        List<Tablazat> Read();
        string Update(Tablazat tablazat);
        string Delete(int Id);
    }
}
