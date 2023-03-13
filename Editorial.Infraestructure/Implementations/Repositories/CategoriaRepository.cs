using Editorial.Infraestructure.Implementations.Contexts;
using Editorial.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Infraestructure.Implementations.Repositories
{
    internal class CategoriaRepository : Repository<Categoria>
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
