using System;

namespace LC.Service.Model
{
    public class DeckCardModel
    {
        public Guid DeckId { get; }
        public string CardFirstSideContent { get; }
        public string CardSecondSideContent { get; }
    }
}
