using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Models.EntityModels
{
    public class Libro
    {
        private string titulo;
        private string isbn;
        private string autor;
        private string categoria;
        private double precio;

        public Libro()
        {

        }

        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        [Required]
        [MaxLength(100)]
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        [ForeignKey("Author")]
        public int AutorId { get; set; }
        
        public Autor Autor { get; set; }
        
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
