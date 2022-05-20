using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Clean.Architecture.ArchTests;

public class InterfaceArchTest : BaseArchTest
{
    [Fact]
    public void ShouldStartWithI()
    {
        var assert = Interfaces().Should().HaveNameStartingWith("I");

        assert.Check(Architecture);
    }
}