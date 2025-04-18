using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelos
{
    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es obligarotio")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        public string Pais { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Departamento { get; set; }


        //Relaciones
        public ICollection<Cita> Citas { get; set; }
        public ICollection<Mascota> Mascotas { get; set; }



    }
}
