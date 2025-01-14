﻿using System.ComponentModel.DataAnnotations;

namespace LibApp.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public int MembershipTypeId { get; set; }
        public bool HasNewsletterSubscribed { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}
