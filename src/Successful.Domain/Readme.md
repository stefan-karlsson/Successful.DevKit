# Successful.Domain
Library containing code that helps out implementing domain driven design (DDD).
The Library is **not** production ready and is used for learning purpose. 

## Aggregates

An AGGREGATE is a cluster of associated objects that we treat as a unit for the purpose of data changes.
Each AGGREGATE has a root and a boundary. The boundary defines what is inside the AGGREGATE. 
The root is a single, specific ENTITY contained in the AGGREGATE.

`IAggregateRoot` - Interface to implement on aggregate root objects

## Entities

An object primarily defined by its identity is called an Entity

`IEntity` - Interface to implement on all entity objects
`Entity` - Abstract base class that implements IEntity
`AuditableEntity` - Base class for auditable entities
`ICreatableEntity` - Interface for creatable entities
`IModifiableEntity` - Interface for modifiable entities

## Enumerations
An enumerated type is a data type consisting of a set of named values. The enumerator names are usually identifiers that behave as constants.

`Enumeration` - Abstract class for creating a enumerable

## Events

Domain events are described as something that happens in the domain and is important to domain experts. 

`IDomainEvent` - Interface to inherit when creating a domain event
`DomainEvent` - Abstract class to inherit when creating a domain event
`IHasDomainEvent` - Interface to inherit when a domain object has domain events.

## Percistense

`IRepository` - Interface to inherit when creating a Repository
`IUnitOfWork` - Interface to inherit when creating a UnitOfWork

## ValueObjects
`IValueObject` - Interface to inherit when creating a value object
`ValueObject` - Abstract class to inherit when creating a value object