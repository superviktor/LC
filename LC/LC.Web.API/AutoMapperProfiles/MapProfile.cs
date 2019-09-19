using AutoMapper;

namespace LC.Web.API.AutoMapperProfiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Persistence.Model.Deck, Domain.Model.Deck>().ReverseMap();
            CreateMap<Persistence.Model.Card, Domain.Model.Card>().ReverseMap();
            CreateMap<ViewModels.DeckViewModel, Domain.Model.Deck>().ReverseMap();
            CreateMap<ViewModels.CardViewModel, Domain.Model.Card>().ReverseMap();
        }
    }
}
