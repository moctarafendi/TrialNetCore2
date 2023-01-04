using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialNetCore2.Models;

namespace TrialNetCore2.IService
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void Insert(Book book);
        void Update(Book book);
        void Delete(int bookId);
    }
}
