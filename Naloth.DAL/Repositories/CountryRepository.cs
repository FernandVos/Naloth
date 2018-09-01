using Naloth.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloth.DAL.Repositories
{
    public class CountryRepository
    {

        public Country GetCountry(string name)
        {
            using(var context = new NalothDbContext())
            {
                return context.Countries.FirstOrDefault(c => c.Name == name);
            }
        }
    }
}
