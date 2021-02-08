# Memento Pattern

<b>Memento</b> is a behavioral design pattern that allows making snapshots of an object’s state and restoring it in future.

The Memento doesn’t compromise the internal structure of the object it works with, as well as data kept inside the snapshots.


<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Memento%20Pattern/memento.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Memento  (Memento)</b>
  * Stores internal state of the Originator object. The memento may store as much or as little of the originator's internal state as necessary at its originator's discretion.
  * Protect against access by objects of other than the originator. Mementos have effectively two interfaces. Caretaker sees a narrow interface to the Memento -- it can only pass the memento to the other objects. Originator, in contrast, sees a wide interface, one that lets it access all the data necessary to restore itself to its previous state. Ideally, only the originator that produces the memento would be permitted to access the memento's internal state.

* <b>Originator  (SalesProspect)</b>
  * Creates a memento containing a snapshot of its current internal state.
  * Uses the memento to restore its internal state

* <b>Caretaker  (Caretaker)</b>
  * Is responsible for the memento's safekeeping
  * Never operates on or examines the contents of a memento.
  
# Advantages of Memento Pattern

We can use Serialization to achieve memento pattern implementation that is more generic rather than Memento pattern where every object needs to have it’s own Memento class implementation.

# Disadvantages of Memento Pattern

If Originator object is very huge then Memento object size will also be huge and use a lot of memory.

# When to use it?

* The state of an object needs to be saved and restored at a later time.
* The state of an object cannot be exposed directly by using an interface without exposing implementation.
