# Visitor Pattern

<b>Visitor</b> is a behavioral design pattern that allows adding new behaviors to existing class hierarchy without altering any existing code.

Visitor Design is used to create and perform new operations onto a set of objects without changing the object structure or classes. This pattern enables loose coupling and the addition of new operations without changing the existing structure.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Visitor%20Pattern/visitor.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Visitor  (Visitor)</b>
  * Declares a Visit operation for each class of ConcreteElement in the object structure. The operation's name and signature identifies the class that sends the Visit request to the visitor. That lets the visitor determine the concrete class of the element being visited. Then the visitor can access the elements directly through its particular interface
* <b>ConcreteVisitor  (IncomeVisitor, VacationVisitor)</b>
  * Implements each operation declared by Visitor. Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure. ConcreteVisitor provides the context for the algorithm and stores its local state. This state often accumulates results during the traversal of the structure.
* <b>Element  (Element)</b>
  * Defines an Accept operation that takes a visitor as an argument.
* <b>ConcreteElement  (Employee)</b>
  * Implements an Accept operation that takes a visitor as an argument
* <b>ObjectStructure  (Employees)</b>
  * Can enumerate its elements
  * May provide a high-level interface to allow the visitor to visit its elements
  * May either be a Composite (pattern) or a collection such as a list or a set
  
# Advantages of Visitor Pattern

* If the logic of operation changes, then we need to make change only in the visitor implementation rather than doing it in all the item classes.
* Adding a new item to the system is easy, it will require change only in visitor interface and implementation and existing item classes will not be affected.

# Disadvantages of Visitor Pattern

* We should know the return type of visit() methods at the time of designing otherwise we will have to change the interface and all of its implementations.
* If there are too many implementations of visitor interface, it makes it hard to extend.

# When to use it?

* An object structure has many unrelated operations to perform on it.
* An object structure cannot change but you need to perform new operations on it.
* The operations need to perform on the concrete classes of an object structure.
