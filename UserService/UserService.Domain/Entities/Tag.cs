using System.ComponentModel.DataAnnotations;

namespace UserService.Domain.Entities
{
    public class Tag : EntityBase
    {

        [Required]
        public string Value { get; set; } = default!;


        [Required]
        public string Domain { get; set; } = default!;


        public List<TagToUser>? TagToUsers { get; set; }
    }
}
