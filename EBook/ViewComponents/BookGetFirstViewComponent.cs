using EBook.Data.Abstract;
using EBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.ViewComponents
{
    public class BookGetFirstViewComponent: ViewComponent
    {
        private IBookRepository _bookRepository;
        public BookGetFirstViewComponent(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IViewComponentResult Invoke()
        {
            var model = new BookListViewModel
            {
                Books = _bookRepository.GetAllFirst()
            };
            return View(model);
        }
    }
}
