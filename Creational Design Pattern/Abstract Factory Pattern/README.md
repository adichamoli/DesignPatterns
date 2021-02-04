# Abstract Factory Pattern

Abstract Factory Design method falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to create a set of related objects, or dependent objects. Internally, Abstract Factory use Factory design pattern for creating objects. It may also use Builder design pattern and prototype design pattern for creating objects. It completely depends upon your implementation for creating objects.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Abstract%20Factory%20Pattern/abstract-factory.png"/>
</p>

Abstract Factory patterns act a super-factory which creates other factories. This pattern is also called a Factory of factories. In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Abstract%20Factory%20Pattern/AbstractFactoryPattern.png"/>
</p>

The classes, interfaces, and objects in the above UML class diagram are as follows:

#### AbstractFactory
This is an interface which is used to create abstract product

#### ConcreteFactory
This is a class which implements the AbstractFactory interface to create concrete products.

#### AbstractProduct
This is an interface which declares a type of product.

#### ConcreteProduct
This is a class which implements the AbstractProduct interface to create a product.

#### Client
This is a class which uses AbstractFactory and AbstractProduct interfaces to create a family of related objects.

# When to use it?

1. Create a set of related objects or dependent objects which must be used together.
2. System should be configured to work with multiple families of products.
3. The creation of objects should be independent of the utilizing system.
4. Concrete classes should be decoupled from clients.

# Difference between Factory Pattern and Abstract Factory Pattern

* The main difference between a “factory method” and an “abstract factory” is that the factory method is a single method, and an abstract factory is an object.
* The factory method is just a method, it can be overridden in a subclass, whereas the abstract factory is an object that has multiple factory methods on it.
* The Factory Method pattern uses inheritance and relies on a subclass to handle the desired object instantiation.

# Advantages of Abstract Factory Pattern

This pattern is particularly useful when the client doesn’t know exactly what type to create.

* <b>Isolation of concrete classes:</b> The Abstract Factory pattern helps you control the classes of objects that an application creates. Because a factory encapsulates the responsibility and the process of creating product objects, it isolates clients from implementation classes. Clients manipulate instances through their abstract interfaces. Product class names are isolated in the implementation of the concrete factory; they do not appear in client code.
* <b>Exchanging Product Families easily:</b> The class of a concrete factory appears only once in an application, that is where it’s instantiated. This makes it easy to change the concrete factory an application uses. It can use various product configurations simply by changing the concrete factory. Because an abstract factory creates a complete family of products, the whole product family changes at once.
* <b>Promoting consistency among products:</b> When product objects in a family are designed to work together, it’s important that an application use objects from only one family at a time. AbstractFactory makes this easy to enforce.n.

# Disadvantages of Abstract Factory Pattern

* Difficult to support new kind of products: Extending abstract factories to produce new kinds of Products isn’t easy. That’s because the AbstractFactory interface fixes the set of products that can be created. Supporting new kinds of products requires extending the factory interface, which involves changing the AbstractFactory class and all of its subclasses.
