using Abp.Domain.Repositories;
using Dg.ERM.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dg.ERM
{
    public class BookService : ERMAppServiceBase
    {
        private readonly IRepository<Book, long> _bookRepository;

        private readonly BookManager _bookManager;


        public BookService(IRepository<Book, long> bookRepository,
            BookManager bookManager)
        {
            _bookRepository = bookRepository;
            _bookManager = bookManager;
        }
        public async Task<Book> ddAsync(string name, BookType type)
        {
            var book= await _bookManager.CreateBook(name, type);

            return book;
        }

        //public void Foo()
        //{
        //    IMongoDatabase database = _bookRepository.GetDatabase();
        //    IMongoCollection<Book> books = _bookRepository.GetCollection();
        //}
    }
}
