using Demo.Builder.Builders;
using Demo.Builder.Builders.Contracts;
using Demo.Builder.Directors;
using Demo.Builder.Directors.Contracts;
using Demo.Builder.DTOs;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.ConsoleApp.Configuration
{
    public static class DependencyInjectionResolver
    {
        public static IServiceCollection AddDependencyConfig(this IServiceCollection services)
        {
            services.AddTransient<ICheckingAccountBuilder, CheckingAccountBuilder>();
            services.AddTransient<IInvestmentAccountBuilder, InvestmentAccountBuilder>();
            services.AddTransient<ISavingsAccountBuilder, SavingsAccountBuilder>(); // todo: not tested
            services.AddTransient<IStudentAccountBuilder, StudentAccountBuilder>(); // todo: not tested

            services.AddTransient<IAccountDirector<CheckingAccountDto>, AccountDirector<CheckingAccountDto>>();
            services.AddTransient<IAccountDirector<InvestmentAccountDto>, AccountDirector<InvestmentAccountDto>>();
            services.AddTransient<IAccountDirector<SavingsAccountDto>, AccountDirector<SavingsAccountDto>>();
            services.AddTransient<IAccountDirector<StudentAccountDto>, AccountDirector<StudentAccountDto>>();

            return services;
        }
    }
}