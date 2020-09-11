﻿using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Infrastructure
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        Task<ApplicationUser> GetById(string id);
        Task Insert(ApplicationUser applicationUser);
        Task Edit(ApplicationUser applicationUser);
        Task Delete(ApplicationUser applicationUser);
        Task AffectRoles(ApplicationUser applicationUser, List<string> roles);
        Task<List<String>> GetRolesByUser(ApplicationUser applicationUser);
        void Save();
    }
}