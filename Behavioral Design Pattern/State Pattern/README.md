# State Pattern

<b>State</b> is a behavioral design pattern that allows an object to change the behavior when its internal state changes.

The pattern extracts state-related behaviors into separate state classes and forces the original object to delegate the work to an instance of these classes, instead of acting on its own.

The State Pattern (also referred to as State Design Pattern) is one of the behavioral patterns. It defines a manner for controlling communication among classes or entities. It is used to change the behavior of the object when the object's internal state is changed. This pattern helps objects to change it state without changing the interface (used to access the object) or lose the current state. This change of the state of the class or object is hidden from the outer world with the use of a context (also known as wrapper object). The State Pattern can be used to implement complex decision-making algorithms represented as a flow chart or state diagram. A State Pattern can also be implement where various states exist and each state has a specific action.

This pattern is used when there are one too many relationships between objects such as if one object is modified, its dependent objects are to be notified automatically. State Design Pattern is used to alter the behavior of an object when it’s internal state changes. In this pattern, an object is created which represent various states and a context object whose behavior varies as it's state object changes.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/State%20Pattern/state.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Context  (Account)</b>
  * Defines the interface of interest to clients
  * Maintains an instance of a ConcreteState subclass that defines the current state.
* <b>State  (State)</b>
  * Defines an interface for encapsulating the behavior associated with a particular state of the Context.
* <b>Concrete State  (RedState, SilverState, GoldState)</b>
  * Each subclass implements a behavior associated with a state of Context
  
# Advantages of State Pattern

* In the State design pattern, an object's behavior is the result of the function of its state, and the behavior gets changed at runtime depending on the state. This removes the dependency on the if/else or switch/case conditional logic. For example, in the TV remote scenario, we could have also implemented the behavior by simply writing one class and method that will ask for a parameter and perform an action (switch the TV on/off) with an if/else block.
* With State pattern, the benefits of implementing polymorphic behavior are evident, and it is also easier to add states to support additional behavior.
* The State design pattern also improves Cohesion since state-specific behaviors are aggregated into the ConcreteState classes, which are placed in one location in the code.
* With the State design pattern, it is very easy to add a behavior by just adding one more ConcreteState class. State pattern thus improves the flexibility to extend the behavior of the application and overall improves code maintenance.

# Disdvantages of State Pattern

* Class Explosion: Since every state needs to be defined with the help of ConcreteState, there is a chance that we might end up writing many more classes with a small functionality. Consider the case of finite state machines—if there are many states but each state is not too different from another state, we'd still need to write them as separate ConcreteState classes. This increases the amount of code we need to write, and it becomes difficult to review the structure of a state machine.
* With the introduction of every new behavior (even though adding behavior is just adding one more ConcreteState), the Context class needs to be updated to deal with each behavior. This makes the Context behavior more brittle with every new behavior.

# When to use it?

* The behavior of an object is changed based on its state.
* Preserve flexibility in assigning requests to handlers.
* An object is becoming complex, with many conditional behaviors.
