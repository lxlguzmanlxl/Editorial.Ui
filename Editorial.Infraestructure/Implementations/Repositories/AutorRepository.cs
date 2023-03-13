using Editorial.Infraestructure.Implementations.Contexts;
using Editorial.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Infraestructure.Implementations.Repositories
{
    internal class AutorRepository : Repository<Autor>
    {
        public AutorRepository(ApplicationDbContext context) : base(context)
        {



        }
    }
}
