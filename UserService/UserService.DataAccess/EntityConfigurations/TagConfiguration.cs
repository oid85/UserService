using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entities;

namespace UserService.DataAccess.EntityConfigurations
{
    internal class TagConfiguration : EntityConfigurationBase<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new Tag
                {
                    Id = Guid.Parse("091c5601-8648-4f43-8a46-cb1662023058"),
                    Domain = "example1.com",
                    Value = "value1"
                },

                new Tag
                {
                    Id = Guid.Parse("443cd29d-86c8-4dc0-821a-3b2f262f18aa"),
                    Domain = "example2.com",
                    Value = "value2"
                },

                new Tag
                {
                    Id = Guid.Parse("28163433-c281-4e02-8330-6163aa6795dc"),
                    Domain = "example3.com",
                    Value = "value3"
                }
            );
        }
    }
}