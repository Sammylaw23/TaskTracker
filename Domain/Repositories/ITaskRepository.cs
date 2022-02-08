using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Base;

namespace Domain.Repositories
{
    public interface ITaskRepository: IRepository<Domain.Entities.Task>
    {
        Task<IEnumerable<Entities.Task>> GetTasksByTitle(string title);
    }
}
