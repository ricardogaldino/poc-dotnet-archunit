using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Clean.Architecture.ArchTests.Rules;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests;

public class ExternalArchTest : BaseArchTest
{
    private readonly GivenTypesConjunction _externals = Types().That().Are(Externals);


    [Fact]
    public void ShouldNotDependControllerLayer()
    {
        var assert = DependencyRules.NotDepend(_externals, Controllers);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependUseCaseLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _externals,
            IUseCases,
            UseCases
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepositoryLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _externals,
            IRepositories,
            Repositories
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldEndWithExternal()
    {
        var assert = NamingRules.ShouldEndWithSuffix(_externals, "External");

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = DependencyRules.ResideInImplementationNamespace(
            ExternalsNamespace,
            ExternalsSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = DependencyRules.ResideInInterfaceNamespace(
            IExternalsNamespace,
            ExternalsSuffix
        );

        assert.Check(Architecture);
    }
}