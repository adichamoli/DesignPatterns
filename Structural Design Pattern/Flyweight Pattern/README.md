# Flyweight Pattern

<b>Flyweight</b> is a structural design pattern that allows programs to support vast quantities of objects by keeping their memory consumption low.

The pattern achieves it by sharing parts of object state between multiple objects. In other words, the Flyweight saves RAM by caching the same data used by different objects.

Flyweight Design pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns in .Net. Flyweight pattern tries to reuse already existing similar kind objects by storing them and creates a new object when no matching object is found.

Flyweight pattern is used to reduce the number of objects created, to decrease memory and resource usage. As a result, it increases performance.

Flyweight pattern tries to reuse already existing similar kind objects by storing them and creates a new object when no matching object is found.

The flyweight pattern uses the concepts of intrinsic and extrinsic data.

<b>Intrinsic data</b> is held in the properties of the shared flyweight objects. This information is stateless and generally remains unchanged, if any change occurs it would be reflected among all of the objects that reference the flyweight.

<b>Extrinsic data</b> is computed on the fly means at runtime and it is held outside of a flyweight object. Hence it can be stateful.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Flyweight%20Pattern/flyweight.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <bFlyweight  (Character)</b>
  * Declares an interface through which flyweights can receive and act on extrinsic state.

* <b>ConcreteFlyweight   (CharacterA, CharacterB, ..., CharacterZ)</b>
  * Implements the Flyweight interface and adds storage for intrinsic state, if any. A ConcreteFlyweight object must be sharable. Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.

* <b>UnsharedConcreteFlyweight   ( not used )</b>
  * Not all Flyweight subclasses need to be shared. The Flyweight interface enables sharing, but it doesn't enforce it. It is common for UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children at some level in the flyweight object structure (as the Row and Column classes have).

* <b>FlyweightFactory   (CharacterFactory)</b>
  * Creates and manages flyweight objects
  * Ensures that flyweight are shared properly. When a client requests a flyweight, the FlyweightFactory objects assets an existing instance or creates one, if none exists.

* <b>Client   (FlyweightApp)</b>
  * Maintains a reference to flyweight(s).
  * Computes or stores the extrinsic state of flyweight(s).
  
# When to use the Flyweight Design Pattern
* When an application uses a large number of objects
* When there is a repetitive creation of heavy objects
* When there are memory allocation issues in the application
* When the many groups of objects can be replaced by a few shared objects

# Advantages of Flyweight Design Pattern
* Reduce memory usage by sharing heavy objects
* Improved data caching for higher response time
* Increased performance due to a lesser number of heavy objects
 
# Disadvantages of Flyweight Design Pattern
* This makes garbage collection unfriendly solution, as per the implementation, shared objects may be not eligible for garbage collection
* Reduce memory usage by sharing heavy objects
* Improved data caching for higher response time
* Increased performance due to a lesser number of heavy objects
