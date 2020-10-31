using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Data.Abstract
{
    public interface IBlogRepository:IRepository<Blog>
    {
        List<Blog> LatestBlog();
        Blog GetBlogDetail(string Url);     

    }
}
