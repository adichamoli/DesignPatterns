# Interpreter Pattern

Interpreter Design pattern evaluates/ interprets the instructions written in a language grammar or notations. This pattern involves implementing an expression interface which tells to interpret a particular context. This pattern is used in the compilers or parsers or Macro expansions.

This pattern is commonly used in the menu systems of many applications such as Editor, IDE etc.

The Interpreter Design Pattern Provides a way to evaluate language grammar or expression. This pattern is used in SQL parsing, symbol processing engine, etc.

Let us understand the interpreter design pattern with an example. Please have a look at the following image. On the left-hand side, you can see the Context. The Context is nothing but the value that we want to interpret. Here, the context value is the current date. On the right-hand side, you can see the Date expression or you can say the grammar. We have different types of date expression such as (MM-DD-YYYY, DD-MM-YYYY, YYYY-MM-DD, and DD-YYYY).

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Interpreter%20Pattern/word-image-45.png"/>
</p>

Suppose, you want the date in MM-DD-YYYY format then what you need to do is, you need to pass the Context value and the Date Expression you want (i.e. MM-DD-YYYY) to the interpreter. What the interpreter will do is, it will convert the context value into the date expression format you passed to it. So, basically the interpreter contains the logic or grammar to convert the context object into a specific readable format.

# UML class diagram

<p align="center">
  <img src="https://github.com/adichamoli/DesignPatterns/blob/main/Behavioral%20Design%20Pattern/Interpreter%20Pattern/interpreter.gif"/>
</p>

# Participants
The classes and objects participating in this pattern are:

* <b>AbstractExpression  (Expression)</b>
  * Declares an interface for executing an operation
* <b>TerminalExpression  (ThousandExpression, HundredExpression, TenExpression, OneExpression)</b>
  * Implements an Interpret operation associated with terminal symbols in the grammar.
  * An instance is required for every terminal symbol in the sentence.
* <b>NonterminalExpression  ( not used )</b>
  * One such class is required for every rule R ::= R1R2...Rn in the grammar
  * Maintains instance variables of type AbstractExpression for each of the symbols R1 through Rn.
  * Implements an Interpret operation for nonterminal symbols in the grammar. Interpret typically calls itself recursively on the variables representing R1 through Rn.
* <b>Context  (Context)</b>
  * Contains information that is global to the interpreter
* <b>Client  (InterpreterApp)</b>
  * Builds (or is given) an abstract syntax tree representing a particular sentence in the language that the grammar defines. The abstract syntax tree is assembled from  instances of the NonterminalExpression and TerminalExpression classes
  * Invokes the Interpret operation
  
# Advantages of Interpreter Pattern

* It’s easy to change and extend the grammar. Because the pattern uses classes to represent grammar rules, you can use inheritance to change or extend the grammar. Existing expressions can be modified incrementally, and new expressions can be defined as variations on old ones.
* Implementing the grammar is easy, too. Classes defining nodes in the abstract syntax tree have similar implementations. These classes are easy to write, and often their generation can be automated with a compiler or parser generator.

# Disdvantages of Interpreter Pattern

* Complex grammars are hard to maintain. The Interpreter pattern defines at least one class for every rule in the grammar. Hence grammars containing many rules can be hard to manage and maintain.
