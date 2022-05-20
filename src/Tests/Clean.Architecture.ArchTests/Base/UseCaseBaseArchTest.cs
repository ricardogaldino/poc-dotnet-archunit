using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests.Base;

public partial class BaseArchTest
{
    protected static readonly string UseCasesSuffix = "UseCase";
    protected static readonly string UseCasesNamespace = "Core.UseCases";
    protected static readonly string IUseCasesNamespace = "Core.Interfaces.UseCases";

    protected static readonly IObjectProvider<IType> UseCases = Classes()
        .That()
        .HaveNameEndingWith(UseCasesSuffix)
        .And()
        .ResideInNamespace(UseCasesNamespace, true)
        .As("UseCases");

    protected static readonly IObjectProvider<IType> IUseCases = Interfaces()
        .That()
        .HaveNameEndingWith(UseCasesSuffix)
        .And()
        .ResideInNamespace(IUseCasesNamespace, true)
        .As("IUseCases");
}