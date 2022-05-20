using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests.Base;

public partial class BaseArchTest
{
    protected static readonly string RepositoriesSuffix = "Repository";
    protected static readonly string RepositoriesNamespace = "Adapter.Database.Repositories";
    protected static readonly string IRepositoriesNamespace = "Core.Interfaces.Database.Repositories";

    protected static readonly IObjectProvider<IType> Repositories = Classes()
        .That()
        .HaveNameEndingWith(RepositoriesSuffix)
        .And()
        .ResideInNamespace(RepositoriesNamespace, true)
        .As("Repositories");

    protected static readonly IObjectProvider<IType> IRepositories = Interfaces()
        .That()
        .HaveNameEndingWith(RepositoriesSuffix)
        .And()
        .ResideInNamespace(IRepositoriesNamespace, true)
        .As("IRepositories");
}