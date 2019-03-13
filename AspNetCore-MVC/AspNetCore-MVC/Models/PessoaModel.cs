using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Models
{
    public class PessoaModel
    {
        // Notations não é recomendado para o Domínio da aplicação. Usar em DTO.


        //Obriga campo
        [Required]
        // Limita dados de entrada entre 20 e 30.
        [Range(20,30)]
        public int Id { get; set; }

        [Required]

        //minimo e Máximo de caracteres de entrada.
        [MinLength(3)]
        [MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Sobrenome { get; set; }

        //Pode ser 1 até o limite de caracteres de números inteiros.
        [Range(1, int.MaxValue)]
        [Required]
        public int Idade { get; set; }


    }
}
