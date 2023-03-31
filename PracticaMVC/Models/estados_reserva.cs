using System.ComponentModel.DataAnnotations;


namespace PracticaMVC.Models
{
    public class estados_reserva
    {
        [Key]
        [Display(Name = "Estado Reserva ID")]
        public int? estado_res_id { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}