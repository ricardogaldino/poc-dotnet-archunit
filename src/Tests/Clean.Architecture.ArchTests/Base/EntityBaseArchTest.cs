using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests.Base;

public partial class BaseArchTest
{
    protected static readonly string EntitiesNamespace = "Core.Entities";

    protected static readonly IObjectProvider<IType> Entities = Classes()
        .That()
        .ResideInNamespace(EntitiesNamespace, true)
        .As("Entities");
}