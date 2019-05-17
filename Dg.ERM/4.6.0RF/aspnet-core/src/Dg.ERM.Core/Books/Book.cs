using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dg.ERM.Books
{
    public class Book : AggregateRoot<long>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }
    }

    public enum BookType
    {
        Green = 0,

        Yellow = 1,     // Duplicate value, OK   

        Red = 1         // Duplicate value, OK 
    }
}
