# Facade Pattern

<b>Facade</b> is a structural design pattern that provides a simplified (but limited) interface to a complex system of classes, library or framework.
While Facade decreases the overall complexity of the application, it also helps to move unwanted dependencies to one place.

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

If we try to understand this in simpler terms, then we can say that a room is a façade and just by looking at it from outside the door, one can not predict what is inside the room and how the room is structured from inside. Thus, Façade is a general term for simplifying the outward appearance of a complex or large system.

In software terms, Facade pattern hides the complexities of the systems and provides a simple interface to the clients.

This pattern involves one wrapper class which contains a set of methods available for the client. This pattern is particularly used when a system is very complex or difficult to understand and when the system has multiple subsystems.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Facade%20Pattern/facade.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Facade   (MortgageApplication)</b>
  * Knows which subsystem classes are responsible for a request.
  * Delegates client requests to appropriate subsystem objects.

* <b>Subsystem classes   (Bank, Credit, Loan)</b>
  * Implement subsystem functionality.
  * Handle work assigned by the Facade object.
  * Have no knowledge of the facade and keep no reference to it.
  
# Advantages of Facade Pattern

* We can use the façade pattern to collate all the complex method calls and related code blocks and channelizes it through one single Façade class. In this way with respect to client there is only one single call. Even if we make changes to the subsystem packages / class and their logic there is no impact to the client call. In short this increases loose coupling.
* It makes easier to use and maintain creating a more structured environment and reduces dependencies between libraries or other packages.

# Disadvantages of Facade Pattern

* One of the drawback is that the subsystem methods are connected to the Facade layer. If the structure of the subsystem changes then it will require subsequent change to the Facade layer and client methods.

# Interesting points
Facade pattern might be confused with mediator pattern. Mediator also abstracts the functionality of the subsystem in similar manner to facade. However there is a subtle difference between both these patterns. In case of Mediator pattern the subsystem is aware of the mediator, however in case of Facade the subsystem does not know anything about the facade. It’s a one way communication from Facade to subsystem.

# When to use it?

* A simple interface is required to access to a complex system.
* The abstractions and implementations of a subsystem are tightly coupled.
* Need an entry point to each level of layered software.
* The facade design pattern is particularly used when a system is very complex or difficult to understand because the system has a large number of interdependent classes or its source code is unavailable
