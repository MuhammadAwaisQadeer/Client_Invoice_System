﻿using System.ComponentModel.DataAnnotations;

namespace Client_Invoice_System.Models
{
    public class OwnerProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OwnerName { get; set; }

        [Required, EmailAddress]
        public string BillingEmail { get; set; }

        public string PhoneNumber { get; set; }
        public string BillingAddress { get; set; }

        [Required]
        public string IBANNumber { get; set; }

        public string Currency { get; set; }

        public string AccountTitle { get; set; }

        public string AccountNumber { get; set; }
    }


}
