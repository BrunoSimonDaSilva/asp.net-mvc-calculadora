using System.ComponentModel.DataAnnotations;

namespace calculadora.Models
{
    public class CalcModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public double fist { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double second { get; set; }
        public string operation { get; set; }
        public double result { get; set; }
    }
}
