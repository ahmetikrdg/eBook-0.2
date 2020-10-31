using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IBlogServices
    {
        Blog GetById(int id);
        List<Blog> GetAll();
        void Create(Blog Entity);
        void Update(Blog Entity);
        void Delete(Blog Entity);
        List<Blog> LatestBlog();
        Blog GetBlogDetail(string Url);


    }
}
