# Bridge Pattern

Bridge design pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns in .Net. All we know, Inheritance is a way to specify different implementations of an abstraction. But in this way, implementations are tightly bound to the abstraction and cannot be modified independently. The Bridge pattern provides an alternative to inheritance when there is more than one version of abstraction.

The bridge pattern is used to separate abstraction from its implementation so that both can be modified independently.

This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class. Both types of classes can be modified without affecting to each other.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Bridge%20Pattern/bridge.png"/>
</p>

# Elements of Bridge Design Pattern

* <b>Abstraction –</b> core of the bridge design pattern and defines the crux. Contains a reference to the implementer.
* <b>Refined Abstraction –</b> Extends the abstraction takes the finer detail one level below. Hides the finer elements from implemetors.
* <b>Implementer –</b> It defines the interface for implementation classes. This interface does not need to correspond directly to the abstraction interface and can be very different. Abstraction imp provides an implementation in terms of operations provided by Implementer interface.
* <b>Concrete Implementation –</b> Implements the above implementer by providing concrete implementation.

# Advantages of Bridge Pattern

* Bridge pattern decouple an abstraction from its implementation so that the two can vary independently.
* It is used mainly for implementing platform independence feature.
* It adds one more method level redirection to achieve the objective.
* Publish abstraction interface in a separate inheritance hierarchy, and put the implementation in its own inheritance hierarchy.
* Use bridge pattern to run-time binding of the implementation.
* Use bridge pattern to map orthogonal class hierarchies
* Bridge is designed up-front to let the abstraction and the implementation vary independently.

# Disadvantages of Bridge Pattern

* Increases complexity.
* Double indirection – This will have a slight impact on performance. The abstraction needs to pass messages along to the implementator for the operation to get executed.
