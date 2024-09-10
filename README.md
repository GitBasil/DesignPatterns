# Design Patterns Learning in C#

## Description

This project demonstrates various design patterns implemented in C#. It contains implementations of behavioral, creational, and structural patterns, with examples for each.

This project is based on knowledge gained from the **Coursera** course [Design Patterns](https://www.coursera.org/learn/design-patterns) by the University of Alberta.

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
│   ├── ChainOfResponsibility
│   │   ├── Handlers
│   │   │   ├── Handler.cs
│   │   │   ├── HighLevelHandler.cs
│   │   │   ├── IHandler.cs
│   │   │   ├── LowLevelHandler.cs
│   │   │   └── MidLevelHandler.cs
│   │   └── ChainManager.cs
│   ├── Template
│   │   ├── PastaDish.cs
│   │   ├── Penne.cs
│   │   ├── Spaghetti.cs
│   │   └── TemplatePattern.cs
│   └── State
│       ├── VendingMachine.cs
│       ├── IState.cs
│       ├── IdleState.cs
│       ├── HasOneDollarState.cs
│       └── OutOfStockState.cs
├── Material
│   ├── Design Patterns.pdf
│   └── Glossary.pdf
├── Config
│   ├── IPattern.cs
│   ├── PatternRegistry.cs
│   ├── SingletonPattern.cs
│   ├── FactoryMethodPattern.cs
│   ├── FacadePattern.cs
│   ├── AdapterPattern.cs
│   ├── CompositePattern.cs
│   ├── DecoratorPattern.cs
│   ├── ProxyPattern.cs
│   ├── TemplatePattern.cs
│   ├── ChainOfResponsibilityPattern.cs
│   └── StatePattern.cs
├── .gitignore
├── DesignPatternsLearning.csproj
├── DesignPatterns.sln
└── Program.cs
```
