using AutoMapper;

namespace LC.Application.Service.AutoMapperProfiles
{
    public class PersistenceDomainProfile: Profile
    {
        public PersistenceDomainProfile()
        {
            CreateMap<Persistence.Model.Deck, Domain.Model.Deck>().ReverseMap();
        }
    }
}
