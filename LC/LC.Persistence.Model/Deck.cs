using System;
using System.Collections.Generic;

namespace LC.Persistence.Model
{
    public class Deck
    {
        public Guid Id { get; set; }

        public  string Name { get; set; }

        public  List<Card> Cards { get; set; }
    }
}
