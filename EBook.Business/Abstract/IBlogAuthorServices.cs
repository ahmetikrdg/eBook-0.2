using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IBlogAuthorServices
    {
        Bauthor GetById(int id);
        List<Bauthor> GetAll();
        void Create(Bauthor Entity);
        void Update(Bauthor Entity);
        void Delete(Bauthor Entity);
        Bauthor GetBauthorDetails(string Burl);

    }
}
