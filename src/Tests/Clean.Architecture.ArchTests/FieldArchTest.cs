using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using Clean.Architecture.ArchTests.Base;
using Xunit;

namespace Clean.Architecture.ArchTests;

using static ArchRuleDefinition;

public class FieldArchTest : BaseArchTest
{
    [Fact]
    public void ShouldStartWithUppercaseLetter()
    {
        var assert = FieldMembers()
            .That()
            .ArePrivate()
            .Should()
            .HaveNameStartingWith("_");

        assert.Check(Architecture);
    }
}