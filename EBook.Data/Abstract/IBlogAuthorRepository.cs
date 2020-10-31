using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Data.Abstract   
{
    public interface IBlogAuthorRepository:IRepository<Bauthor>
    {
        Bauthor GetBauthorDetails(string Burl);     

    }
}
        