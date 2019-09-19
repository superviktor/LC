using System;
using AutoMapper;
using LC.Application.Service.Base;
using LC.Domain.Model;
using LC.Persistence.Repository;
using LC.Service.Model;

namespace LC.Application.Service
{
    public class DeckService : IDeckService
    {
        private readonly IDeckRepository _deckRepository;
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;
        public DeckService(IDeckRepository deckRepository,
            ICardRepository cardRepository,
            IMapper mapper)
        {
            _deckRepository = deckRepository;
            _cardRepository = cardRepository;
            _mapper = mapper;

        }
        public Deck GetDeck(Guid id)
        {
            var persistenceDeck = _deckRepository.Get(id);
            var deck = _mapper.Map<Deck>(persistenceDeck);
            return deck;
        }

        public void AddCard(DeckCardModel deckCardModel)
        {
            var persistenceDeck = _deckRepository.Get(deckCardModel.DeckId);

            var deck = _mapper.Map<Deck>(persistenceDeck);

            var card = Card.Create(deckCardModel.CardFirstSideContent, deckCardModel.CardSecondSideContent);

            var persistenceCard = _mapper.Map<Persistence.Model.Card>(_mapper.Map<Deck>(persistenceDeck));

            _cardRepository.Save(persistenceCard);

           deck.Add(card);
        }
    }
}
