using AutoMapper;
using Locadora.Filmes.Dominio;
using Locadora.Filmes.Web.ViewModels.Album;
using Locadora.Filmes.Web.ViewModels.Filme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Locadora.Filmes.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            //Mapeamento da Album para Album viewmodel
            Mapper.CreateMap<Album, AlbumIndexViewModel>().ForMember(p => p.Nome, opt =>
            {
                opt.MapFrom(src =>
                string.Format("{0} {1}", src.Nome, src.Ano.ToString())
                    );
            });
            Mapper.CreateMap<Album, AlbumViewModel>();


            //Mapeamento da filme para filme viewmodel
            Mapper.CreateMap<Filme, FilmeIndexViewModel>().ForMember(p => p.NomeAlbum, opt =>
            {
                opt.MapFrom(src => src.Album.Nome);
            });
            Mapper.CreateMap<Filme, FilmeViewModel>();
        }
    }
}