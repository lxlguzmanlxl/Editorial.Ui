using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Models.EntityModels
{
    public class Categoria
    {
        private string nombre;

        public Categoria()
        {
                
        }

        public Categoria(int id, string nombre)
        {
            this.nombre = nombre;
        }

        [Key]
        public int id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        [MaxLength(100)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
