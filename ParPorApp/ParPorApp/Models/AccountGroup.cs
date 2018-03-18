using System;
using System.Collections.Generic;
using System.Text;

namespace ParPorApp.Models
{
    public class AccountGroup
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
    }

    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<AccountGroup> AccountGroups { get; set; }
        public ICollection<AccountStudent> AccountStudents { get; set; }
        public ICollection<AccountEvent> AccountEvents { get; set; }
    }
}
