using System.ComponentModel.DataAnnotations;

namespace ODBlazor.Models
{
    public class DoBModel
    {

        [Required(ErrorMessage = "Date of Birth Required")]
        public DateOnly BirthDate { get; set; }


    }
}