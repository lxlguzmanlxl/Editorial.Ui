using Editorial.Infraestructure.Implementations.Contexts;
using Editorial.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Infraestructure.Implementations.Repositories
{
    internal class CarritoRepository : Repository<Carrito>
    {
        public CarritoRepository(ApplicationDbContext context) : base(context)
        {
        }
    
    }
}
