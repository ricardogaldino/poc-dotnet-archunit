using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Clean.Architecture.ArchTests.Rules;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests;

public class RepositoryArchTest : BaseArchTest
{
    private readonly GivenTypesConjunction _repositories = Types().That().Are(Repositories);

    [Fact]
    public void ShouldNotDependControllerLayer()
    {
        var assert = DependencyRules.NotDepend(_repositories, Controllers);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependUseCaseLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _repositories,
            IUseCases,
            UseCases
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternalLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _repositories,
            IExternals,
            Externals
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldEndWithRepository()
    {
        var assert = NamingRules.ShouldEndWithSuffix(_repositories, RepositoriesSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = DependencyRules.ResideInImplementationNamespace(
            RepositoriesNamespace,
            RepositoriesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = DependencyRules.ResideInInterfaceNamespace(
            IRepositoriesNamespace,
            RepositoriesSuffix
        );

        assert.Check(Architecture);
    }
}