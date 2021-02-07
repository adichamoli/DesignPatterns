# Command Pattern

<b>Command</b> is behavioral design pattern that converts requests or simple operations into objects.

The conversion allows deferred or remote execution of commands, storing command history, etc.

The Command Pattern falls under the category of Behavioural Design Patterns. If you have quite amount of experience in C# particularly WPF, you must have used DelegateCommand or Routed Command or RelayCommands. This internally uses the Command Pattern only. The Command Pattern can be used in any of the projects and we will quicky understand what is it and how to use it in our project.

The Command Pattern encapsulates a request as an object and gives it a known public interface. A request or action is mapped and stored as an object. The Invoker will be ultimately responsible for processing the request. This clearly decouples the request from the invoker. This is more suited for scenarios where we implement Redo, Copy, Paste and Undo operations where the action is stored as an object. We generally use Menu or Shortcut key gestures for any of the preceding actions to be executed.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Command%20Pattern/command.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Command  (Command)</b>
  * Declares an interface for executing an operation
* <b>ConcreteCommand  (CalculatorCommand)</b>
  * Defines a binding between a Receiver object and an action
  * Implements Execute by invoking the corresponding operation(s) on Receiver
* <b>Client  (CommandApp)</b>
  * Creates a ConcreteCommand object and sets its receiver
* <b>Invoker  (User)</b>
  * Asks the command to carry out the request
* <b>Receiver  (Calculator)</b>
  * Knows how to perform the operations associated with carrying out the request.
  
# Advantages of Command Pattern

* Makes our code extensible as we can add new commands without changing existing code.
* Reduces coupling the invoker and receiver of a command.

# Disadvantages of Command Pattern

* Increase in the number of classes for each individual command
