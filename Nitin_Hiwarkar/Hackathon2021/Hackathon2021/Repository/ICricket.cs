using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon2021.Model;

namespace Hackathon2021.Repository
{
    public interface ICricket
    {
        IEnumerable<Data> GetMatchData();
        Data GetMatchByID(int MatchID);
        void InsertMatch(Data CricketData);
        void DeleteMatch(int MatchID);
        void UpdateMatch(Data CricketData);
        void Save();
    }
}

