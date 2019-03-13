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
        [Required (ErrorMessage = "Id é obrigatório")]
        // Limita dados de entrada entre 20 e 30.
        [Range(20,30, ErrorMessage = "Número de 20 a 30") ]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]

        //minimo e Máximo de caracteres de entrada.
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string Sobrenome { get; set; }

        //Pode ser 1 até o limite de caracteres de números inteiros.
        [Range(1, int.MaxValue, ErrorMessage = "Minimo 1 ano e máximo infinito")]
        [Required(ErrorMessage = "Idade é obrigatório")]
        public int Idade { get; set; }


    }
}
