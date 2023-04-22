using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ZR601_2021RR604.Models
{
    public class comentarios
    {
        [Key]
        [Display(Name = "Id comentario")]
        public int cometarioId { get; set; }
        [Display(Name = "Id publicacion")]
        public int? publicacionId { get; set; }
        [Display(Name = "Comentario")]
        public String? comentario { get; set; }
        [Display(Name = "Id del usuario")]
        public int? usuarioId { get; set; }

    }
}
