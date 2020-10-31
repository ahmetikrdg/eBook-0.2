using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EBook.Models;
using EBook.Business.Abstract;
using EBook.Entity;

namespace EBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookService _bookServices;
        private IAuthorServices _authorServices;
        private IBlogServices _blogServices;
        private IBlogAuthorServices _blogAuthorServices;
      


        public HomeController(ILogger<HomeController> logger, IBookService bookService, IAuthorServices authorServices, IBlogServices blogServices, IBlogAuthorServices blogAuthorServices)
        {
            _logger = logger;
            _bookServices = bookService;
            _authorServices = authorServices;
            _blogServices = blogServices;
            _blogAuthorServices = blogAuthorServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BookList(string category,int page=1)
        {
            const int pagesize = 2;
            var BookViewModel = new BookListViewModel()
            {
                pageInfo = new PageInfo()
                {
                    TotalItems = _bookServices.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = pagesize,
                    CurrentCategory = category
                },
                Books = _bookServices.GetBooksByCategory(category, page, pagesize)
            };

            return View(BookViewModel);
        }

        public IActionResult BookDetails(string Url)
        {
            Book book = _bookServices.GetBookDetails(Url);
            var tut = book.BookCategories.Select(i=>i.Categories).FirstOrDefault();
            var getbooks = _bookServices.GetCategoryBook(tut);
            ViewBag.BookCategory = getbooks;
            return View(new BookDetailModel()
            {
                Book = book,
                Category=book.BookCategories.Select(i=>i.Categories).ToList(),
                Author=book.BookAuthors.Select(i=>i.Author).FirstOrDefault()
            });
        }
        /* şuan burası pasif 
        public IActionResult BookRead(int id)
        {
            Book book = _bookService.GetBookReadDetails(id);

            return View(new BookDetailModel()
            {
                Book = book,
                Category = book.BookCategories.Select(i => i.Categories).ToList()

            });
        } */

        public IActionResult AuthorList()
        {
            AuthorListViewModel authorListViewModel = new AuthorListViewModel()//şurayı sor () olmadanda çalışıyor neden?
            {
                Authors = _authorServices.GetAll()
            };
            return View(authorListViewModel);
        }
        public IActionResult AuthorDetail(string Yurl)           
        {   
            Author author = _authorServices.GetAuthorDetails(Yurl);
            return View(new AuthorDetailModel { 
            Author=author,
            Books=author.BookAuthors.Select(i=>i.Book).ToList()
            });
        }

        public IActionResult BlogList() 
        {
            BlogListViewModel blogListViewModel = new BlogListViewModel()//şurayı sor () olmadanda çalışıyor neden?
            {
                Blogs = _blogServices.GetAll()
            };
            return View(blogListViewModel); 
        }

        public IActionResult BlogDetail(string Burl)    
        {
            Blog blog = _blogServices.GetBlogDetail(Burl);
            BlogDetailModel blogDetailModel = new BlogDetailModel()//şurayı sor () olmadanda çalışıyor neden?
            {
                Blog =blog,
                Bauthor=blog.BlogAuthors.Select(i=>i.Bauthor).FirstOrDefault()
            };
            return View(blogDetailModel);
        }



        public IActionResult BlogAuthorList()             
        {
            BlogAuthorListViewModel blogAuthorListViewModel = new BlogAuthorListViewModel()
            {
                BAuthor = _blogAuthorServices.GetAll()
            };
            return View(blogAuthorListViewModel);
        }
        public IActionResult BlogAuthorDetail(string Byurl)
        {
            Bauthor author = _blogAuthorServices.GetBauthorDetails(Byurl);
            return View(new BauthorDetailModel
            {
                Author = author,
                Blog =author.BlogAuthors.Select(i => i.Blog).ToList()
            });
        }



















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
