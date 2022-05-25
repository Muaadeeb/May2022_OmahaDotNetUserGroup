namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDTO, Book>().ReverseMap();
        }
    }
}