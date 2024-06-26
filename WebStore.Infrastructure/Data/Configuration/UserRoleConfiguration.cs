﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(CreateUserRoles());
        }

        private List<IdentityUserRole<Guid>> CreateUserRoles()
        {
            var userRoles = new List<IdentityUserRole<Guid>>();

            var userRole = new IdentityUserRole<Guid>
            {
                UserId = Guid.Parse("753EFDE4-EFA1-4F88-ABC9-8F091CF8B670"),
                RoleId = Guid.Parse("8027C9ED-85CE-4837-BF14-3ED6152E35AD"),
            };

            userRoles.Add(userRole);

            userRole = new IdentityUserRole<Guid>
            {
                UserId = Guid.Parse("70852FF3-F2FC-4998-342B-08DC4DA7E32C"),
                RoleId = Guid.Parse("85805833-8F47-4355-BD15-9465A8A65C07"),
            };

            userRoles.Add(userRole);

            //userRole = new IdentityUserRole<Guid>
            //{
            //    UserId = Guid.Parse("A387DAFA-DEBD-44A2-28B5-08DC50E4EB14"),
            //    RoleId = Guid.Parse("85805833-8F47-4355-BD15-9465A8A65C07"),
            //};

            //userRoles.Add(userRole);

            userRole = new IdentityUserRole<Guid>
            {
                UserId = Guid.Parse("C0A0D5A0-4B6A-4B6A-8F4A-0C8F0B6F0B6C"),
                RoleId = Guid.Parse("44E92506-A5BD-494A-B749-7D90BDFE9628"),
            };

            userRoles.Add(userRole);

            return userRoles;
        }
    }
}
