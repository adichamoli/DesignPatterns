# Builder Design Pattern

Builder design pattern falls under the category of "Creational" design patterns. This pattern is used to build a complex object by using a step by step approach.

GOF (Gang of Four) says:

#### *"Separate the construction of a complex object from its representation so that the same construction process can create different representations"*

So, it is used to construct a complex object step by step and the final step returns the object. Also, the process of constructing an object should be generic so that it can be used to create different representations of the same object.

The Builder design pattern is one of the GoF design patterns that describe how to solve recurring design problems in object-oriented software.

The Builder design pattern solves problems like:

* How can a class (the same construction process) create different representations of a complex object?
* How can a class that includes creating a complex object be simplified?
Creating and assembling the parts of a complex object directly within a class is inflexible. It commits the class to creating a particular representation of the complex object and makes it impossible to change the representation later independently from (without having to change) the class.

The Builder design pattern describes how to solve such problems:

* Encapsulate creating and assembling the parts of a complex object in a separate Builder object.
* A class delegates object creation to a Builder object instead of creating the objects directly.

A class (the same construction process) can delegate to different Builder objects to create different representations of a complex object.


# Advantages of Builder Pattern

* The parameters to the constructor are reduced and are provided in highly readable method calls.
* Builder design pattern also helps in minimizing the number of parameters in constructor and thus there is no need to pass in null for optional parameters to the constructor.
* Object is always instantiated in a complete state
* Immutable objects can be build without much complex logic in object building process.

# Disadvantages of Builder Pattern

* The number of lines of code increase at least to double in builder pattern, but the effort pays off in terms of design flexibility and much more readable code.
* Requires creating a separate ConcreteBuilder for each different type of Product.

<br/>

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Builder%20Pattern/BuilderDesign.png"/>
</p>

<br/>

#### Builder
This is an interface which is used to define all the steps required to create a product.

#### ConcreteBuilder
This is a class which implements the Builder interface to create a complex product.

#### Product
This is a class which defines the parts of the complex object which are to be generated by the Builder Pattern.

#### Director
This is a class that is used to construct an object using the Builder interface.
