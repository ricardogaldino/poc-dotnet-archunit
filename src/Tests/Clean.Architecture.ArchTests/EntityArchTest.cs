using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Clean.Architecture.ArchTests.Rules;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests;

public class EntityArchTest : BaseArchTest
{
    private readonly GivenTypesConjunction _entities = Types().That().Are(Entities);

    [Fact]
    public void ShouldNotDependControllerLayer()
    {
        var assert = DependencyRules.NotDepend(_entities, Controllers);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependUseCaseLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _entities,
            IUseCases,
            UseCases
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepositoryLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _entities,
            IRepositories,
            Repositories
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternalLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _entities,
            IExternals,
            Externals
        );

        assert.Check(Architecture);
    }
}