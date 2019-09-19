using System;
using System.Collections.Generic;

namespace LC.Web.API.ViewModels
{
    public class DeckViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<CardViewModel> Cards { get; set; }
    }
}
