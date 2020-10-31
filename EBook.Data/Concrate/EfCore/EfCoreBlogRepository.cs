using EBook.Data.Abstract;
using EBook.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBook.Data.Concrate.EfCore
{
    public class EfCoreBlogRepository : EfCoreGenericRepository<Blog, BookContext>, IBlogRepository
    {
        public Blog GetBlogDetail(string Url)
        {
            using (var context = new BookContext())
            {
                return context.Blogs.Where(i => i.Url == Url).Include(i => i.BlogAuthors).ThenInclude(i => i.Bauthor)
                    .FirstOrDefault();
            }
        }

        public List<Blog> LatestBlog()
        {
            using(var context=new BookContext())
            {
                return context.Blogs.OrderByDescending(i => i.BlogId).Take(7).ToList();
            }
        }
    }
}
