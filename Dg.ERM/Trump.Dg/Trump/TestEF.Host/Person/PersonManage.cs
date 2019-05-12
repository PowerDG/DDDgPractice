using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEF.Host.Person
{
    public class PersonManage
    {
        public IList<PersonVM> GetPersons()
        {
            using (var context = new RepositoryDemoEntities())
            {
                var list = new PersonService(context).Get();
                var result = new List<PersonVM>();
                foreach (var item in list)
                {
                    result.Add(new PersonVM { Name = item.Name, Age = item.Age, Home = item.Home, PersonID = item.Id });
                }
                return result;
            }
        }

        public bool AddPerson(PersonVM p)
        {
            using (var context = new RepositoryDemoEntities())
            {
                var result = new PersonService(context).AddPerson(new EntityFramework.TPerson { Name = p.Name, Home = p.Home, Age = p.Age, Id = p.PersonID });
                context.SaveChanges();
                return result;
            }
        }

        public bool DeletePerson(PersonVM p)
        {
            using (var context = new RepositoryDemoEntities())
            {
                var result = new PersonService(context).DeletePerson(new EntityFramework.TPerson { Name = p.Name, Home = p.Home, Age = p.Age, Id = p.PersonID });
                context.SaveChanges();
                return result;
            }
        }

        public bool EditPerson(PersonVM p)
        {
            using (var context = new RepositoryDemoEntities())
            {
                var result = new PersonService(context).EditPerson(new EntityFramework.TPerson { Name = p.Name, Home = p.Home, Age = p.Age, Id = p.PersonID });
                context.SaveChanges();
                return result;
            }
        }
    }
}
