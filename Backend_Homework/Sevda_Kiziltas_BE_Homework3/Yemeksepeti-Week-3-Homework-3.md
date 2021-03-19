
# Yemeksepeti Bootcamp Week-3-Homework-3
This article was prepared by Yemeksepeti week 3 homework. Basic c # language programing concepts are explained.

## Value types and Referance types

A Value Type holds the data within its own memory allocation and a Reference Type contains a pointer to another memory location that holds the real data. Reference Type variables are stored in the **heap** while Value Type variables are stored in the **stack**.

**Value Type**
A Value Type stores its contents in memory allocated on the stack. When you created a Value Type, a single space in memory is allocated to store the value and that variable directly holds a value. If you assign it to another variable, the value is copied directly and both variables work independently. Predefined datatypes, structures, enums are also value types, and work in the same way. Value types can be created at compile time and Stored in stack memory, because of this, Garbage collector can't access the stack.

    int x = 10;

Here the value 10 is stored in an area of memory called the stack.

**Reference Type**

Reference Types are used by a reference which holds a reference (address) to the object but not the object itself. Because reference types represent the address of the variable rather than the data itself, assigning a reference variable to another doesn't copy the data. Instead it creates a second copy of the reference, which refers to the same location of the heap as the original value. Reference Type variables are stored in a different area of memory called the heap. This means that when a reference type variable is no longer used, it can be marked for garbage collection. Examples of reference types are Classes, Objects, Arrays, Indexers, Interfaces etc.

`int[] iArray = new int[20];`

In the above code the space required for the 20 integers that make up the array is allocated on the heap.

**Stack and Heap**
Stack is used for static memory allocation and Heap for dynamic memory allocation, both stored in the computer's RAM .

Variables allocated on the stack are stored directly to the memory and access to this memory is very fast, and it's allocation is dealt with when the program is compiled. When a function or a method calls another function which in turns calls another function etc., the execution of all those functions remains suspended until the very last function returns its value. The stack is always reserved in a LIFO order, the most recently reserved block is always the next block to be freed. This makes it really simple to keep track of the stack, freeing a block from the stack is nothing more than adjusting one pointer.

Variables allocated on the heap have their memory allocated at run time and accessing this memory is a bit slower, but the heap size is only limited by the size of virtual memory . Element of the heap have no dependencies with each other and can always be accessed randomly at any time. You can allocate a block at any time and free it at any time. This makes it much more complex to keep track of which parts of the heap are allocated or free at any given time.

## Nullable types

C# provides a special data types, the  **nullable**  types, to which you can assign normal range of values as well as null values.

For example, you can store any value from -2,147,483,648 to 2,147,483,647 or null in a Nullable<Int32> variable. Similarly, you can assign true, false, or null in a Nullable<bool> variable. Syntax for declaring a  **nullable**  type is as follows 

`Nullable<data_type>  variable_name = null;`

Or you can also use a shortcut which includes  **?**  operator with the data type.

`datatype? variable_name = null;`

 

## Structs

In C#, a struct is a value type data type. It helps you to make a single variable hold related data of various data types. The  **struct**  keyword is used for creating a structure.

Structures are used to represent a record. To define a structure, you must use the struct statement. The struct statement defines a new data type, with more than one member for your program.

**Differences Between Classes and Structures**

Technically speaking, structs and classes are almost equivalent, still there are many differences. The major difference like class provides the flexibility of combining data and methods (functions ) and it provides the re-usability called inheritance. Struct should typically be used for grouping data. The technical difference comes down to subtle issues about default visibility of members. Here you can see some of the Difference between Class and Structure.

Class is pass-by-reference and Struct is pass-by-copy, it means that, Class is a reference type and its object is created on the heap memory where as structure is a value type and its object is created on the stack memory.
Class can create a subclass that will inherit parent's properties and methods, whereas Structure does not support the inheritance.
A class has all members private by default. A struct is a class where members are public by default.

## Operators

**Ternary Operator**

In c#, **Ternary Operator (?:)** is a decision-making operator and it is a substitute of if…else statement in c# programming language. The Ternary operator will help you to execute the statements based on the defined conditions using the decision-making operator (**?:**).
In c#, the Ternary Operator will always work with  **3**  operands. Following is the syntax of defining a Ternary Operator in c# programming language.

`condition_expression ? first_expression : second_expression;`


## Indexer

An **indexer** allows an object to be indexed such as an array. When you define an indexer for a class, this class behaves similar to a **virtual array**. You can then access the instance of this class using the array access operator ([ ]).
```c#
    element-type this[int index] {
      // The get accessor.
      get {
      // return the value specified by indexset
      }
      // The set accessor.
      set{
      // set the value specified by index
      }}
   ```
  Declaration of behavior of an indexer is to some extent similar to a property. similar to the properties, you use  **get**  and  **set**  accessors for defining an indexer. However, properties return or set a specific data member, whereas indexers returns or sets a particular value from the object instance. In other words, it breaks the instance data into smaller parts and indexes each part, gets or sets each part.

Defining a property involves providing a property name. Indexers are not defined with names, but with the  **this**  keyword, which refers to the object instance. 


# Try-Catch-Finally Block


C# exception is a response to an exceptional circumstance that arises while a program is running, such as an attempt to divide by zero.

C# exception handling is performed using the following keywords −

-   **try**  − A try block identifies a block of code for which particular exceptions is activated. It is followed by one or more catch blocks.
    
-   **catch**  − A program catches an exception with an exception handler at the place in a program where you want to handle the problem. The catch keyword indicates the catching of an exception.
    
-   **finally**  − The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown. For example, if you open a file, it must be closed whether an exception is raised or not. The finally block generally used for cleaning-up code e.g., disposing of unmanaged objects.
	> The try..catch..finally block in .NET allows developers to handle runtime exceptions.
	

	> Multiple `finally` blocks are not allowed. Also, the `finally` block cannot have the return, continue, or break keywords. It doesn't let control to leave the `finally` block.

## Event 

**Events**  are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as system generated notifications. Applications need to respond to events when they occur. For example, interrupts. Events are used for inter-process communication.

**Using Delegates with Events**

The events are declared and raised in a class and associated with the event handlers using delegates within the same class or some other class. The class containing the event is used to publish the event. This is called the  **publisher**  class. Some other class that accepts this event is called the  **subscriber** class. Events use the  **publisher-subscriber**  model.

A  **publisher**  is an object that contains the definition of the event and the delegate. The event-delegate association is also defined in this object. A publisher class object invokes the event and it is notified to other objects.

A  **subscriber**  is an object that accepts the event and provides an event handler. The delegate in the publisher class invokes the method (event handler) of the subscriber class.

**Declaring Events**

To declare an event inside a class, first of all, you must declare a delegate type for the even as:

`public delegate string BoilerLogHandler(string str);`

then, declare the event using the  **event**  keyword 
```c#
    event BoilerLogHandler BoilerEventLog;
 ```
    
The preceding code defines a delegate named  _BoilerLogHandler_  and an event named  _BoilerEventLog_, which invokes the delegate when it is raised.
```c#
using  System;  
namespace  SampleApp {  
	public  delegate  string  MyDel(string str);
	  
	class  EventProgram  {
		event  MyDel  MyEvent;
		public  EventProgram()  {
		    this.MyEvent  +=  new  MyDel(this.WelcomeUser);
	    }  
	    public  string  WelcomeUser(string username)  {
		    return  "Welcome "  + username;       			   			    
	    }  
	    static  void  Main(string[] args)  {  
		    EventProgram obj1 =  new  EventProgram();								    
            string result = obj1.MyEvent("Tutorials Point");  
            Console.WriteLine(result);  }  }  }
```
When the above code is compiled and executed, it produces the following result 

> Welcome Tutorials Point


## Delegate

A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. Delegates in C# are similar to the  function pointer in C/C++. It provides a way which tells which method is to be called when an event is triggered.  
For example, if you click an  _Button_  on a form (Windows Form application), the program would call a specific method. In simple words, it is a type that represents references to methods with a particular parameter list and return type and then calls the method in a program for execution when it is needed.

**Important Points About Delegates:**

-   Provides a good way to encapsulate the methods.
-   Delegates are the library class in System namespace.
-   These are the type-safe pointer of any method.
-   Delegates are mainly used in implementing the call-back methods and events.
-   Delegates can be chained together as two or more methods can be called on a single event.
-   It doesn’t care about the class of the object that it references.
-   Delegates can also be used in “anonymous methods” invocation.
-   Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts. Sometimes, these features together are known as anonymous functions.

#### Declaration of Delegates

Delegate type can be declared using the  **delegate**  keyword. Once a delegate is declared, delegate instance will refer and call those methods whose return type and parameter-list matches with the delegate declaration.

**Syntax:**

    <modifier> delegate <return type> <delegate-name> <parameter list>

## Utility Function

Utility Class, also known as Helper class, is a class, which contains just static methods, it is stateless and cannot be instantiated. It contains a bunch of related methods, so they can be reused across the application. As an example consider Apache StringUtils, CollectionUtils or java.lang.Math.

**Syntax:**

    public  static  class  Utility


> [Click here for more information](https://docs.microsoft.com/en-us/previous-versions/windows/embedded/ee437010%28v=msdn.10%29?redirectedfrom=MSDN)

## Generic Class

Generics in C# is its most powerful feature. It allows you to define the type-safe data structures. This out-turn in a remarkable performance boost and high-grade code, because it helps to reuse data processing algorithms without replicating type-specific code. Generics are similar to templates in C++ but are different in implementation and capabilities. Generics introduces the concept of type parameters, because of which it is possible to create methods and classes that defers the framing of data type until the class or method is declared and is instantiated by client code. Generic types perform better than normal system types because they reduce the need for boxing, unboxing, and type casting the variables or objects.  
Parameter types are specified in generic class creation.

**Syntax:**

     public  class TestClass<T> { }

**Features of Generics**

Generics is a technique that improves your programs in many ways such as:

-   It helps you in code reuse, performance and type safety.
-   You can create your own generic classes, methods, interfaces and delegates.
-   You can create generic collection classes. The .NET framework class library contains many new generic collection classes in System.Collections.Generic namespace.
-   You can get information on the types used in generic data type at run-time.

**Advantages of Generics**

-   **Reusability:** You can use a single generic type definition for multiple purposes in the same code without any alterations. For example, you can create a generic method to add two numbers. This method can be used to add two integers as well as two floats without any modification in the code.
-   **Type Safety:** Generic data types provide better type safety, especially in the case of collections. When using generics you need to define the type of objects to be passed to a collection. This helps the compiler to ensure that only those object types that are defined in the definition can be passed to the collection.
-   **Performance:** Generic types provide better performance as compared to normal system types because they reduce the need for boxing, unboxing, and typecasting of variables or objects.


##  Predicate Delegate

`Predicate` is the delegate like Func and Action delegates. It represents a method containing a set of criteria and checks whether the passed parameter meets those criteria. A predicate delegate methods must take one input parameter and return a boolean - true or false.
**Syntax:**

     public  delegate  bool  Predicate<in T>(T obj);


>Same as other delegate types, `Predicate` can also be used with any method, anonymous method, or lambda expression.

## Partial Classes

A partial class is a special type of class where a single class can be split into multiple .cs file and while compilation, all the functionalities of same partial classes written in different .cs files will be merged and then compile it.  
  
It provides you with functionality where you can split your class into different files based on the requirement and usability.  
  
In short, partial class in a way of writing a single class into multiple .cs files and these files will be combined when the application is compiled.  
  
A partial class is created by using a partial keyword. This keyword is also useful to split the functionality of methods, interfaces, or structure into multiple files.

**Requirements of Partial modifier**

A partial modifier can be added to a class or an interface or a struct.
Every part of the partial class definition should be in the same assembly and namespace, but we can use different source file name.
All the parts must have the same accessibility for example public or private, etc.
If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
The partial modifier can only appear immediately before the keywords class, struct, or interface.
Nested partial types are allowed.
Different parts can have different base types like implementing different interfaces and the final class will inherit all the base types.

**Advantages of Partial class**

With the concept of partial classes, we can better the code structure like by separating business logic and UI implementation within the same class.
Can avoid conflicts if multiple developers working on the same class or interface or struct.
When we working with automatically generated source, code can be added to the class without having to recreate the source file. 

## Var Keyword
Var data type was introduced in C# 3.0. Var is used to declare implicitly typed local variable means it tells the compiler to figure out the type of the variable at compilation time. A var variable must be initialized at the time of declaration.
> **Note:** While creating implicitly-typed local variables we need to make sure that the variable is declared and initialized in the same statement otherwise we will get a compile-time error and the variable cannot be initialized with a **null** value.

## Dynamic type
In C# 4.0, a new type is introduced that is known as a dynamic type. It is used to avoid the compile-time type checking. The compiler does not check the type of the dynamic type variable at compile time, instead of this, the compiler gets the type at the run time. The dynamic type variable is created using dynamic keyword.

**Important Points:**

-   In most of the cases, the dynamic type behaves like object types.
-   You can get the actual type of the dynamic variable at runtime by using  _GetType()_  method. The dynamic type changes its type at the run time based on the value present on the right-hand side. As shown in the below example.


## Referances
https://www.tutorialsteacher.com/
https://www.geeksforgeeks.org/
https://www.c-sharpcorner.com/technologies/csharp-programming
https://www.pluralsight.com/
http://net-informations.com/
https://www.tutlane.com/
https://www.tutorialspoint.com/
https://docs.microsoft.com/
https://www.vojtechruzicka.com/
https://agrawalsuneet.github.io/blogs/
