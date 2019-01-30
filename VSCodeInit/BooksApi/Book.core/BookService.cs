using System.Collections.Generic;
using System.Linq;
using BooksApi.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace BooksApi.Services {
    public class BookService {
        private readonly IMongoCollection<Book> _books;

        public BookService (IConfiguration config) {
            var client = new MongoClient (config.GetConnectionString ("BookstoreDb"));
            var database = client.GetDatabase ("BookstoreDb");
            _books = database.GetCollection<Book> ("Books");
        }

        public List<Book> Get () {
            return _books.Find (book => true).ToList ();
        }

        public Book Get (string id) {
            return _books.Find<Book> (book => book.Id == id).FirstOrDefault ();
        }

        public Book Create (Book book) {
            _books.InsertOne (book);
            return book;
        }

        public void Update (string id, Book bookIn) {
            _books.ReplaceOne (book => book.Id == id, bookIn);
        }

        public void Remove (Book bookIn) {
            _books.DeleteOne (book => book.Id == bookIn.Id);
        }

        public void Remove (string id) {
            _books.DeleteOne (book => book.Id == id);
        }

        #region   

        // IMongoDatabase– 表示用于执行操作的 Mongo 数据库。 本教程在界面上使用泛型 GetCollection<T> (collection) 方法来获取对特定集合中的数据的访问。 调用此方法后， 可以对集合执行 CRUD 操作。 在 GetCollection<T> (collection) 方法调用中：
        // collection 表示集合名称。
        // T 表示存储在集合中的 CLR 对象类型。

        // GetCollection<T> (collection) 返回 MongoCollection 对象， 该对象表示集合。 在本教程中， 对集合调用以下方法：

        // Find<T> –返回集合中与提供的搜索条件匹配的所有文档。
        // InsertOne– 插入提供的对象作为集合中的新文档。
        // ReplaceOne– 将与提供的搜索条件匹配的单个文档替换为提供的对象。
        // DeleteOne– 删除与提供的搜索条件匹配的单个文档。
        
        #endregion
    }
}