using System;
using System.Collections.Generic;
using System.Linq;
using LC.Persistence.Model;

namespace LC.Persistence.Repository
{
    public class DeckRepository : IDeckRepository
    {
        private List<Deck> _decks = new List<Deck>()
        {
            new Deck()
            {
                Cards = new List<Card>()
                {
                    new Card() {FirstSideContent = "c0s1", SecondSideContent = "c0s2"},
                    new Card() {FirstSideContent = "c1s1", SecondSideContent = "c1s2"},
                }
            }
        };
        public Deck Get(Guid id)
        {
            return _decks.First();
        }

        public void Add(Deck entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Deck entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Deck entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Deck entity)
        {
            throw new NotImplementedException();
        }
    }
}
