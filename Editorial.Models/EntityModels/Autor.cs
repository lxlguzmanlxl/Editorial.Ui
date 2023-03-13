using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Models.EntityModels
{
    public class Autor
    {
        private string nombre;
        private string correo;
        private string telefono;

        public Autor()
        {

        }

        public Autor(int id, string nombre, string correo, string telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
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

        [Required]
        [MaxLength(100)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [Required]
        [MaxLength(100)]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
    }
}
