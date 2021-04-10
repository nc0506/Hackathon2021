using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon2021.DBContext;
using Hackathon2021.Model;
using Microsoft.EntityFrameworkCore;

namespace Hackathon2021.Repository
{
    public class Cricket : ICricket
    {
        private readonly CricketContext _dbContext;

        public Cricket(CricketContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteMatch(int MatchID)
        {
            var data = _dbContext.Data.Find(MatchID);
            _dbContext.Data.Remove(data);
            Save();
        }

        public Data GetMatchByID(int MatchID)
        {
            return _dbContext.Data.Find(MatchID);
        }

        public IEnumerable<Data> GetMatchData()
        {
            return _dbContext.Data.ToList();
        }

        public void InsertMatch(Data CricketData)
        {
            _dbContext.Add(CricketData);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void  UpdateMatch(Data CricketData)
        {
            _dbContext.Entry(CricketData).State = EntityState.Modified;
            Save();
        }
    }
}
