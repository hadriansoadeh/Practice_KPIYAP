using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad1.Models;

namespace zad1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlFilePath);
        void Add(Flight flight);
        void Delete(string destinationName);
        Flight FindBy(string destinationName);
        List<Flight> GetAll();

    }
}
