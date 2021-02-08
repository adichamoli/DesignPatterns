# Iterator Pattern

<b>Iterator</b> is a behavioral design pattern that allows sequential traversal through a complex data structure without exposing its internal details.

Thanks to the Iterator, clients can go over elements of different collections in a similar fashion using a single iterator interface.


<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Iterator%20Pattern/iterator.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Iterator  (AbstractIterator)</b>
  * Defines an interface for accessing and traversing elements.
* <b>ConcreteIterator  (Iterator)</b>
  * Implements the Iterator interface.
  * Keeps track of the current position in the traversal of the aggregate.
* <b>Aggregate  (AbstractCollection)</b>
  * Defines an interface for creating an Iterator object
* <b>ConcreteAggregate  (Collection)</b>
  * Implements the Iterator creation interface to return an instance of the proper ConcreteIterator
  
# When To Use Iterator Pattern
* Your collection has a complex data structure under the hood, but you want to hide its complexity from clients.
* You need to reduce duplication of traversal code across your app.
* You want your code to be able to traverse different data structures.

# Advantages of Iterator Pattern

The Iterator Pattern has several advantages, summarised in the following points:

* The code is easier to use, understand and test since the iterator uses the Single Responsibility and Open/Closed SOLID principles.
* The Single Responsibility Principle allows us to clean up the client and collections of the traversal algorithms.
* The Open/Closed Principle allows implementation of new types of collections and iterators without breaking anything.
* Parallel iteration over the same collection because each iterator object contains its own iteration state.
* Clean code because the client/context does not use a complex interface and the system is more flexible and reusable.
