using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDg.Core.Books
{
    public class Book : AggregateRoot<Guid>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }
    }
}
