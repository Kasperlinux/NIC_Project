using System.ComponentModel.DataAnnotations;

namespace NIC_PROJECT.Models
{
    public class People
    {
        [Key]
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        [StringLength(10)]
        public string Contact { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
