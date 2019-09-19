using System;
using LC.Domain.Model.Base;

namespace LC.Domain.Model
{
    public class Card : IAggregateRoot
    {
        public Guid Id { get; private set; }
        
        public string FirstSideContent { get; private set; }

        public string SecondSideContent { get; private set; }

        public static Card Create(string firstSideContent, string secondSideContent)
        {
            var card = new Card()
            {
                Id = Guid.NewGuid(),
                FirstSideContent = firstSideContent,
                SecondSideContent = secondSideContent
            };

            return card;
        }
    }
}
