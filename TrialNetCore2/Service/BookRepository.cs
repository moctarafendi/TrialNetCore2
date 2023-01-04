using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialNetCore2.IService;
using TrialNetCore2.Models;

namespace TrialNetCore2.Service
{
    public class BookRepository : IBookRepository
    {
        // private List<Book> _books;
        private readonly PustakaDbContext _dbContext;

        public BookRepository(PustakaDbContext dbContext)
        {
            _dbContext = dbContext;
            //if (_books == null)
            //{
            //    //InitializeBooks();
            //}
        }        

        //private void InitializeBooks()
        //{
        //    _books = new List<Book>()
        //    {
        //        new Book
        //        {
        //            Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile",
        //            Penulis = "Junindar",
        //            Deskripsi = "",
        //            Status = true,
        //            Gambar = "/images/gambar1.jpg"
        //        },
        //        new Book
        //        {
        //            Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 2",
        //            Penulis = "Junindar",
        //            Deskripsi = "",
        //            Status = true,
        //           Gambar = "/images/gambar2.jpg"
        //        },
        //        new Book
        //        {
        //            Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 3",
        //            Penulis = "Junindar",
        //            Deskripsi = "",
        //            Status = true,
        //             Gambar = "/images/gambar3.jpg"
        //        },
        //        new Book
        //        {
        //            Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 4",
        //            Penulis = "Junindar",
        //            Deskripsi = "",
        //            Status = true,
        //             Gambar = "/images/gambar4.jpg"
        //        },
        //        new Book
        //        {
        //            Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 5",
        //            Penulis = "Junindar",
        //            Deskripsi = "",
        //            Status = true,
        //             Gambar = "/images/gambar5.jpg"
        //        },
        //    };
        //}

        IEnumerable<Book> IBookRepository.GetAllBooks()
        {
            return _dbContext.Books;
        }

        Book IBookRepository.GetBookById(int bookId)
        {
            return _dbContext.Books.FirstOrDefault(x=>x.Id == bookId);
        }

        void IBookRepository.Insert(Book book)
        {
            _dbContext.Add(book);
            _dbContext.SaveChanges();
        }

        void IBookRepository.Update(Book book)
        {
            _dbContext.Update(book);
            _dbContext.SaveChanges();
        }

        void IBookRepository.Delete(int bookId)
        {
            var book = _dbContext.Books.Find(bookId);
            _dbContext.Remove(book);
            _dbContext.SaveChanges();
        }
    }

}
