namespace WebApiUno.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required(ErrorMessage = "El nombre requerido")]
        [Display(Name = "Nombre Completo")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Name { get; set; }
        [Display(Name = "Carnet de Identidad")]
        public string Document { get; set; }

    }
}