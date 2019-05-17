//using Dg.ERM.Books;
//using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Volo.Abp.Domain.Repositories.MongoDB;
//using Volo.Abp.MongoDB;
//using static Dg.ERM.Books.BookManager;

namespace Dg.ERM.MongoDB
{
    //    public class BookRepository :
    //        MongoDbRepository<BookStoreMongoDbContext, Book, long>,
    //        IBookRepository
    //    {
    //        public BookRepository(IMongoDbContextProvider<BookStoreMongoDbContext> dbContextProvider)
    //            : base(dbContextProvider)
    //        {
    //        }

    //        public async Task DeleteBooksByType(
    //            BookType type,
    //            CancellationToken cancellationToken = default(CancellationToken))
    //        {
    //            await Collection.DeleteManyAsync(
    //                Builders<Book>.Filter.Eq(b => b.Type, type),
    //                cancellationToken
    //            );
    //        }
    //    }
}
