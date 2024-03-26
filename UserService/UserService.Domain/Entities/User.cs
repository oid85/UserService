using System.ComponentModel.DataAnnotations;

namespace UserService.Domain.Entities
{
    public class User : EntityBase
    {

        [Required]
        public string Name { get; set; } = default!;


        [Required]
        public string Domain { get; set; } = default!;


        public List<TagToUser>? TagToUsers { get; set; }
    }
}
