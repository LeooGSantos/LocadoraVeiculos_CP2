using System;
using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF do cliente é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve conter 11 caracteres")]
        public string CPF { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "O email do cliente não é válido")]
        public string Email { get; set; }
   
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O número da CNH do cliente é obrigatório")]
        public string CNH { get; set; }
    }
}
