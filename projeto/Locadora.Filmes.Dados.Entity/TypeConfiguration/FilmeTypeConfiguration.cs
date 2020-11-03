using Locadora.Filmes.Dominio;
using Locadora.Filmes.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Dados.Entity.TypeConfiguration
{
    class FilmeTypeConfiguration : LocadoraEntityAbstractConfig<Filme>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.IdAlbum)
                .IsRequired()
                .HasColumnName("Id Album");

    

        }

        protected override void ConfigurarChaveEstrangeira()
        {

        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Filme");
        }
    }
}

