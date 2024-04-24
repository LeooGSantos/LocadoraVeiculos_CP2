using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A marca do veículo é obrigatória")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O modelo do veículo é obrigatório")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O ano do veículo é obrigatório")]
        [Range(1900, 2100, ErrorMessage = "O ano do veículo deve ser entre 1900 e 2100")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "A placa do veículo é obrigatória")]
        [RegularExpression(@"^[a-zA-Z]{3}-\d{4}$", ErrorMessage = "A placa do veículo deve estar no formato AAA-1234")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "A quilometragem do veículo é obrigatória")]
        [Range(0, double.MaxValue, ErrorMessage = "A quilometragem do veículo deve ser um valor positivo")]
        public double Quilometragem { get; set; }

        [Required(ErrorMessage = "A disponibilidade do veículo é obrigatória")]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "O preço de locação por dia do veículo é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O preço de locação por dia do veículo deve ser um valor positivo")]
        public decimal PrecoLocacaoDia { get; set; }

        public string Cor { get; set; }

        [Required(ErrorMessage = "O tipo de combustível do veículo é obrigatório")]
        public string Combustivel { get; set; }

        [Required(ErrorMessage = "O número de portas do veículo é obrigatório")]
        [Range(2, 5, ErrorMessage = "O número de portas do veículo deve estar entre 2 e 5")]
        public int NumeroPortas { get; set; }

        [Required(ErrorMessage = "A capacidade do porta-malas do veículo é obrigatória")]
        [Range(0, double.MaxValue, ErrorMessage = "A capacidade do porta-malas do veículo deve ser um valor positivo")]
        public double CapacidadePortaMalas { get; set; }
    }
}
