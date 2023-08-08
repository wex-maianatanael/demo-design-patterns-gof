// See https://aka.ms/new-console-template for more information

using Demo.Builder.Builders;
using Demo.Builder.Builders.Contracts;
using Demo.Builder.Directors;
using Demo.Builder.Directors.Contracts;
using Demo.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<ICheckingAccountBuilder, CheckingAccountBuilder>();
        services.AddTransient<IInvestmentAccountBuilder, InvestmentAccountBuilder>(); // todo: not tested
        services.AddTransient<ISavingsAccountBuilder, SavingsAccountBuilder>(); // todo: not tested
        services.AddTransient<IStudentAccountBuilder, StudentAccountBuilder>(); // todo: not tested

        services.AddTransient<IAccountDirector<CheckingAccount>, AccountDirector<CheckingAccount>>(); // working
        services.AddTransient<IAccountDirector<InvestmentAccount>, AccountDirector<InvestmentAccount>>(); // todo: not implemented
        services.AddTransient<IAccountDirector<SavingsAccount>, AccountDirector<SavingsAccount>>(); // todo: not implemented
        services.AddTransient<IAccountDirector<StudentAccount>, AccountDirector<StudentAccount>>(); // todo: not implemented
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

// todo: depending on the scenario, it could be a view model or dto class.
var tempCheckingAccount = new CheckingAccount()
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

var checkingAccount2 = directorAccountBuilderService.BuildCheckingAccount(tempCheckingAccount);

Console.WriteLine(checkingAccount2.ToString());

#endregion

Console.ReadKey();
