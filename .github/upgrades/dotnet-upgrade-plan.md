# .NET 9.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 9.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 9.0 upgrade.
3. Upgrade DotNetCoreThreePointOne.Web\DotNetCoreThreePointOne.Web.csproj
4. Upgrade DotNetCoreThreePointOne\DotNetCoreThreePointOne.csproj
5. Upgrade DotNetCoreTwoPointTwo.Lib\DotNetCoreTwoPointTwo.Lib.csproj
6. Upgrade DotNetCoreThreePointOne.Test\DotNetCoreThreePointOne.Test.csproj
7. Upgrade DotNetCoreTwoPointTwo\DotNetCoreTwoPointTwo.csproj
8. Upgrade DotNetCoreTwoPointOne\DotNetCoreTwoPointOne.csproj
9. Run unit tests to validate upgrade in the projects listed below:
   - DotNetCoreThreePointOne.Test\DotNetCoreThreePointOne.Test.csproj

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                         |
|:------------------------------------|:---------------:|:-----------:|:------------------------------------|
| Newtonsoft.Json                     |   13.0.1        |  13.0.3     | Recommended for .NET 9.0           |
| System.Data.SqlClient               |   4.8.5         |  4.9.0      | Security vulnerability              |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### DotNetCoreThreePointOne.Web\DotNetCoreThreePointOne.Web.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp3.1` to `net9.0`

#### DotNetCoreThreePointOne\DotNetCoreThreePointOne.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp3.1` to `net9.0`

#### DotNetCoreTwoPointTwo.Lib\DotNetCoreTwoPointTwo.Lib.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp2.2` to `net9.0`

NuGet packages changes:
  - Newtonsoft.Json should be updated from `13.0.1` to `13.0.3` (*recommended for .NET 9.0*)
  - System.Data.SqlClient should be updated from `4.8.5` to `4.9.0` (*security vulnerability*)

#### DotNetCoreThreePointOne.Test\DotNetCoreThreePointOne.Test.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp3.1` to `net9.0`

#### DotNetCoreTwoPointTwo\DotNetCoreTwoPointTwo.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp2.2` to `net9.0`

NuGet packages changes:
  - Newtonsoft.Json should be updated from `13.0.1` to `13.0.3` (*recommended for .NET 9.0*)

#### DotNetCoreTwoPointOne\DotNetCoreTwoPointOne.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp2.1` to `net9.0`