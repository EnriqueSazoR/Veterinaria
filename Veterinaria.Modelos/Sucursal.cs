using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelos
{
    public class Sucursal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50, ErrorMessage = "Este campo no puede exceder de los 50 caracteres")]
        [Display(Name = "Nombre de sucursal")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Horario de atención")]
        public string Horario { get; set; }

        public ICollection<Cita> Citas { get; set; }

    }
}
