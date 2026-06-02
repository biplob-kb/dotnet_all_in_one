using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.Models.Entities;

namespace _01_minimal_api.Services.Interfaces;

public interface IUserServices
{
   public Task<List<User>> GetAllUsers();
}
