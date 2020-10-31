using EBook.Business.Abstract;
using EBook.Data.Abstract;
using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrate
{
    public class BlogManager : IBlogServices
    {
        private IBlogRepository _blogRepository;
        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public void Create(Blog Entity)
        {
            _blogRepository.Create(Entity);
        }

        public void Delete(Blog Entity)
        {
            _blogRepository.Delete(Entity);
        }

        public List<Blog> GetAll()
        {
            return _blogRepository.GetAll();
        }

        public Blog GetBlogDetail(string Url)
        {
            return _blogRepository.GetBlogDetail(Url);
        }

        public Blog GetById(int id)
        {
            return _blogRepository.GetById(id);
        }

        public List<Blog> LatestBlog()
        {
            return _blogRepository.LatestBlog();
        }

        public void Update(Blog Entity)
        {
            _blogRepository.Update(Entity);
        }
    }
}
