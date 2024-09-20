# Design Patterns Learning in C#

## Description

This project demonstrates various design patterns implemented in C#. It contains implementations of behavioral, creational, and structural patterns, with examples for each.

This project is based on knowledge gained from the **Coursera** course [Design Patterns](https://www.coursera.org/learn/design-patterns) by the University of Alberta and the **ASD** course at **MIU**.

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
│   ├── State
│   │   ├── VendingMachine.cs
│   │   ├── IState.cs
│   │   ├── IdleState.cs
│   │   ├── HasOneDollarState.cs
│   │   └── OutOfStockState.cs
│   ├── Command
│   │   ├── ICommand.cs
│   │   ├── PasteCommand.cs
│   │   ├── Document.cs
│   │   └── CommandManager.cs
│   ├── Mediator
│   |    ├── IChatRoomMediator.cs
│   |    ├── ChatRoom.cs
│   |    ├── User.cs
│   |    └── Mediator-Pattern.pdf
│   └── Observer
│       ├── IObserver.cs
│       ├── Subject.cs
│       ├── Blog.cs
│       └── Subscriber.cs
├── DesignPrinciples
│   ├── DependencyInversion
│   │   ├── Followed
│   │   │   ├── ClientSubsystem.cs
│   │   │   ├── ISorting.cs
│   │   │   ├── MergeSort.cs
│   │   │   └── QuickSort.cs
│   │   └── Violation
│   │       ├── ClientSubsystem.cs
│   │       └── MergeSort.cs
│   ├── InterfaceSegregation
│   │   ├── Followed
│   │   │   ├── HumanCashier.cs
│   │   │   ├── ICashier.cs
│   │   │   ├── IHumanWorker.cs
│   │   │   └── SelfServeMachine.cs
│   │   └── Violation
│   │       ├── HumanCashier.cs
│   │       ├── ICashier.cs
│   │       └── SelfServeMachine.cs
│   ├── LeastKnowledge
│   │   ├── Followed
│   │   │   ├── Customer.cs
│   │   │   ├── Money.cs
│   │   │   ├── Store.cs
│   │   │   ├── Wallet.cs
│   │   └── Violation
│   │       ├── Customer.cs
│   │       ├── Money.cs
│   │       ├── Store.cs
│   │       └── Wallet.cs
│   ├── LSP
│   │   ├── Bird.cs
│   │   ├── Penguin.cs
│   │   ├── Sparrow.cs
│   └── OpenClose
│       ├── AreaCalculator.cs
│       ├── Circle.cs
│       ├── Rectangle.cs
│       └──Shape.cs
├── Config
│   ├── Patterns
│   │   ├── AdapterPattern.cs
│   │   ├── ChainOfResponsibilityPattern.cs
│   │   ├── CommandPattern.cs
│   │   ├── CompositePattern.cs
│   │   ├── DecoratorPattern.cs
│   │   ├── FacadePattern.cs
│   │   ├── FactoryMethodPattern.cs
│   │   ├── MediatorPattern.cs
│   │   ├── ObserverPattern.cs
│   │   ├── ProxyPattern.cs
│   │   ├── SingletonPattern.cs
│   │   ├── StatePattern.cs
│   │   └── TemplatePattern.cs
│   ├── Principles
│   │   ├── DependencyInversionPrinciple.cs
│   │   ├── InterfaceSegregationPrinciple.cs
│   │   ├── LeastKnowledgePrinciple.cs
│   │   ├── LSPPrinciple.cs
│   │   ├── OpenClosePrinciple.cs
│   └── Settings
│       ├── IPattern.cs
│       └── PatternRegistry.cs
├── Material
│   ├── ASD
│   │   ├── slides
│   │   │   ├── Lesson01.pdf
│   │   │   ├── Lesson02.pdf
│   │   │   ├── Lesson03.pdf
│   │   │   ├── Lesson04.pdf
│   │   │   ├── Lesson05.pdf
│   │   │   ├── Lesson06.pdf
│   │   │   ├── Lesson07.pdf
│   │   │   ├── Lesson08.pdf
│   │   │   ├── Lesson09-1.pdf
│   │   │   ├── Lesson09-2.pdf
│   │   │   ├── Lesson09.pdf
│   │   │   ├── Lesson10.pdf
│   │   │   ├── Lesson11.pdf
│   │   │   └── Lesson12.pdf
│   │   ├── CS525-2024-05A-05D-CourseOverviewChart.pdf
│   │   ├── CS525-2024-05A-05D-Syllabus-PaymanSalek.pdf
│   │   └── DesignPatternsChart.pdf
│   ├── Design Patterns.pdf
│   └── Glossary.pdf
├── .gitignore
├── DesignPatternsLearning.csproj
├── DesignPatterns.sln
└── Program.cs
```
