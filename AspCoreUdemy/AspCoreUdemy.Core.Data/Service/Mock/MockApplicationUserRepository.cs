﻿using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Service
{
    public class MockApplicationUserRepository : IApplicationUserRepository
    {
        public Task Delete(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetById(string id)
        {
            throw new NotImplementedException();
        }

        Task<List<string>> IApplicationUserRepository.GetRolesByUser(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public Task Edit(ApplicationUser applicationUser, List<string> roles)
        {
            throw new NotImplementedException();
        }

        public Task Create(ApplicationUser applicationUser, List<string> roles, string password)
        {
            throw new NotImplementedException();
        }
    }
}
