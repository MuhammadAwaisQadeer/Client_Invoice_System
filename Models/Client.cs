using System.ComponentModel.DataAnnotations;

namespace Client_Invoice_System.Models
{
    public class Client
    {

        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public string ClientIdentifier { get; set; }

        // Navigation properties...
        public virtual ActiveClient ActiveClient { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<ClientProfileCrossTable> ClientProfileCrosses { get; set; }
    }
}