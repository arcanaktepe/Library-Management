﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcanAktepe.Data.Models;

namespace ArcanAktepe.Data.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllWithAuthor();
        IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate);
        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
