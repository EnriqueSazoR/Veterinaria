using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelos
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "Este campo no puede exceder de los 30 caracteres")]
        [Display(Name = "Nombre de tu mascota")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Raza { get; set; }

        [Required(ErrorMessage = "Este campo es obligarorio")]
        public string Condicion { get; set; }

        // Clave Foránea
        [Required(ErrorMessage = "El usuario es requerido")]
        public string IdUsuario { get; set; }

       // Propiedades de navegación
        [ForeignKey("IdUsuario")]
        public Usuario usuario { get; set; }

        public ICollection<Cita> Citas { get; set; }

    }
}
