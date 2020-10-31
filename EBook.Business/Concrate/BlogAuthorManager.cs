using EBook.Business.Abstract;
using EBook.Data.Abstract;
using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrate
{
    public class BlogAuthorManager : IBlogAuthorServices
    {
        private IBlogAuthorRepository _blogAuthorRepository;
        public BlogAuthorManager(IBlogAuthorRepository blogAuthorRepository)
        {
            _blogAuthorRepository = blogAuthorRepository;
        }
        public void Create(Bauthor Entity)
        {
            _blogAuthorRepository.Create(Entity);
        }

        public void Delete(Bauthor Entity)
        {
            _blogAuthorRepository.Delete(Entity);
        }

        public List<Bauthor> GetAll()
        {
            return _blogAuthorRepository.GetAll();
        }

        public Bauthor GetBauthorDetails(string Burl)
        {
            return _blogAuthorRepository.GetBauthorDetails(Burl);
        }

        public Bauthor GetById(int id)
        {
            return _blogAuthorRepository.GetById(id);       
        }

        public void Update(Bauthor Entity)
        {
            _blogAuthorRepository.Update(Entity);
        }
    }
}
