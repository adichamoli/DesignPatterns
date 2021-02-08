# Mediator Pattern

<b>Mediator</b> is a behavioral design pattern that reduces coupling between components of a program by making them communicate indirectly, through a special mediator object.

The Mediator makes it easy to modify, extend and reuse individual components because they’re no longer dependent on the dozens of other classes.

Imagine an application in which there are many objects that are communicating with each other. The mediator design pattern is useful when the number of objects grows so large that it becomes difficult to maintain the references to the objects. The mediator is essentially an object that encapsulates how one or more objects interact with each other. The mediator design pattern controls how these objects communicate, and helps to reduce the number of dependencies among them that you have to manage.

In the mediator design pattern, the objects don’t communicate with one another directly but through the mediator. When an object needs to communicate with another object or a set of objects, it transmits the message to the mediator. The mediator then transmits the message to each receiver object in a form that is understandable to it.

By eliminating the direct communication between objects, the mediator design pattern promotes loose coupling. The other benefit of using the mediator design pattern is that it improves code readability and maintainability.


<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Mediator%20Pattern/mediator.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Mediator  (IChatroom)</b>
  * Defines an interface for communicating with Colleague objects
* <b>ConcreteMediator  (Chatroom)</b>
  * Implements cooperative behavior by coordinating Colleague objects
  * Knows and maintains its colleagues
* <b>Colleague classes  (Participant)</b>
  * Each Colleague class knows its Mediator object
  * Each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague
  
# Advantages of Mediator Pattern

* Simplicity
* You can replace one object in the structure with a different one without affecting the classes and the interfaces.

# Disadvantages of Mediator Pattern

* The Mediator often needs to be very intimate with all the different classes, And it makes it really complex.
* Can make it difficult to maintain.

# When to use it?

* Communication between multiple objects is well defined but potentially complex.
* When too many relationships exist and a common point of control or communication is required.
* Some object can be grouped and customized based on behaviors.
