using System;
using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class Locacao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A data de início da locação é obrigatória")]
        [DataType(DataType.DateTime)]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "A data de término da locação é obrigatória")]
        [DataType(DataType.DateTime)]
        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "O valor total da locação é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor total da locação deve ser um valor positivo")]
        public decimal ValorTotal { get; set; }

        [Required(ErrorMessage = "O status da locação é obrigatório")]
        public string Status { get; set; }

        [Required(ErrorMessage = "O cliente é obrigatório")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "O veículo é obrigatório")]
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
