# Template Method Pattern

<b>Template Method</b> is a behavioral design pattern that allows you to defines a skeleton of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm’s structure.

Template method pattern is used to define the basic steps of an algorithm and allow the implementation of the individual steps to be changed. This pattern looks similar to the strategy design pattern. The main difference is the ability to change the parts of an algorithm rather than replacing an entire algorithm.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Template%20Method%20Pattern/template.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>AbstractClass  (DataObject)</b>
  * Defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
  * Implements a template method defining the skeleton of an algorithm. The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
* <b>ConcreteClass  (CustomerDataObject)</b>
  * Implements the primitive operations to carry out subclass-specific steps of the algorithm

# Advantages of Template Method Pattern

* As we saw earlier in the chapter, there is no code duplication.
* Code reuse happens with the Template Method pattern as it uses inheritance and not composition. Only a few methods need to be overridden.
* Flexibility lets subclasses decide how to implement steps in an algorithm.

# Disadvantages of Template Method Pattern

* Debugging and understanding the sequence of flow in the Template Method pattern can be confusing at times. You may end up implementing a method that shouldn't be implemented or not implementing an abstract method at all. Documentation and strict error handling has to be done by the programmer.
* Maintenance of the template framework can be a problem as changes at any level (low-level or high-level) can disturb the implementation. Hence, maintenance can be painful with the Template Method pattern.

# When to use it?

* An abstract view of an algorithm is required, but implementation varies according to the subclasses.
* Common behaviors of subclasses can be used to make to a common class.
