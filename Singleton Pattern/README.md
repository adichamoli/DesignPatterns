# Singleton Pattern

* Singleton pattern restricts the instantiation of a class and ensures that only one instance of the class exists in the java virtual machine.
* The singleton class must provide a global access point to get the instance of the class.
* Singleton pattern is used for logging, drivers objects, caching and thread pool.
* Singleton design pattern is also used in other design patterns like Abstract Factory, Builder, Prototype, Facade etc.
* Singleton design pattern is used in core java classes also, for example java.lang.Runtime, java.awt.Desktop.

# Types of Implemenatation

1. Eager Initialization
2. Static Block Initialization
3. Lazy Initialization
4. Thread Safe Singleton
5. Bill Pugh Singleton Implementation
6. Using Reflection to destroy Singleton Pattern
7. Enum Singleton
8. Serialization and Singleton

## Eager Initialization

In eager initialization, the instance of Singleton Class is created at the time of class loading, this is the easiest method to create a singleton 
class but it has a drawback that instance is created even though client application might not be using it.

    public sealed class EagerInitializedSingleton
    {
        private static readonly EagerInitializedSingleton instance = new EagerInitializedSingleton();

        private EagerInitializedSingleton() 
        {
            Console.WriteLine("Hello Singleton");
        }

        public static EagerInitializedSingleton getInstance
        {
            get
            {
                return instance;
            } 
        }
    
If your singleton class is not using a lot of resources, this is the approach to use. But in most of the scenarios, Singleton classes are created for 
resources such as File System, Database connections, etc. We should avoid the instantiation until unless client calls the getInstance method. 
Also, this method doesn’t provide any options for exception handling.

## Static Block Initialization

Static block initialization implementation is similar to eager initialization, except that instance of class is created in the static block that provides 
option for exception handling.
