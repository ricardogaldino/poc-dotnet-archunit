using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Clean.Architecture.ArchTests.Rules;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests;

public class UseCaseArchTest : BaseArchTest
{
    private readonly GivenTypesConjunction _useCases = Types().That().Are(UseCases);

    [Fact]
    public void ShouldNotDependRepositoryOrExternalImplementations()
    {
        var assert = DependencyRules.AndNotDepend(
            _useCases,
            Repositories,
            Externals);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependControllerLayer()
    {
        var assert = DependencyRules.NotDepend(
            _useCases,
            Controllers
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldEndWithUseCase()
    {
        var assert = NamingRules.ShouldEndWithSuffix(_useCases, UseCasesSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = DependencyRules.ResideInImplementationNamespace(
            UseCasesNamespace,
            UseCasesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = DependencyRules.ResideInInterfaceNamespace(
            IUseCasesNamespace,
            UseCasesSuffix
        );

        assert.Check(Architecture);
    }
}