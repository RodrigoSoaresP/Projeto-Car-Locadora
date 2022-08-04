﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarLocadora.Modelo
{
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "Placa é obrigatorio.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "caracteres mínimos 8")]
        public string Placa { get; set; } = string.Empty;


        [StringLength(100, MinimumLength = 5, ErrorMessage = "caracteres mínimo 100")]
        public string Chassi { get; set; } = string.Empty;


        [Required(ErrorMessage = "Marca é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "caracteres mínimo 5 máximo de 100")]
        public string Marca { get; set; } = string.Empty;

        
        [Required(ErrorMessage = "Modelo é obrigatorio.")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "caracteres mínimo 5 máximo de 150")]
        public DateTime Modelo { get; set; }


        [Required(ErrorMessage = "Combustível é obrigatorio.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "caracteres mínimo 10 máximo de 150")]
        public string? Combustivel { get; set; }


        [Required(ErrorMessage = "Cor é obrigatorio.")]
        [StringLength(4, MinimumLength = 15, ErrorMessage = "caracteres mínimo 4 máximo de 100")]
        public string Cor { get; set; } = string.Empty;

        [StringLength(20000, MinimumLength = 1, ErrorMessage = "caracteres mínimo 1 máximo de 2000")]
        public string Opcionais { get; set; }


        [Required(ErrorMessage = "Ativo é obrigatório.")]
        public bool Ativo { get; set; } = true;


        [Required(ErrorMessage = "Data de Inclusão é obrigatoria.")]
        public DateTime DataInclusao { get; set; }


        [Display(Name = "Data de Alteração")]
        public DateTime? DataAlteracao { get; set; }



    }
}