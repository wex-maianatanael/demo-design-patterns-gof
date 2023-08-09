// See https://aka.ms/new-console-template for more information

using AutoMapper;
using Demo.Builder.Builders.Contracts;
using Demo.Builder.Directors.Contracts;
using Demo.ConsoleApp.Configuration;
using Demo.ConsoleApp.Mapping;
using Demo.ConsoleApp.ViewModels;
using Demo.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddDependencyConfig();
        services.AddAutoMapper(typeof(ObjectsMappingProfile));
    });

using var host = builder.Build();

#region ' Using Builder '

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

#endregion

#region ' Using Director '

var directorAccountBuilderService = host.Services.GetRequiredService<IAccountDirector<CheckingAccount>>();
var mapper = host.Services.GetRequiredService<IMapper>();

var model = new CheckingAccountViewModel()
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

var checkingAccountTranslated = mapper.Map<CheckingAccount>(model);

var checkingAccount2 = directorAccountBuilderService.BuildCheckingAccount(checkingAccountTranslated);

Console.WriteLine(checkingAccount2.ToString());

#endregion

Console.ReadKey();
