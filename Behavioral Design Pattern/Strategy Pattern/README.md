# Strategy Pattern

<b>Strategy</b> is a behavioral design pattern that turns a set of behaviors into objects and makes them interchangeable inside original context object.

The original object, called context, holds a reference to a strategy object and delegates it executing the behavior. In order to change the way the context performs its work, other objects may replace the currently linked strategy object with another one.

# Intent

The intent of the Strategy design pattern helps us to divide an algorithm from a host class and then move it to another class. By doing so the client can choose which algorithm will be performed in runtime from a set of algorithms that were implemented earlier.

# Motivation & Applicability

There are common situations when classes differ only in their behaviour. For this case, it is a good idea to isolate the algorithms in separate classes in order to have the ability to select different algorithms at runtime. The Strategy pattern allows us to provide an alternative to subclassing the Context class to get a variety of algorithms or behaviours, eliminates large conditional statements and provides a choice of implementations for the same behaviour.
 
Use the Strategy pattern whenever:
* Many related classes differ only in their behaviour
* You need different variants of an algorithm
* An algorithm uses data that clients shouldn't know about. Use the Strategy pattern to avoid exposing complex, algorithm-specific data structures.
* A class defines many behaviors, and these appear as multiple conditional statements in its operations. Instead of many conditionals, move related conditional branches into their own Strategy class.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Strategy%20Pattern/strategy.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* Strategy  (SortStrategy)
  * Declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a ConcreteStrategy
* ConcreteStrategy  (QuickSort, ShellSort, MergeSort)
  * Implements the algorithm using the Strategy interface
* Context  (SortedList)
  * Is configured with a ConcreteStrategy object
  * Maintains a reference to a Strategy object
  * May define an interface that lets Strategy access its data.
  
# Advantages of Strategy Pattern

* A family of algorithms can be defined as a class hierarchy and can be used interchangeably to alter application behavior without changing its architecture.
* By encapsulating the algorithm separately, new algorithms complying with the same interface can be easily introduced.
* The application can switch strategies at run-time.
* Strategy enables the clients to choose the required algorithm, without using a “switch” statement or a series of “if-else” statements.
* Data structures used for implementing the algorithm are completely encapsulated in Strategy classes. Therefore, the implementation of an algorithm can be changed without affecting the Context class.

# Disadvantages of Strategy Pattern

* The application must be aware of all the strategies to select the right one for the right situation.
* Context and the Strategy classes normally communicate through the interface specified by the abstract Strategy base class. Strategy base class must expose interface for all the required behaviours, which some concrete Strategy classes might not implement.
* In most cases, the application configures the Context with the required Strategy object. Therefore, the application needs to create and maintain two objects in place of one.

# When to use it?

* There are multiple strategies for a given problem and the selection criteria of a strategy are defined as a run-time.
* Many related classes only differ in their behaviors.
* The strategies use the data to which the client has no access.
