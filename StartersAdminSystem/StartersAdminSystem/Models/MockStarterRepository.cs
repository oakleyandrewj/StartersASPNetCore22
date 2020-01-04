using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartersAdminSystem.Models
{
    public class MockStarterRepository : IStarterRepository
    {
        private List<Starter> _starters;
        public MockStarterRepository()
        {
            if (_starters == null)
            {
                InitialzeStarters();
            }
        }

        private void InitialzeStarters()
        {
            _starters = new List<Starter>
            {
                new Starter{Id = 1, Forename = "John",Surname="Smith", Ddi="1234", Department="Accounts", Initials="JS", Office="Head Office", Salary=10000, StartDate=DateTime.Now},
                new Starter{Id = 2, Forename = "Jane",Surname="Doe", Ddi="1111", Department="Accounts", Initials="JD", Office="Head Office", Salary=20000, StartDate=DateTime.Now},
                new Starter{Id = 3, Forename = "Susan",Surname="Samples", Ddi="2222", Department="HR", Initials="SS", Office="Head Office", Salary=30000, StartDate=DateTime.Now},
                new Starter{Id = 4, Forename = "Cliff",Surname="Hanger", Ddi="3333", Department="Administration", Initials="CH", Office="Northern Office", Salary=15000, StartDate=DateTime.Now}
            };
        }

        public IEnumerable<Starter> GetAllStarters()
        {
            return _starters;
        }

        public Starter GetStarterByID(int StarterID)
        {
            return _starters.FirstOrDefault(s => s.Id == StarterID);
        }
    }
}
