using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Siberian.Demo.Shared;

namespace Siberian.Demo.Server.Data.Configurations
{
    public class RestauranteConfiguration : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.ToTable("Restaurantes");

            builder.HasKey(x => x.IdRestaurante);
        }
    }
}
