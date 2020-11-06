using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "ID obrigatório")]
        public long IdFilme { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [Display(Name = "Nome do filme")]
        public string NomeFilme { get; set; }

        [Required(ErrorMessage = "Selecione um álbum")]
        [Display(Name = "Nome do Álbum")]
        public int IdAlbum { get; set; }

    }
}