using System.ComponentModel.DataAnnotations;


namespace L01P02_2020ZR601_2021RR604.Models
{
    public class publicaciones
    {
        [Key]
        [Display(Name = "Id publicacion")]
        public int publicacionId { get; set; }
        [Display(Name = "Titulo")]
        public String titulo { get; set; }
        [Display(Name = "Descripcion")]
        public String descripcion { get; set; }
        [Display(Name = "Id del usuario")]
        public int? usuarioId { get; set; }

    }
}
