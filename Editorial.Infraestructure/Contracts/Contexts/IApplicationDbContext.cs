using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Editorial.Models.EntityModels;

namespace Editorial.Infraestructure.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Autor> Autores { get; set; }
        DbSet<Libro> Libros { get; set; }
        DbSet<Categoria> Categorias { get; set; }
        DbSet<Carrito> Carritos { get; set; }

    }
}
