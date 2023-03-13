using Editorial.Infraestructure.Contexts;
using Editorial.Infraestructure.Implementations.Contexts;
using Editorial.Infraestructure.Implementations.Repositories;
using Editorial.Models.EntityModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Infraestructure
{
    public static class Injection
    {
        public static IServiceCollection RegisterInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<ApplicationDbContext>());


            services.AddUnitOfWork<ApplicationDbContext>()
                .AddRepository<Autor, AutorRepository>();

            services.AddUnitOfWork<ApplicationDbContext>()
                .AddRepository<Categoria, CategoriaRepository>();

            services.AddUnitOfWork<ApplicationDbContext>()
                .AddRepository<Libro, LibroRepository>();

            services.AddUnitOfWork<ApplicationDbContext>()
                .AddRepository<Carrito, CarritoRepository>();



            return services;


        }
    }
}
