using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelos
{
    public class Cita
    {
        // Propiedades
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de cita es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de la cita")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "La hora de la cita es obligatoria")]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de la cita")]
        public TimeSpan HoraCita { get; set; }

        // Claves Foráneas
        [Required(ErrorMessage = "El usuario es requerido")]
        public string IdUsuario { get; set; }

        [Required(ErrorMessage = "La mascota es requerida")]
        public int IdMascota { get; set; }

        [Required(ErrorMessage = "La sucursal es requerida")]
        public int IdSucursal { get; set; }

        // Propiedades de navegación
        [ForeignKey("IdUsuario")]
        public Usuario usuario { get; set; }

        [ForeignKey("IdSucursal")]
        public Sucursal sucursal { get; set; }

        [ForeignKey("IdMascota")]
        public Mascota mascota { get; set; }

        [Required(ErrorMessage = "El estado de la cita es requerido")]
        [StringLength(20, ErrorMessage = "El estado no puedo exceder de los 20 caracteres")]
        public string Estado { get; set; }

    }
}
