using System.ComponentModel.DataAnnotations;

namespace UserService.Domain.Entities
{
    public class TagToUser : EntityBase
    {
        [Required]
        public Guid UserId { get; set; }


        public User? User { get; set; }

        [Required]
        public Guid TagId { get; set; }


        public Tag? Tag { get; set; }
    }
}
