# Factory Design Pattern

The factory method design pattern abstract the process of object creation and allows the object to be created at run-time when it is required. Factory method pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to create objects. People usually use this pattern as the standard way to create objects.

In Factory pattern, we create the object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Factory%20Pattern/factory.gif"/>
</p>

The classes and objects participating in the above UML class diagram are as follows:

#### Product
 
This defines the interface of objects the factory method creates

#### ConcreteProduct
 
This is a class that implements the Product interface.

#### Creator
 
This is an abstract class and declares the factory method, which returns an object of type Product.
This may also define a default implementation of the factory method that returns a default ConcreteProduct object.
This may call the factory method to create a Product object.

#### ConcreteCreator
 
This is a class that implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

# When to use it?

1. Subclasses figure out what objects should be created.
2. Parent class allows later instantiation to subclasses means the creation of an object is done when it is required.
3. The process of objects created is required to centralize within the application.
4. A class (creator) will not know what classes it will be required to create.

# Factory Design Pattern Advantages

1. Factory design pattern provides approach to code for interface rather than implementation.
2. Factory pattern removes the instantiation of actual implementation classes from client code. Factory pattern makes our code more robust, less coupled and easy to extend. For example, we can easily change PC class implementation because client program is unaware of this.
3. Factory pattern provides abstraction between implementation and client classes through inheritance.

# Factory Design Pattern Disdvantages

1. Because every application object that intends to use the services offered by the class hierarchy needs to implement the class selection criteria, it results in a high degree of coupling between an application object and the service provider class hierarchy.
2. Whenever the class selection criteria change, every application object that uses the class hierarchy must undergo a corresponding change.
3. Because class selection criteria needs to take all the factors that could affect the selection process into account, the implementation of an applicationobject could contain inelegant conditional statements.
