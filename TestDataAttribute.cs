using System.Reflection;
using Xunit.v3;
using Xunit.Sdk;

namespace xunit_v3_problem;

public class TestDataAttribute : DataAttribute
{
    public override ValueTask<IReadOnlyCollection<ITheoryDataRow>> GetData(MethodInfo testMethod, DisposalTracker disposalTracker)
    {
        return new(
        [
            new TheoryDataRow(1, 2)
                .WithTrait("MyTrait", "One"),
            new TheoryDataRow(2, 1)
                .WithTrait("MyTrait", "Two"),
        ]);
    }

    public override bool SupportsDiscoveryEnumeration()
    {
        return true;
    }
}
