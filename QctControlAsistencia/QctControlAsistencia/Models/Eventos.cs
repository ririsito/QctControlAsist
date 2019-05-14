using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QctControlAsistencia.Models
{
    public class Eventos
    {
        [Key]
        public int Eventosid { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int IdEmpleado { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public String Hora{get;set;}
        [Required]
        public DateTime Tevento { get; set; }
       

    }
}
