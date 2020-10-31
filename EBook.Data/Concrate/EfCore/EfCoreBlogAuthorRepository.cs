using EBook.Data.Abstract;
using EBook.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBook.Data.Concrate.EfCore
{
    public class EfCoreBlogAuthorRepository : EfCoreGenericRepository<Bauthor, BookContext>, IBlogAuthorRepository
    {
        public Bauthor GetBauthorDetails(string Burl)       
        {
            using(var context=new BookContext())
            {
                return context.Bauthors.Where(i => i.Url == Burl).Include(i => i.BlogAuthors).ThenInclude(i => i.Blog).FirstOrDefault();
            }
        }
    }
}
