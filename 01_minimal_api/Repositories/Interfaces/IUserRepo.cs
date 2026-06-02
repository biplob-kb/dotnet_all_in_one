using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.Models.Entities;

namespace _01_minimal_api.Repositories.Interfaces;

public interface IUserRepo
{
    public Task<List<User>> GetAllUsers();
}
