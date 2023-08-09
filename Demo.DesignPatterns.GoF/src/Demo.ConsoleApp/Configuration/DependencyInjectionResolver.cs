using Demo.Builder.Builders.Contracts;
using Demo.Builder.Builders;
using Demo.Builder.Directors.Contracts;
using Demo.Builder.Directors;
using Demo.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.ConsoleApp.Configuration
{
    public static class DependencyInjectionResolver
    {
        public static IServiceCollection AddDependencyConfig(this IServiceCollection services)
        {
            services.AddTransient<ICheckingAccountBuilder, CheckingAccountBuilder>();
            services.AddTransient<IInvestmentAccountBuilder, InvestmentAccountBuilder>(); // todo: not tested
            services.AddTransient<ISavingsAccountBuilder, SavingsAccountBuilder>(); // todo: not tested
            services.AddTransient<IStudentAccountBuilder, StudentAccountBuilder>(); // todo: not tested

            services.AddTransient<IAccountDirector<CheckingAccount>, AccountDirector<CheckingAccount>>(); // working
            services.AddTransient<IAccountDirector<InvestmentAccount>, AccountDirector<InvestmentAccount>>(); // todo: not implemented
            services.AddTransient<IAccountDirector<SavingsAccount>, AccountDirector<SavingsAccount>>(); // todo: not implemented
            services.AddTransient<IAccountDirector<StudentAccount>, AccountDirector<StudentAccount>>(); // todo: not implemented

            return services;
        }
    }
}
