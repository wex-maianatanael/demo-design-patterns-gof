// See https://aka.ms/new-console-template for more information

using AutoMapper;
using Demo.Builder.Builders.Contracts;
using Demo.Builder.Directors.Contracts;
using Demo.Builder.DTOs;
using Demo.ConsoleApp.Configuration;
using Demo.ConsoleApp.Mapping;
using Demo.ConsoleApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddDependencyConfig();
        services.AddAutoMapper(typeof(ObjectsMappingProfile));
    });

using var host = builder.Build();

var mapper = host.Services.GetRequiredService<IMapper>();

#region ' Creational Patterns '

#region ' Builder '

#region ' Using Builder - Checking Account '

var checkingAccountBuilderService = host.Services.GetRequiredService<ICheckingAccountBuilder>();

// base account data
checkingAccountBuilderService.SetAccountNumber(123);
checkingAccountBuilderService.SetAccountBalance(100);
checkingAccountBuilderService.SetIsActive(true);
checkingAccountBuilderService.SetOpenDate(DateTimeOffset.UtcNow);

// checking account data
checkingAccountBuilderService.SetOverdraftLimit(100);
checkingAccountBuilderService.SetMonthlyFreeTransactions(10);
checkingAccountBuilderService.SetMonthlyFee(2);
checkingAccountBuilderService.SetTransactionFee(1);

var checkingAccount1 = checkingAccountBuilderService.GetAccount();

Console.WriteLine(checkingAccount1.ToString());

checkingAccountBuilderService.Reset();

#endregion ' Using Builder - Checking Account '

#region ' Using Director - Checking Account '

var directorCheckingAccountBuilderService = host.Services.GetRequiredService<IAccountDirector<CheckingAccountDto>>();

var checkingAccountViewmModel = new CheckingAccountViewModel()
{
    Balance = 1200,
    IsActive = true,
    MonthlyFee = 3,
    MonthlyFreeTransactions = 15,
    Number = 333,
    OpenedDate = DateTimeOffset.UtcNow,
    OverdraftLimit = 400,
    TransactionFee = 2
};

var checkingAccountDto = mapper.Map<CheckingAccountDto>(checkingAccountViewmModel);

var checkingAccount2 = directorCheckingAccountBuilderService.BuildCheckingAccount(checkingAccountDto);

Console.WriteLine(checkingAccount2.ToString());

#endregion ' Using Director - Checking Account '

#region ' Using Builder - Investment Account '

var investmentAccountBuilderService = host.Services.GetRequiredService<IInvestmentAccountBuilder>();

// base account data
investmentAccountBuilderService.SetAccountNumber(123);
investmentAccountBuilderService.SetAccountBalance(100);
investmentAccountBuilderService.SetIsActive(true);
investmentAccountBuilderService.SetOpenDate(DateTimeOffset.UtcNow);

// investment account data
investmentAccountBuilderService.SetStrategy(Demo.Entities.Enums.InvestmentStrategyType.Moderate);
investmentAccountBuilderService.SetToleranceRisk(Demo.Entities.Enums.ToleranceRiskType.Low);
investmentAccountBuilderService.SetDividends(1000);
investmentAccountBuilderService.SetManagementFee(10);
investmentAccountBuilderService.SetInvestmentReturn(28);
investmentAccountBuilderService.SetCapitalGains(10000);

var investmentAccount1 = investmentAccountBuilderService.GetAccount();

Console.WriteLine(investmentAccount1.ToString());

investmentAccountBuilderService.Reset();

#endregion ' Using Builder - Investment Account '

#region ' Using Director - Investment Account '

var directorInvestmentAccountBuilderService = host.Services.GetRequiredService<IAccountDirector<InvestmentAccountDto>>();

var investmentAccountViewModel = new InvestmentAccountViewModel()
{
    Number = 333,
    Balance = 1200,
    OpenedDate = DateTimeOffset.UtcNow,
    IsActive = true,
    Strategy = Demo.Entities.Enums.InvestmentStrategyType.Moderate,
    ToleranceRisk = Demo.Entities.Enums.ToleranceRiskType.Low,
    Dividends = 1000,
    ManagementFee = 10,
    InvestmentReturn = 28,
    CapitalGains = 1000
};

var investmentAccountDto = mapper.Map<InvestmentAccountDto>(investmentAccountViewModel);

var investmentAccount2 = directorInvestmentAccountBuilderService.BuildInvestmentAccount(investmentAccountDto);

Console.WriteLine(investmentAccount2.ToString());

#endregion ' Using Director - Investment Account '

#endregion ' Builder '

#endregion ' Creational Patterns '

Console.ReadKey();