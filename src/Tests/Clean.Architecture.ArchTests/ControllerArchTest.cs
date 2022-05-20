using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Clean.Architecture.ArchTests.Rules;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests;

public class ControllerArchTest : BaseArchTest
{
    private readonly GivenTypesConjunction _controllers = Types().That().Are(Controllers);

    [Fact]
    public void ShouldNotDependUseCaseImplementations()
    {
        var assert = DependencyRules.NotDepend(_controllers, UseCases);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepositoryLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _controllers,
            IRepositories,
            Repositories
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternalLayer()
    {
        var assert = DependencyRules.AndNotDepend(
            _controllers,
            IExternals,
            Externals
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldEndWithController()
    {
        var assert = NamingRules.ShouldEndWithSuffix(_controllers, ControllersSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = DependencyRules.ResideInImplementationNamespace(
            ControllersNamespace,
            ControllersSuffix
        );

        assert.Check(Architecture);
    }
}