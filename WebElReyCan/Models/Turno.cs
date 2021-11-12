using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        //[RegularExpression(@"^(?:3[01]|[12][0-9]|0?[1-9])([\-/.])(0?[1-9]|1[1-2])\1\d{4}$", ErrorMessage = "Ingrese un formato de fecha válido. Ejemplo: 15-05-2015")]
        public DateTime DateTime { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Is Required")]
        public string NombreMascota { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Is Required")]
        public string NombreDuenio { get; set; }

        [Column(TypeName = "Varchar")]
        public string Raza { get; set; }

        public int EdadMascota { get; set; }

        [Required(ErrorMessage = "Is Required")]
        public int Celular { get; set; }
    }
}