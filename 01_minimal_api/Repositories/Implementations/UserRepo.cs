using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.DbContexts;
using _01_minimal_api.Models.Entities;
using _01_minimal_api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _01_minimal_api.Repositories.Implementations;

public class UserRepo(AuthDbContext authDbContext) : IUserRepo
{
    public async Task<List<User>> GetAllUsers()
    {
        var users = await authDbContext.Users.ToListAsync();
        return users;
    }
}
