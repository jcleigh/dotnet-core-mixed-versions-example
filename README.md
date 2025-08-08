
# dotnet-core-mixed-versions-example

This repository demonstrates how GitHub Copilot can help modernize .NET projects and tooling, especially when dealing with legacy codebases that use multiple .NET Core versions. It is designed as a hands-on demo for Copilot's capabilities in refactoring, upgrading, and maintaining .NET solutions.

## Project Structure

The codebase contains several types of .NET projects:

- **DotNetCoreTwoPointOne**: A console application targeting .NET Core 2.1, with a simple model (`Person`).
- **DotNetCoreTwoPointTwo**: A console application targeting .NET Core 2.2, also with a basic model (`Person`).
- **DotNetCoreTwoPointTwo.Lib**: A class library targeting .NET Core 2.2, intended for sharing code between projects.
- **DotNetCoreThreePointOne**: A console application targeting .NET Core 3.1, with its own model (`Person`).
- **DotNetCoreThreePointOne.Web**: An ASP.NET Core 3.1 MVC web application, including controllers, views, and models.
- **DotNetCoreThreePointOne.Test**: A test project for the web application, demonstrating unit testing in .NET Core 3.1.

## Purpose

The main goal is to showcase how Copilot can assist in:
- Upgrading older .NET Core projects to newer versions
- Refactoring and modernizing code
- Adding tests and improving coverage
- Migrating between project types (console, library, web, test)
- Handling mixed-version solutions and dependencies

This repository is ideal for experimenting with Copilot's .NET features and for learning best practices in modernization workflows.
