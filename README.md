# modular-monolith

A bare bones implementation of an event management modular monolith called Evently.

Primarly built to showcase modular monolith practices including:

- Separation of modules in code
- Separation of modules in DB
- Separation of read and write paths (CQRS)
- Messaging between modules

**Note** - does **NOT** currently include other best practices I normally adhere to, most notably:

- Domain Driven Design and all associated practices


### Features - Implemented

- API endpoint tagging
- Clean Architecture
- Command Validation with FluentValidation
- CQRS with Mediatr
- Docker containers for App & DB hosting in development
- Minimal APIs
- OpenAPI/Swagger
- ORMs (EFCore, Dapper)
- Static factory methods for domain entities
- Vertical slices

### Features - To Be Implemented

- CI/CD using Github Actions
- Identity management with KeyCloak
- Messaging with MassTransit
- Inbox and Outbox pattern for guaranteed at least once delivery
- Structured logging with Serilog and Seq
- ... more to be added


### Sample EFCore Migration Command

```dotnet ef migrations add Create_Database --context EventsDbContext --startup-project ../../../Api/Evently.Api -o Database/Migrations```


