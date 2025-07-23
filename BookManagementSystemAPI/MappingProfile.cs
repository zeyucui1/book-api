using AutoMapper;
using BookManagementSystemAPI.Dto;
using BookManagementSystemAPI.Models;

namespace BookManagementSystemAPI
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<BookCreateRequest, Book>();
        }
    }
}
