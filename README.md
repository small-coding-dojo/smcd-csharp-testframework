# smcd-csharp-testframework

## one way to start the tests

The "watch" subcommand observes the project folder. The dotnet runtime will
rebuild the project and re-start it, if changes to relevant files are
detected.

```shell
dotnet watch run --project "TestFramework.Tests"
```

The above command is similar to:

```shell
dotnet build && dotnet run --project=TestFramework.Tests
```
