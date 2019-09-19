using System;

namespace LC.Web.API.ViewModels
{
    public class CardViewModel
    {
        public Guid Id { get; set; }
        public string FirstSideContent { get; set; }
        public string SecondSideContent { get; set; }
    }
}
