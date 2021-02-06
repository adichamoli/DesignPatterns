# Composite Pattern

Composite pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns in .Net. Composite Pattern is used to arrange structured hierarchies.
Composite is a structural design pattern that allows composing objects into a tree-like structure and work with the it as if it was a singular object.

Composite became a pretty popular solution for the most problems that require building a tree structure. Composite’s great feature is the ability to run methods recursively over the whole tree structure and sum up the results.

Composite pattern is used to separate abstraction from its implementation so that both can be modified independently.

Composite pattern is used when we need to treat a group of objects and a single object in the same way. Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchies.

This pattern creates a class contains a group of its own objects. This class provides ways to modify its group of the same objects.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Composite%20Pattern/composite.png"/>
</p>

The classes, interfaces, and objects in the above UML class diagram are as follows:

* <b>Component   (DrawingElement)</b>
  * Declares the interface for objects in the composition.
  * Implements default behavior for the interface common to all classes, as appropriate.
  * Declares an interface for accessing and managing its child components.
  * (Optional) Defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.

* <b>Leaf   (PrimitiveElement)</b>
  * Represents leaf objects in the composition. A leaf has no children.
  * Defines behavior for primitive objects in the composition.

* <b>Composite   (CompositeElement)</b>
  * Defines behavior for components having children.
  * Stores child components.
  * Implements child-related operations in the Component interface.

* <b>Client  (CompositeApp)</b>
  * Manipulates objects in the composition through the Component interface.
  
# Advantages of Composite Design Pattern

Composite Pattern should be used when clients need to ignore the difference between compositions of objects and individual objects. If programmers find that they are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice, it is less complex in this situation to treat primitives and composites as homogeneous.

* Less number of objects reduces the memory usage, and it manages to keep us away from errors related to memory.
* Although creating an object in Java is really fast, we can still reduce the execution time of our program by sharing objects.

# Disadvantages of Composite Design Pattern

* Composite Design Pattern makes it harder to restrict the type of components of a composite. So it should not be used when you don’t want to represent a full or partial hierarchy of objects.
* Composite Design Pattern can make the design overly general. It makes harder to restrict the components of a composite. Sometimes you want a composite to have only certain components. With Composite, you can’t rely on the type system to enforce those constraints for you. Instead you’ll have to use run-time checks.
