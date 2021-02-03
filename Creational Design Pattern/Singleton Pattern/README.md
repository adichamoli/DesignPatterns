# Singleton Pattern

* Singleton pattern restricts the instantiation of a class and ensures that only one instance of the class exists in the java virtual machine.
* The singleton class must provide a global access point to get the instance of the class.
* Singleton pattern is used for logging, drivers objects, caching and thread pool.
* Singleton design pattern is also used in other design patterns like Abstract Factory, Builder, Prototype, Facade etc.
* Singleton design pattern is used in core java classes also, for example java.lang.Runtime, java.awt.Desktop.

<br/><br/>

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Singleton%20Pattern/SingletonPattern.png"/>
</p>


# Advantages of Singleton Design Pattern

The advantages of a Singleton Pattern are:
* Singleton pattern can be implemented interfaces.
* It can be also inherited from other classes.
* It can be lazy-loaded.
* It has Static Initialization.
* It can be extended into a factory pattern.
* It helps to hide dependencies.
* It provides a single point of access to a particular instance, so it is easy to maintain.

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Creational%20Design%20Pattern/Singleton%20Pattern/singleton-comic.png"/>
</p>

# Disadvantages of Singleton Design Pattern
 
The disadvantages of a Singleton Pattern are:
* Unit testing is more difficult (because it introduces a global state into an application).
* This pattern reduces the potential for parallelism within a program because to access the singleton in a multi-threaded system, an object must be serialized (by locking).

# Singleton class vs. Static methods
 
The following compares Singleton class vs. Static methods:
1. A Static Class cannot be extended whereas a singleton class can be extended.
2. A Static Class can still have instances (unwanted instances) whereas a singleton class prevents it.
3. A Static Class cannot be initialized with a STATE (parameter), whereas a singleton class can be.
4. A Static class is loaded automatically by the CLR when the program or namespace containing the class is loaded.

# Types of Implemenatation

1. Eager Initialization
2. Thread Safe Singleton
3. Thread Safe Singleton using Double-Check Locking
4. Thread Safe Singleton without using locks and no lazy instantiation
5. Fully lazy instantiation
6. Using .NET 4's Lazy Type
7. Enum Singleton
8. Serialization and Singleton

## Eager Initialization

In eager initialization, the instance of Singleton Class is created at the time of class loading, this is the easiest method to create a singleton 
class but it has a drawback that instance is created even though client application might not be using it.

    public sealed class EagerInitializedSingleton
    {
        private EagerInitializedSingleton() 
        {
            Console.WriteLine("Hello Singleton");
        }

        private static EagerInitializedSingleton instance = new EagerInitializedSingleton();

        public static EagerInitializedSingleton getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EagerInitializedSingleton();
                }
                return instance;
            } 
        }
    }
    
If your singleton class is not using a lot of resources, this is the approach to use. But in most of the scenarios, Singleton classes are created for 
resources such as File System, Database connections, etc. We should avoid the instantiation until unless client calls the getInstance method. 
Also, this method doesn’t provide any options for exception handling.

# Thread Safe Singleton

Explanation of the following code:
1. This implementation is thread-safe.
2. In the following code, the thread is locked on a shared object and checks whether an instance has been created or not.
3. This takes care of the memory barrier issue and ensures that only one thread will create an instance.
4. For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate to false.
5. The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.

       public sealed class ThreadSafeSingleton
       {
           ThreadSafeSingleton()
           {
               Console.WriteLine("Hello Singleton");
           }

           private static readonly object padlock = new object();
           private static ThreadSafeSingleton instance = null;

           public static ThreadSafeSingleton getInstance
           {
               get
               {
                   lock(padlock)
                   {
                       if (instance == null)
                       {
                           instance = new ThreadSafeSingleton();
                       }
                       return instance;
                   }
               }
           }
       }

# Thread Safe Singleton using Double Check Locking

Explanation of the following code:
In the following code, the thread is locked on a shared object and checks whether an instance has been created or not with double checking.

    public sealed class ThreadSafeSingleton
    {
        ThreadSafeSingleton()
        {
            Console.WriteLine("Hello Singleton");
        }

        private static readonly object padlock = new object();
        private static ThreadSafeSingleton instance = null;

        public static ThreadSafeSingleton getInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeSingleton();
                        }
                    }
                }
                
                return instance;
            }
        }
    }

# Thread Safe Singleton without using locks and no lazy instantiation
 
Explanation of the following code:
1. The preceding implementation looks like very simple code.
2. This type of implementation has a static constructor, so it executes only once per Application Domain.
3. It is not as lazy as the other implementation.

       public sealed class ThreadSafeSingleton
       {
           private static ThreadSafeSingleton instance = new ThreadSafeSingleton();
        
           static ThreadSafeSingleton()
           {
               Console.WriteLine("Hello Singleton Static");
           }

           private ThreadSafeSingleton()
           {
               Console.WriteLine("Hello Singleton");
           }

           public static ThreadSafeSingleton getInstance
           {
               get
               {
                   return instance;
               }
           }
       }

# Fully lazy instantiation

Explanation of the following code:
1. Here, instantiation is triggered by the first reference to the static member of the nested class, that only occurs in Instance.
2. This means the implementation is fully lazy, but has all the performance benefits of the previous ones.
3. Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal here.
4. That doesn't raise any other problems, though, as the class itself is private.
5. The code is more complicated in order to make the instantiation lazy.

       public sealed class LazyInitializedSingleton
       {
           private LazyInitializedSingleton()
           {
                Console.WriteLine("Hello Singleton");
           }

           public static LazyInitializedSingleton getInstance
           {
               get
               {             
                   return Nested.instance;
               }
           }

           private class Nested
           {
               static Nested()
               {
                   Console.WriteLine("Hello Singleton Nested");
               }

               internal static readonly LazyInitializedSingleton instance = new LazyInitializedSingleton();
           }
       }
       
# Using .NET 4's Lazy Type

Explanation of the following code:
1. If you're using .NET 4 (or higher) then you can use the System.Lazy<T> type to make the laziness really simple.
2. All you need to do is pass a delegate to the constructor that calls the Singleton constructor, which is done most easily with a lambda expression.
3. It also allows you to check whether or not the instance has been created with the IsValueCreated property.
 
       public sealed class LazyInitializedSingleton
       {
           private static readonly Lazy<LazyInitializedSingleton> lazy =
                                   new Lazy<LazyInitializedSingleton>
                                   (() => new LazyInitializedSingleton());

           public static LazyInitializedSingleton getInstance 
           { 
               get 
               { 
                   return lazy.Value; 
               } 
           }

           private LazyInitializedSingleton()
           {
               Console.WriteLine("Hello Singleton");
           }
       }
