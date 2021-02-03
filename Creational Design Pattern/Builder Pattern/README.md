# Builder Design Pattern

Builder design pattern falls under the category of "Creational" design patterns. This pattern is used to build a complex object by using a step by step approach.

GOF (Gang of Four) says:

#### *"Separate the construction of a complex object from its representation so that the same construction process can create different representations"*

So, it is used to construct a complex object step by step and the final step returns the object. Also, the process of constructing an object should be generic so that it can be used to create different representations of the same object.

# Advantages of Builder Pattern

* Code is more maintainable and readable.
* Less prone to errors as we have a method which returns the finally constructed object.

# Disadvantages of Builder Pattern

* Number of lines of code increases in builder pattern, but it makes sense as the effort pays off in terms of maintainability and readability.
