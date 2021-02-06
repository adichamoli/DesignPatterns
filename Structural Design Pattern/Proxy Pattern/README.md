# Proxy Pattern

<b>Proxy</b> is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.

The proxy object has the same interface as a service, which makes it interchangeable with a real object when passed to a client.

Proxy Design pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns in .Net. The proxy design pattern is used to provide a surrogate object, which references to other objects.

The proxy design pattern is used to provide a surrogate object, which references to other objects.

The proxy pattern involves a class, called proxy class, which represents the functionality of another class.

<br/>
A Proxy Design Pattern has various variations that include:

<b>Virtual Proxy</b> : This type of proxy is created to manage creation of an instance of resources that are very expensive in nature, in other words that consume too much memory or take too much time for accessing the main resource or any other kind of heavy operation.
 
<b>Remote proxy</b> : This is similar to the concept of the use of web services or WCF services where the client must access the remote resource on another network, using the proxy class instance.
 
<b>Protection proxy</b> : As we explained above, we can create a secure proxy of a resource by adding some kind of authentication for the client code to provide. This is known as a Protection Proxy since the resources are protected by the proxy and the client code must pass the authentication process.
 
<b>Smart Proxy</b> : This kind of proxy is used to add some kind of functionality to manage the resources in an efficient manner. For example, in our example, we have added the logic that fetches the resource, only if it is required by the client code. In this way, you can add some kind of singleton pattern so that only one instance of the subject is created or so on.

<br/><br/>

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Structural%20Design%20Pattern/Proxy%20Pattern/proxy.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>Proxy   (MathProxy)</b>
  * Maintains a reference that lets the proxy access the real subject. Proxy may refer to a Subject if the RealSubject and Subject interfaces are the same.
  * Provides an interface identical to Subject's so that a proxy can be substituted for for the real subject.
  * Controls access to the real subject and may be responsible for creating and deleting it.
  * Other responsibilites depend on the kind of proxy:
    * Remote proxies are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space.
    * Virtual proxies may cache additional information about the real subject so that they can postpone accessing it. For example, the ImageProxy from the Motivation caches the real images's extent.
    * Protection proxies check that the caller has the access permissions required to perform a request.

* <b>Subject   (IMath)</b>
  * Defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.

* <b>RealSubject   (Math)</b>
  * defines the real object that the proxy represents.  

# Advantages of Proxy pattern

* One of the advantages of Proxy pattern is security.
* This pattern avoids duplication of objects which might be huge size and memory intensive. This in turn increases the performance of the application.
* The remote proxy also ensures about security by installing the local code proxy (stub) in the client machine and then accessing the server with help of the remote code.

# Disadvantages of Proxy pattern

* This pattern introduces another layer of abstraction which sometimes may be an issue if the RealSubject code is accessed by some of the clients directly and some of them might access the Proxy classes. This might cause disparate behaviour.

# Interesting points:

* There are few differences between the related patterns. Like Adapter pattern gives a different interface to its subject, while Proxy patterns provides the same interface from the original object but the decorator provides an enhanced interface. Decorator pattern adds additional behaviour at runtime.

# When to use it?
* Objects need to be created on demand means when their operations are requested.
* Access control for the original object is required.
* Allow accessing a remote object by using a local object(it will refer to a remote object).
