﻿using Gk.BookStore.Models;
using Gk.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Gk.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookId(id);

            return View();
        }

        public ViewResult SearchBooks(string bookName , string authorName)
        {
           // var data = _bookRepository.SearchBook( bookName , authorName );

            return View();
        }
    }
}