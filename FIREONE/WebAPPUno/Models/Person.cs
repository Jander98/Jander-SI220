using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPPUno.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required(ErrorMessage = "El nombre requerido")]
        [Display(Name ="Nombre Completo")]
        [StringLength(100,ErrorMessage ="Maximo 100 caracteres")]
        public string Name { get; set; }
        [Display(Name ="Carnet de Identidad")]
        public string Document { get; set; }

    }
}