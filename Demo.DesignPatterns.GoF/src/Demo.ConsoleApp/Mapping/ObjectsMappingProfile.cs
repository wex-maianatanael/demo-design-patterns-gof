using AutoMapper;
using Demo.Builder.DTOs;
using Demo.ConsoleApp.ViewModels;
using Demo.Entities;

namespace Demo.ConsoleApp.Mapping
{
    public class ObjectsMappingProfile : Profile
    {
        public ObjectsMappingProfile()
        {
            CreateMap<CheckingAccountViewModel, CheckingAccountDto>().ReverseMap();
            CreateMap<CheckingAccountDto, CheckingAccount>().ReverseMap();

            CreateMap<InvestmentAccountViewModel, InvestmentAccountDto>().ReverseMap();
            CreateMap<InvestmentAccountDto, InvestmentAccount>().ReverseMap();

            CreateMap<SavingsAccountViewModel, SavingsAccountDto>().ReverseMap();
            CreateMap<SavingsAccountDto, SavingsAccount>().ReverseMap();

            CreateMap<StudentAccountViewModel, StudentAccountDto>().ReverseMap();
            CreateMap<StudentAccountDto, StudentAccount>().ReverseMap();
        }
    }
}