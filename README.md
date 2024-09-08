# DesignPatternsLearning

## Description

This project demonstrates various design patterns implemented in C#. It contains implementations of behavioral, creational, and structural patterns, with examples for each.

## Project Structure

```text
.
├── Creational
│   ├── FactoryMethod
│   │   ├── Bike.cs
│   │   ├── BikeStore.cs
│   │   ├── Car.cs
│   │   ├── CarStore.cs
│   │   ├── IRefuelable.cs
│   │   ├── Vehicle.cs
│   │   └── VehicleStore.cs
│   └── Singleton
│       └── Singleton.cs
├── Structural
│   ├── Adapter
│   │   ├── IPaymentProcessor.cs
│   │   ├── LegacyPaymentAdapter.cs
│   │   ├── LegacyPaymentGateway.cs
│   │   ├── ModernPaymentAdapter.cs
│   │   └── ModernPaymentGateway.cs
│   ├── Composite
│   │   ├── Housing
│   │   │   ├── Housing.cs
│   │   │   ├── IStructure.cs
│   │   │   └── Room.cs
│   │   └── Playlist
│   │       ├── IComponent.cs
│   │       ├── Playlist.cs
│   │       └── Song.cs
│   ├── Decorator
│   │   ├── AuthenticatedWebPage.cs
│   │   ├── AuthorizedWebPage.cs
│   │   ├── BasicWebPage.cs
│   │   ├── WebPage.cs
│   │   └── WebPageDecorator.cs
│   ├── Facade
│   │   ├── AccountBase.cs
│   │   ├── BankService.cs
│   │   ├── Chequing.cs
│   │   ├── IAccount.cs
│   │   ├── Investment.cs
│   │   └── Saving.cs
│   └── Proxy
│       ├── IOrder.cs
│       ├── Order.cs
│       ├── OrderFulfillment.cs
│       └── Warehouse.cs
├── Behavioral
|   └── Template
│       ├── PastaDish.cs
│       ├── Penne.cs
│       ├── Spaghetti.cs
│       └── TemplatePattern.cs
├── Material
│   ├── Design Patterns.pdf
│   └── Glossary.pdf
├── Config
│   ├── AdapterPattern.cs
│   ├── CompositePattern.cs
│   ├── DecoratorPattern.cs
│   ├── FacadePattern.cs
│   ├── FactoryMethodPattern.cs
│   ├── IPattern.cs
│   ├── PatternRegistry.cs
│   ├── ProxyPattern.cs
│   ├── SingletonPattern.cs
│   └── TemplatePattern.cs
├── .gitignore
├── DesignPatternsLearning.csproj
├── DesignPatterns.sln
└── Program.cs
```
