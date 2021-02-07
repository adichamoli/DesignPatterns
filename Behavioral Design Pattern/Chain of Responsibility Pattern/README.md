# Chain of Responsibility Pattern

<b>Chain of Responsibility</b> is behavioral design pattern that allows passing request along the chain of potential handlers until one of them handles request.

The pattern allows multiple objects to handle the request without coupling sender class to the concrete classes of the receivers. The chain can be composed dynamically at runtime with any handler that follows a standard handler interface.

The chain of responsibility pattern is used to process a list or chain of various types of request and each of them may be handled by a different handler. This pattern decouples sender and receiver of a request based on the type of request.

In this pattern, normally each receiver (handler) contains a reference to another receiver. If one receiver cannot handle the request then it passes the same to the next receiver and so on.

# Summary

* The Chain of Responsibility pattern works with a list of Handler objects that have limitations on the nature of the requests they can deal with. If a handler object cannot handle a request, it passes it on to the next handler object in the chain. At the end of the chain, there can be either default or exceptional behavior.
* The pattern chains the receiving objects together, and then passes any request messages from object to object until it reaches an object capable of handling the message.
* Chain of Responsibility simplifies object interconnections. Instead of senders and receivers maintaining references to all candidate receivers, each sender keeps a single reference to the head of the chain, and each receiver keeps a single reference to its immediate successor in the chain.
* Sometimes, the request object has to go through the chain objects mandatorily, like Http pipeline.
* Sometimes only through few handlers.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Chain%20of%20Responsibility%20Pattern/chain.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Handler   (Approver)</b>
  * Defines an interface for handling the requests
  * (optional) implements the successor link
* <b>ConcreteHandler   (Director, VicePresident, President)</b>
  * Handles requests it is responsible for
  * Can access its successor
  * If the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
* <b>Client   (ChainApp)</b>
  * Initiates the request to a ConcreteHandler object on the chain

# Where and When Chain of Responsibility pattern is applicable :

* When you want to decouple a request’s sender and receiver
* Multiple objects, determined at runtime, are candidates to handle a request
* When you don’t want to specify handlers explicitly in your code
* When you want to issue a request to one of several objects without specifying the receiver explicitly.

# Advantages of Chain of Responsibility Design Pattern

* To reduce the coupling degree. Decoupling it will request the sender and receiver.
* Simplified object. The object does not need to know the chain structure.
* Enhance flexibility of object assigned duties. By changing the members within the chain or change their order, allow dynamic adding or deleting responsibility.
* Increase the request processing new class of very convenient.

# DisAdvantages of Chain of Responsibility Design Pattern

* The request must be received not guarantee.
* The performance of the system will be affected, but also in the code debugging is not easy may cause cycle call.
* It may not be easy to observe the characteristics of operation, due to debug.
