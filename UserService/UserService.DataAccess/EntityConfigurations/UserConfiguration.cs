using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entities;

namespace UserService.DataAccess.EntityConfigurations
{
    internal class UserConfiguration : EntityConfigurationBase<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new User
                {
                    Id = Guid.Parse("d8d51a5e-1350-4bb0-b96b-190406924a68"),
                    Domain = "example1.com",
                    Name = "user1"
                },

                new User
                {
                    Id = Guid.Parse("05e7fa98-07d7-43dd-adc8-80e8ad6268c5"),
                    Domain = "example1.com",
                    Name = "user11"
                },

                new User
                {
                    Id = Guid.Parse("50ef2384-c08a-4631-bd21-b2d70b2ae3c3"),
                    Domain = "example1.com",
                    Name = "user12"
                },

                new User
                {
                    Id = Guid.Parse("c635ff1a-11f3-40d5-99f7-7f53886e5d82"),
                    Domain = "example2.com",
                    Name = "user2"
                },

                new User
                {
                    Id = Guid.Parse("76d9b3bb-5251-42fa-aa82-d325e7283f17"),
                    Domain = "example3.com",
                    Name = "user3"
                }
            );
        }
    }
}