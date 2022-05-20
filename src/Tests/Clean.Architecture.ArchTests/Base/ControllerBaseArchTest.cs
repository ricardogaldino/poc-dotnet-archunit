using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests.Base;

public partial class BaseArchTest
{
    protected static readonly string ControllersSuffix = "Controller";
    protected static readonly string ControllersNamespace = "Adapter.UI.Controllers";

    protected static readonly IObjectProvider<IType> Controllers = Classes()
        .That()
        .HaveNameEndingWith(ControllersSuffix)
        .And()
        .ResideInNamespace(ControllersNamespace, true)
        .As("Controllers");
}