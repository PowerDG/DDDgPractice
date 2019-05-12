using BaseDg.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BaseDg.App
{
    public class PersonService
    {
        private EFBaseRepository<TPerson> _personRepository;

        public PersonService(DbContext dbContext)
        {
            var context = dbContext;
            //实现Person仓储，TPerson为对应的Entity
            _personRepository = new EFBaseRepository<TPerson>(context);
        }
        public IEnumerable<TPerson> Get()
        {
            return _personRepository.Get();
        }


        public bool AddPerson(TPerson p)
        {
            try
            {
                _personRepository.Insert(p);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool EditPerson(TPerson p)
        {
            try
            {
                _personRepository.Update(p);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeletePerson(TPerson p)
        {
            try
            {
                _personRepository.Delete(p);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }

    public   class TPerson
    {
    }
}
