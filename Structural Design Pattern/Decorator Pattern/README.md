# Decorator Pattern

<b>Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects.</b>

Using decorators you can wrap objects countless number of times since both target objects and decorators follow the same interface. The resulting object will get a stacking behavior of all wrappers.

The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.

The idea of the Decorator Pattern is to wrap an existing class, add other functionality to it, then expose the same interface to the outside world. Because of this our decorator exactly looks like the original class to the people who are using it.

It is used to extend or alter the functionality at runtime. It does this by wrapping them in an object of the decorator class without modifying the original object. So it can be called a wrapper pattern.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Decorator%20Pattern/decorator.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Component   (LibraryItem)</b>
  * Defines the interface for objects that can have responsibilities added to them dynamically.

* <b>ConcreteComponent   (Book, Video)</b>
  * Defines an object to which additional responsibilities can be attached.

* <b>Decorator   (Decorator)</b>
  * Maintains a reference to a Component object and defines an interface that conforms to Component's interface.

* <b>ConcreteDecorator   (Borrowable)</b>
  * Adds responsibilities to the component.
  
  
# Advantages of Decorator Design Pattern
* It is flexible than inheritance because inheritance adds responsibility at compile time but decorator pattern adds at run time.
* We can have any number of decorators and also in any order.
* It extends functionality of object without affecting any other object.

# Disadvantage of Decorator Design Pattern
The main disadvantage of decorator design pattern is code maintainability because this pattern creates lots of similar decorators which are sometimes hard to maintain and distinguish.
