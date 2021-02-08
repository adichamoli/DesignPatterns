# Observer Pattern

<b>Observer</b> is a behavioral design pattern that allows some objects to notify other objects about changes in their state.

The Observer pattern provides a way to subscribe and unsubscribe to and from these events for any object that implements a subscriber interface.

The observer design pattern enables a subscriber to register with and receive notifications from a provider. It is suitable for any scenario that requires push-based notification. The pattern defines a provider (also known as a subject or an observable) and zero, one, or more observers. Observers register with the provider, and whenever a predefined condition, event, or state change occurs, the provider automatically notifies all observers by calling one of their methods. In this method call, the provider can also provide current state information to observers. 


<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Observer%20Pattern/observer.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Subject  (Stock)</b>
  * Knows its observers. Any number of Observer objects may observe a subject
  * Provides an interface for attaching and detaching Observer objects.
* <b>ConcreteSubject  (IBM)</b>
  * Stores state of interest to ConcreteObserver
  * Sends a notification to its observers when its state changes
* <b>Observer  (IInvestor)</b>
  * Defines an updating interface for objects that should be notified of changes in a subject.
* <b>ConcreteObserver  (Investor)</b>
  * Maintains a reference to a ConcreteSubject object
  * Stores state that should stay consistent with the subject's
  * Implements the Observer updating interface to keep its state consistent with the subject's
  
# Advantages of Observer Pattern
  
* It supports the principle of loose coupling between objects that interact with each other
* It allows sending data to other objects effectively without any change in the Subject or Observer classes
* Observers can be added/removed at any point in time

# Disadvantages of Observer Pattern

* The Observer interface has to be implemented by ConcreteObserver, which involves inheritance. There is no option for composition, as the Observer interface can be instantiated.
* If not correctly implemented, the Observer can add complexity and lead to inadvertent performance issues.
* In software application, notifications can, at times, be undependable and result in race conditions or inconsistency.

# When to use it?

* Changes in the state of an object need to be notified to a set of dependent objects, not all of them.
* Notification capability is required.
* The object sending the notification does not need to know about the receivers objects.
