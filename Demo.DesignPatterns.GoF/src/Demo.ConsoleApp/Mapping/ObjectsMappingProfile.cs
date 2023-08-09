using AutoMapper;
using Demo.ConsoleApp.ViewModels;
using Demo.Entities;

namespace Demo.ConsoleApp.Mapping
{
    public class ObjectsMappingProfile : Profile
    {
        public ObjectsMappingProfile()
        {
            CreateMap<CheckingAccountViewModel, CheckingAccount>();
        }
    }
}
