using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class CategoriaVeiculo
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "A tarifa diária deve ser um valor positivo")]
        public decimal TarifaDiaria { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "A capacidade de passageiros deve ser no mínimo 1")]
        public int CapacidadePassageiros { get; set; }

        [Required]
        public string TipoCombustivel { get; set; }

        [Required]
        public string Transmissao { get; set; }

        [Required]
        public bool SeguroObrigatorioIncluso { get; set; }
    }
}
