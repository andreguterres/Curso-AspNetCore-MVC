using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Interfaces
{
    public interface IPeopleRepository
    {
        string GetNameById(int id);
    }
}
