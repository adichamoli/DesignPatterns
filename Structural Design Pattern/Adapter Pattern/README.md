# Adapter Design Pattern

Adapter design pattern is used between incompatible interfaces. It converts the incompatible interface into a compatible interface which can be used by client. So we can say that adapter design pattern is used to allow two incompatible interface to communicate. The adapter play the role of converter or translator.

Adapter is most commonly known as Wrappers because it wraps the adapter by a new interface which can be used by the client.

To handle the incompatibility we use different approaches and based on that we can classify Adapter Pattern in 2 parts.

* Object Adapter Pattern
* Class Adapter Pattern

### Object Adapter Design Pattern

In Object Adapter Pattern Incompatibility is handled by creating the object.

### Class Adapter Design Pattern

In Class Adapter Design Pattern Incompatibility is handled by inheritance.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Adapter%20Pattern/adapter-pattern-structure.jpg"/>
</p>

<b>Usage examples:</b> The Adapter pattern is pretty common in C# code. It’s very often used in systems based on some legacy code. In such cases, Adapters make legacy code work with modern classes.

<b>Identification:</b> Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. When the adapter receives a call to any of its methods, it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.

## Advantages of Adapter Pattern

* Helps achieve reusability and flexibility.
* Client class is not complicated by having to use a different interface and can use polymorphism to swap between different implementations of adapters.

## Disadvantages of Adapter Pattern

* All requests are forwarded, so there is a slight increase in the overhead.
* Sometimes many adaptations are required along an adapter chain to reach the type which is required.
