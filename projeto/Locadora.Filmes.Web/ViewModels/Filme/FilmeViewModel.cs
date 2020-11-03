using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {

        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do Filme é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no maximo 100 caracteres")]
        [Display(Name = "Nome do Filme")]
        public string Nome { get; set; }

  

    



    }
}