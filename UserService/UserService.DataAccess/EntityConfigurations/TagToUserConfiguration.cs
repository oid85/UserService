using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entities;

namespace UserService.DataAccess.EntityConfigurations
{
    internal class TagToUserConfiguration : EntityConfigurationBase<TagToUser>
    {
        public override void Configure(EntityTypeBuilder<TagToUser> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new TagToUser
                {
                    Id = Guid.Parse("819b2781-9d76-48d7-bcb9-085da8c44205"),
                    UserId = Guid.Parse("d8d51a5e-1350-4bb0-b96b-190406924a68"),
                    TagId = Guid.Parse("091c5601-8648-4f43-8a46-cb1662023058"),
                },

                new TagToUser
                {
                    Id = Guid.Parse("2c7e7c4a-84df-4fb9-a0be-8f0c24d3add4"),
                    UserId = Guid.Parse("05e7fa98-07d7-43dd-adc8-80e8ad6268c5"),
                    TagId = Guid.Parse("091c5601-8648-4f43-8a46-cb1662023058"),
                },

                new TagToUser
                {
                    Id = Guid.Parse("78ad0162-3502-4900-b945-1764ad2da5c8"),
                    UserId = Guid.Parse("50ef2384-c08a-4631-bd21-b2d70b2ae3c3"),
                    TagId = Guid.Parse("091c5601-8648-4f43-8a46-cb1662023058"),
                },

                 new TagToUser
                 {
                     Id = Guid.Parse("506ae79f-0690-447c-925b-66517d206309"),
                     UserId = Guid.Parse("c635ff1a-11f3-40d5-99f7-7f53886e5d82"),
                     TagId = Guid.Parse("443cd29d-86c8-4dc0-821a-3b2f262f18aa"),
                 },

                  new TagToUser
                  {
                      Id = Guid.Parse("4472f9de-d200-4c9f-95a1-ae11f4b66cc1"),
                      UserId = Guid.Parse("76d9b3bb-5251-42fa-aa82-d325e7283f17"),
                      TagId = Guid.Parse("28163433-c281-4e02-8330-6163aa6795dc")
                  }
            );
        }
    }
}