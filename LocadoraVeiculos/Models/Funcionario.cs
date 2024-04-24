using System;
using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O cargo do funcionário é obrigatório")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "O salário do funcionário é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário do funcionário deve ser um valor positivo")]
        public decimal Salario { get; set; }

        public DateTime DataContratacao { get; set; }

        [EmailAddress(ErrorMessage = "O email do funcionário não é válido")]
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        [Required(ErrorMessage = "O CPF do funcionário é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve conter 11 caracteres")]
        public string CPF { get; set; }
    }
}
