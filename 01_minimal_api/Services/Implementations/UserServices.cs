using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.Models.Entities;
using _01_minimal_api.Repositories.Interfaces;
using _01_minimal_api.Services.Interfaces;

namespace _01_minimal_api.Services.Implementations;

public class UserServices(IUserRepo userRepo) : IUserServices
{
    public async Task<List<User>> GetAllUsers()
    {
        return await userRepo.GetAllUsers();
    }
}
