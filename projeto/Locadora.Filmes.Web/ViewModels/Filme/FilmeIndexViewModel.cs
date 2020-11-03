using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Locadora.Filmes.Web.ViewModels.Album;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeIndexViewModel
    {
        public long Id { get; set; }
        [Display(Name = "Nome do Filme")]
        public string Nome { get; set; }
        [Display(Name = "Nome do Album")]
        public virtual AlbumViewModel abum { get; set; }
        [Display(Name = "Id Album")]
        public int IdAlbum { get; set; }
    }
}