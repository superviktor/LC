using System;
using AutoMapper;
using LC.Application.Service.Base;
using LC.Domain.Model;
using LC.Persistence.Base;
using LC.Service.Model;

namespace LC.Application.Service
{
    public class DeckService : IDeckService
    {
        private readonly IRepository<Persistence.Model.Deck> _deckRepository;
        private readonly IMapper _mapper;
        public DeckService(IRepository<Persistence.Model.Deck> deckRepository,
            IMapper mapper)
        {
            _deckRepository = deckRepository;
            _mapper = mapper;

        }
        public Deck GetDeck(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void AddCard(DeckCardModel deckCardModel)
        {
            var persistenceDeck = _deckRepository.Get(deckCardModel.DeckId);

            var deck = _mapper.Map<Deck>(persistenceDeck);

            var card = Card.Create(deckCardModel.CardFirstSideContent, deckCardModel.CardSecondSideContent);

           deck.Add(card);
        }
    }
}
