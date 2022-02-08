using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
       Task<IEnumerable<Entities.User>> GetUsersByFirstName(string firstName);
    }
}
