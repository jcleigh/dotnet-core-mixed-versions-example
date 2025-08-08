# .NET 9.0 Upgrade Report

## Project target framework modifications

| Project name                                   | Old Target Framework    | New Target Framework | Commits                   |
|:-----------------------------------------------|:-----------------------:|:--------------------:|---------------------------|
| DotNetCoreThreePointOne.Web.csproj            |   netcoreapp3.1         | net9.0               | 107e43c9                  |
| DotNetCoreThreePointOne.csproj                |   netcoreapp3.1         | net9.0               | f5111bd1                  |
| DotNetCoreTwoPointTwo.Lib.csproj              |   netcoreapp2.2         | net9.0               | 659c60ca                  |
| DotNetCoreThreePointOne.Test.csproj           |   netcoreapp3.1         | net9.0               | 7927ca78                  |
| DotNetCoreTwoPointTwo.csproj                  |   netcoreapp2.2         | net9.0               | f8652d60                  |
| DotNetCoreTwoPointOne.csproj                  |   netcoreapp2.1         | net9.0               | 907af7d0                  |

## NuGet Packages

| Package Name                        | Old Version | New Version | Commit Id                                 |
|:------------------------------------|:-----------:|:-----------:|-------------------------------------------|
| Newtonsoft.Json                     |   13.0.1    |  13.0.3     | 659c60ca, f8652d60                       |
| System.Data.SqlClient               |   4.8.5     |  4.9.0      | 83125302                                 |

## All commits

| Commit ID              | Description                                |
|:-----------------------|:-------------------------------------------|
| c5ccaabd               | Commit upgrade plan                        |
| 107e43c9               | Update DotNetCoreThreePointOne.Web.csproj to .NET 9.0 |
| f5111bd1               | Update DotNetCoreThreePointOne.csproj to .NET 9.0 |
| 659c60ca               | Update DotNetCoreTwoPointTwo.Lib.csproj to net9.0 |
| 83125302               | Update System.Data.SqlClient version in .csproj file |
| 7927ca78               | Update DotNetCoreThreePointOne.Test.csproj to net9.0 |
| f8652d60               | Update DotNetCoreTwoPointTwo.csproj to target net9.0 |
| 907af7d0               | Update DotNetCoreTwoPointOne.csproj to target .NET 9.0 |

## Test Results

| Test Project                        | Passed | Failed | Skipped | Status                    |
|:------------------------------------|:------:|:------:|:-------:|---------------------------|
| DotNetCoreThreePointOne.Test        |   6    |   0    |    0    | ✅ All tests passed       |

## Security Vulnerabilities Addressed

- **System.Data.SqlClient**: Upgraded from 4.8.5 to 4.9.0 to address security vulnerabilities
- **Newtonsoft.Json**: Upgraded from 13.0.1 to 13.0.3 for latest recommended version

## Next steps

- Consider migrating from System.Data.SqlClient to Microsoft.Data.SqlClient for better future support
- Consider migrating from Newtonsoft.Json to System.Text.Json for better performance and native .NET support
- Review and test application functionality thoroughly in the .NET 9.0 environment