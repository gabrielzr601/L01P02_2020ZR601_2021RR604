using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ZR601_2021RR604.Models
{
    public class usuarios
    {
        [Key]
        [Display(Name = "Id del usuario")]
        public int usuarioId { get; set; }
        [Display(Name = "Id del rol")]
        public int? rolId { get; set; }
        [Display(Name = "Nombre de usuario")]
        public String? nombreUsuario { get; set; }
        [Display(Name = "Clave")]
        public String? clave { get; set; }
        [Display(Name = "Nombre")]
        public String? nombre { get; set;}
        [Display(Name = "Apellido")]
        public String? apellido { get; set; }



    }
}
