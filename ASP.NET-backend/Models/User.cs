using System;
using System.Collections.Generic;

namespace ASP.NET_backend.Models
{
    public partial class User
    {
        public int Id { get; }
        public string Password { get; }
        public DateTime? LastLogin { get; }
        public bool IsSuperuser { get; }
        public string Username { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public bool IsStaff { get; }
        public bool IsActive { get; }
        public DateTime DateJoined { get; }
    }
}
