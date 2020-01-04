using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartersAdminSystem.Models
{
    public interface IStarterRepository
    {
        IEnumerable<Starter> GetAllStarters();
        Starter GetStarterByID(int StarterID);
    }
}
