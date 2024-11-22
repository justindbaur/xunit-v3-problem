# Problem

Traits added to `ITheoryDataRow` can't be used to filter by.

A trait key and value added via `[Trait]` works.

```bash
dotnet test --filter "MyTrait=Three"

# Output:
# Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 1.0s
```

A trait added on `ITheoryDataRow.WithTrait` does not.

```bash
dotnet test --filter "MyTrait=One"

# Output:
# xunit-v3-problem test succeeded with 1 warning(s) (0.7s)
#    /usr/local/share/dotnet/sdk/9.0.100/Microsoft.TestPlatform.targets(48,5): warning : No test matches the given testcase filter `MyTrait=One` in /Users/jb/dev/justindbaur/xunit-v3-problem/bin/Debug/net8.0/xunit-v3-problem.dll

# Test summary: total: 0, failed: 0, succeeded: 0, skipped: 0, duration: 0.6s
```
