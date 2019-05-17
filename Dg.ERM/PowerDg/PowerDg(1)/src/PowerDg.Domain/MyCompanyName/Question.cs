using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace MyCompanyName
{
    public class Question : Entity
    {
        public string Name { get; set; }

        public override object[] GetKeys()
        {
            throw null;
        }
    }
}
