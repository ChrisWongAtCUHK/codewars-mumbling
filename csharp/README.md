# [Unit testing C# with NUnit and .NET Core](https://learn.microsoft.com/en-gb/dotnet/core/testing/unit-testing-csharp-with-nunit#adding-more-features)
1. in root directory
   ```
   dotnet new sln
   ```
2. create class library
   ```
   mkdir Solution && pushd Solution
   dotnet new classlib
   ```
3. rename Class1.cs
   ```
   mv Class1.cs Accumul.cs
   ```
4. add project to sln
   ```
   popd
   dotnet sln add Solution/Solution.csproj
   ```
5. create Solution.Tests directory
   ```
   mkdir Solution.Tests && pushd Solution.Tests
   ```
6. new NUnit project
   ```
   dotnet new nunit && dotnet add reference ../Solution/Solution.csproj
   ```
7. add nunit project to sln
   ```
   popd
   dotnet sln add Solution.Tests/Solution.Tests.csproj
   ```
8. gitignore
   ```
   dotnet new gitignore
   ```
9.  run test
   ```
   dotnet test
   ```