using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave
{
    public class TrophyRepository : Trophy
    {
        private int _nextId = 1;
        private readonly List<Trophy> trophies = new List<Trophy>();

        public TrophyRepository()
        {
            //trophies.Add(new Trophy() { Id = _nextId++, Competition = "OL France", Year = 2024 });
            //trophies.Add(new Trophy() { Id = _nextId++, Competition = "Champions Leageu", Year = 2022 });
            //trophies.Add(new Trophy() { Id = _nextId++, Competition = "SportCarsRace", Year = 2023 });
            //trophies.Add(new Trophy() { Id = _nextId++, Competition = "Ski racing norge", Year = 2023 });
            //trophies.Add(new Trophy() { Id = _nextId++, Competition = "Marathon Scandanavia", Year = 2024 });


        }
        public List<Trophy> Get(int? Year = null, string? sortBy = null)
        {
            if (Year == null)
            {

            }
            return new List<Trophy>(trophies);
        }
        public Trophy? GetById(int id)
        {
            if (id == 0) return null;

            return trophies.Find(trophies => trophies.Id == id);
        }
        public Trophy Add(Trophy trophy)
        {
            trophy.Validate();
            trophy.Id = _nextId++;
            trophies.Add(trophy);
            return trophy;
        }
        public Trophy? Remove(int id)
        {
            Trophy? trophy = GetById(id);
            if (trophy == null)
            {
                return null;
            }
            trophies.Remove(trophy);
            return trophy;
        }
        public Trophy? Update(int id, Trophy trophy)
        {
            trophy.Validate();
            Trophy? existingTrophy = GetById(id);
            if (existingTrophy == null)
            {
                return null;
            }
            existingTrophy.Competition = trophy.Competition;
            existingTrophy.Id = trophy.Year;
            return existingTrophy;
        }
    }

}