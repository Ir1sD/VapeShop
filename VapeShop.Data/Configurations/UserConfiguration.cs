using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VapeShop.Data.Entities;

namespace VapeShop.Data.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
	{
		public void Configure(EntityTypeBuilder<UserEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.ToTable("Users");
		}
	}
}
