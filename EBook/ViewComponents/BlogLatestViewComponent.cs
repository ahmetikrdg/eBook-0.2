using EBook.Data.Abstract;
using EBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.ViewComponents
{
    public class BlogLatestViewComponent: ViewComponent
    {
        private IBlogRepository _blogRepository;
        public BlogLatestViewComponent(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IViewComponentResult Invoke()
        {
            var model = new BlogListViewModel
            {
                Blogs = _blogRepository.LatestBlog()
            };
            return View(model);
        }
    }
}
