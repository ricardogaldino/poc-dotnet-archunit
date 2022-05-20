using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests.Base;

public partial class BaseArchTest
{
    protected static readonly string ExternalsSuffix = "External";
    protected static readonly string ExternalsNamespace = "Adapter.External";
    protected static readonly string IExternalsNamespace = "Core.Interfaces.External";

    protected static readonly IObjectProvider<IType> Externals = Classes()
        .That()
        .HaveNameEndingWith(ExternalsSuffix)
        .And()
        .ResideInNamespace(ExternalsNamespace, true)
        .As("Externals");

    protected static readonly IObjectProvider<IType> IExternals = Interfaces()
        .That()
        .HaveNameEndingWith(ExternalsSuffix)
        .And()
        .ResideInNamespace(IExternalsNamespace, true)
        .As("IExternals");
}