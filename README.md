# modular-monolith

An implementation of an event management modular monolith called Evently.

Primarly built to showcase modular monolith practices including:

- Separation of modules in code
- Separation of modules in DB
- Separation of read and write paths (CQRS)
- Event driven architecture

Also to some degree:

- Clean Architecture
- Domain Driven Design


### Features - Implemented

- API endpoint tagging
- Correlation Ids for distributed tracing
- CQRS pattern with Mediatr
- Docker containers for App & DB hosting in development
- Domain events for side effects
- Minimal APIs
- OpenAPI/Swagger
- ORMs (EFCore, Dapper)
- Pagination
- Result pattern for handling request success/failure
- Static factory methods for domain entities
- Validation with FluentValidation
- Vertical slices


### Features - To Be Implemented

- API Versioning
- Architecture enforcement with architecture tests
- CI/CD using Github Actions
- Distributed caching with REDIS
- Health checks
- Identity management with KeyCloak
- Inbox and Outbox pattern for guaranteed at least once delivery
- Messaging with MassTransit
- Metrics and tracing with OpenTelemtry
- Structured logging with Serilog and Seq
- Unit tests
- ... more to be added


### Sample EFCore Migration Command

```dotnet ef migrations add Create_Database --context EventsDbContext --startup-project ../../../Api/Evently.Api -o Database/Migrations```


