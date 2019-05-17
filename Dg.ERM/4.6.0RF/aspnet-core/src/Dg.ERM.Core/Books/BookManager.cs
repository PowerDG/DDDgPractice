using Abp;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dg.ERM.Books
{
    public class BookManager : DomainService
    {
        private readonly IRepository<Book, long> _bookRepository;

        public BookManager(IRepository<Book, long> bookRepository) //注入默认的仓储
        {
            _bookRepository = bookRepository;
        }


        public interface IBookRepository : IRepository<Book, long>
        {
            Task DeleteBooksByType(
                BookType type,
                CancellationToken cancellationToken = default(CancellationToken)
            );
        }




        public async Task<Book> CreateBook(string name, BookType type)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var book = new Book
            {
                //Id = GuidGenerator.Create(),
                Name = name,
                Type = type
            };

            await _bookRepository.InsertAsync(book);
            //使用仓储中的方法

            return book;
        }
    }
}
