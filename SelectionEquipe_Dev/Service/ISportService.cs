using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev.Service
{
    public interface ISportService
    {
        void Insert(Sport s);

        List<Sport> GetAll();

        Sport GetById(int id);

        Sport FindByName(string name);
        void Delete(int id);
    }
}
