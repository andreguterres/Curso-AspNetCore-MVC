using AspNetCore_MVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Repository
{
    //public interface IPeopleRepository
    //{
    //    string GetNameById(int id);
    //}
    public class PeopleRepository : IPeopleRepository
    {
        public PeopleRepository(string conectionString)
        {

        }
        public string GetNameById(int id)
        {
            return "Golden Shawer !";
        }
    }
}
