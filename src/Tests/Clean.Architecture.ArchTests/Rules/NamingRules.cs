using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Syntax.Elements.Types;

namespace Clean.Architecture.ArchTests.Rules;

public static class NamingRules
{
    public static IArchRule ShouldEndWithSuffix(GivenTypesConjunction source, string suffix)
    {
        return source.Should().HaveNameEndingWith(suffix);
    }
}