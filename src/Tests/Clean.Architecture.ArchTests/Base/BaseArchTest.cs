using System.Reflection;
using ArchUnitNET.Loader;

namespace Clean.Architecture.ArchTests.Base;

public partial class BaseArchTest
{
    protected static readonly ArchUnitNET.Domain.Architecture Architecture =
        new ArchLoader().LoadAssemblies(GetAssemblies()).Build();

    private static Assembly[] GetAssemblies()
    {
        return new[]
        {
            Assembly.Load("Clean.Architecture.Core.Interfaces"),
            Assembly.Load("Clean.Architecture.Core.UseCases"),
            Assembly.Load("Clean.Architecture.Core.Entities"),
            Assembly.Load("Clean.Architecture.Adapter.Database"),
            Assembly.Load("Clean.Architecture.Adapter.External"),
            Assembly.Load("Clean.Architecture.Adapter.UI")
        };
    }
}