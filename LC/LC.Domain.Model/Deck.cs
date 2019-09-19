using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LC.Domain.Model.Base;

namespace LC.Domain.Model
{
    public class Deck : IAggregateRoot
    {
        public Guid Id { get; private set; }

        private readonly List<Card> _cards = new List<Card>();

        public ReadOnlyCollection<Card> Cards => _cards.AsReadOnly();

        public Guid UserId { get; private set; }

        public static Deck Create(Guid userId)
        {
            var deck = new Deck {Id = Guid.NewGuid(), UserId = userId};
            return deck;
        }

        public void Add(Card card)
        {
            if (card == null)
                throw new ArgumentNullException();

            this._cards.Add(card);
        }

        public void Remove(Card card)
        {
            if (card == null)
                throw new ArgumentNullException();

            var cardFound = this._cards.FirstOrDefault(c => c.Id == card.Id);

            if (cardFound == null)
                throw new ArgumentNullException();

            this._cards.Remove(card);
        }

        public void Clear()
        {
            this._cards.Clear();
        }
    }
}
