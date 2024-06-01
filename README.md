# modular-monolith

A bare bones implementation of an event management modular monolith called Evently.

Primarly built to showcase modular monolith and other practices including:

- Separation of modules in code
- Separation of modules in DB
- Separation of read and write paths (CQRS)
- Messaging between modules

**Note** - does **NOT** include other best practices, notably:

- Domain Driven Design and all associated practices

### Features - Implemented

- API endpoint tagging
- Clean Architecture
- Minimal APIs
- OpenAPI/Swagger
- ORMs (EFCore)
- Vertical slices

### Features - To be Implemented

- CI/CD using Github Actions
- Docker container for DB hosting in development
- Identity management with KeyCloak
- MassTransit messaging
- Outbox and Inbox pattern for guaranteed at least once delivery
- Structured logging with Serilog and Seq
- ... more to be added


