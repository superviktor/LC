using System;
using LC.Domain.Model;
using LC.Service.Model;

namespace LC.Application.Service.Base
{
    public interface IDeckService
    {
        Deck GetDeck(Guid userId);
        void AddCard(DeckCardModel deckCardModel);
    }
}
 