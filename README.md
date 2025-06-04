# CodexSkills

This repository contains a minimal .NET 8 sample solution that demonstrates a layered architecture. It exposes a small Web API that returns random weather forecasts.

The solution is composed of the following projects:

- `Template.API` - ASP.NET Core Web API entry point
- `Template.Application` - application layer abstractions and services
- `Template.Domain` - domain models
- `Template.Infrastructure` - infrastructure service implementations

## Building

Use the .NET CLI to build the entire solution:

```bash
dotnet build
```

## Using the API

Run the API project (e.g. `dotnet run --project Template.API`) and browse to `/weatherforecast`. The endpoint returns a collection of randomly generated forecasts. Swagger UI is available in development mode at `/swagger` for exploring the API.
