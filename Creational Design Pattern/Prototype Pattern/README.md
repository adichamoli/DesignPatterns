# Prototype Pattern

Prototype pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to create a duplicate object or clone of the current object. It provides an interface for creating parts of a product.

Prototype design pattern is used to create a duplicate object or clone of the current object to enhance performance. This pattern is used when the creation of an object is costly or complex.

All prototype classes should have a common interface that makes it possible to copy objects even if their concrete classes are unknown. Prototype objects can produce full copies since objects of the same class can access each other’s private fields.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Prototype%20Pattern/prototype.png"/>
</p>

The classes, interfaces, and objects in the above UML class diagram are as follows:

#### Prototype
This is an interface which is used for the types of object that can be cloned itself.

#### ConcretePrototype
This is a class which implements the Prototype interface for cloning itself.

# When to use the Prototype Design Pattern

When a system should be independent of how its products are created, composed, and represented and
When the classes to instantiate are specified at run-time.
For example,
1. By dynamic loading or To avoid building a class hierarchy of factories that parallels the class hierarchy of products or
2. When instances of a class can have one of only a few different combinations of state. It may be more convenient to install a corresponding number of prototypes and clone them rather than instantiating the class manually, each time with the appropriate state.

# Advantages of Prototype Design Pattern

* <b>Adding and removing products at run-time –</b> Prototypes let you incorporate a new concrete product class into a system simply by registering a prototypical instance with the client. That’s a bit more flexible than other creational patterns, because a client can install and remove prototypes at run-time.
* <b>Specifying new objects by varying values –</b> Highly dynamic systems let you define new behavior through object composition by specifying values for an object’s variables and not by defining new classes.
* <b>Specifying new objects by varying structure –</b> Many applications build objects from parts and subparts. For convenience, such applications often let you instantiate complex, user-defined structures to use a specific subcircuit again and again.
* <b>Reduced subclassing –</b> Factory Method often produces a hierarchy of Creator classes that parallels the product class hierarchy. The Prototype pattern lets you clone a prototype instead of asking a factory method to make a new object. Hence you don’t need a Creator class hierarchy at all.

# Disadvantages of Prototype Design Pattern

* Overkill for a project that uses very few objects and/or does not have an underlying emphasis on the extension of prototype chains.
* It also hides concrete product classes from the client
* Each subclass of Prototype must implement the clone() operation which may be difficult, when the classes under consideration already exist. Also implementing clone() can be difficult when their internals include objects that don’t support copying or have circular references.
