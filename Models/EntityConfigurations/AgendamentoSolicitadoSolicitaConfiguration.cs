using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication04.Models.Entities;

namespace WebApplication04.Models.EntityConfigurations
{
    public class AgendamentoSolicitadoSolicitaConfiguration : IEntityTypeConfiguration<AgendamentoSolicitadoSolicita>
    {
        public void Configure(EntityTypeBuilder<AgendamentoSolicitadoSolicita> builder)
        {
            builder.ToTable("AgendamentoSolicitadoSolicita");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.DataHoraDeRetirada)
                    .IsRequired();

            builder.Property(a => a.DataHoraEntrega)
                    .IsRequired();

            builder.HasOne(a => a.Utensilio)
                    .WithMany(u => u.AgendamentoSolicitadoSolicitas)
                    .HasForeignKey(u => u.FkIdUtensilio);

            builder.HasOne(a => a.Usuario)
                    .WithMany(u => u.AgendamentoSolicitadoSolicitas)
                    .HasForeignKey(u => u.FkIdUsuario);
                    
        }
    }
}