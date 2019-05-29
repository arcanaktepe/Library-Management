using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcanAktepe.Data.Interfaces;
using ArcanAktepe.Data.Models;
using ArcanAktepe.ViewModel;
using Microsoft.AspNetCore.Mvc;
namespace ArcanAktepe.Controllers
{
    public class ReturnController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICustomerRepository _customerRepository;

        public ReturnController(IBookRepository bookRepository, ICustomerRepository customerRepository)
        {
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
        }

        [Route("Return")]
        public IActionResult List()
        {
            
            var borrowedBooks = _bookRepository.FindWithAuthorAndBorrower(x => x.BorrowerId != 0);
          
            if (borrowedBooks == null || borrowedBooks.ToList().Count() == 0)
            {
                return View("Empty");
            }
            return View(borrowedBooks);
        }

        public IActionResult ReturnABook(int bookId)
        {
           
            var book = _bookRepository.GetById(bookId);
          
            book.Borrower = null;

            book.BorrowerId = null;
         
            _bookRepository.Update(book);
          
            return RedirectToAction("List");
        }
    }
}
