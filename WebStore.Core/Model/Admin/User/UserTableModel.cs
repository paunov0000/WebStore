﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Model.Admin.User
{
    public class UserTableModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!; //TODO: 1st name + last name

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public IEnumerable<string> Roles { get; set; } = null!; //TODO: when i fetch the roles if a user has no roles it has to return an empty list, right?

    }
}