﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarLocadora.Modelo
{
    public class FormaPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "ID é obrigatorio.")]
        public int ID { get; set; }


        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatorio.")]
        [StringLength(1, MinimumLength = 150, ErrorMessage = "caracteres mínimo 1 máximo de 150")]
        public string Descrição { get; set; } = string.Empty;


        [Required(ErrorMessage = "Ativo é obrigatório.")]
        public bool Ativo { get; set; } = true;

        [Display(Name = "Data de Inclusão")]
        [Required(ErrorMessage = "Data de Inclusão é obrigatoria.")]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Data de Alteração")]
        public DateTime? DataAlteracao { get; set; }




    
    }
}