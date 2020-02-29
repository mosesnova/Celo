﻿using System;
using System.Collections.Generic;

namespace CeloWebApplication.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
    }
}
