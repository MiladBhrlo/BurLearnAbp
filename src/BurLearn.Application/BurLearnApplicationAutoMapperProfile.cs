using AutoMapper;
using BurLearn.Books;

namespace BurLearn;

public class BurLearnApplicationAutoMapperProfile : Profile
{
    public BurLearnApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
