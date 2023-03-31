using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models

    
    {
        public class carreras
        {
            [Key]
            [Display(Name = "Carrera ID")]
            public int? carrera_id { get; set; }

            [Display(Name = "Nombre de carrera")]
            public string? nombre_carrera { get; set; }

            [Display(Name = "facultad ID")]
            public int? facultad_id { get; set; }
        }
    }

