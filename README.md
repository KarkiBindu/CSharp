# CSharp
Understanding C# from basics with kudvenkat Tutorial
Source : 

1. <b>Namespaces</b> :

   - A namespace is used to organize code and assists in avoiding naming clashes
   - It is a collection of types; classes, interfaces, structs, enums and delegates
   - They do not correspon to file, directory or assembly name.
   - They could be written in separate files and/or separate assemblies and still belong to the same namespace.
   - Example:</br> <i>using system;</i> system is a namespace containing various classes
   - <b><i>Aliases</i></b> can be used if the name space is long.</br>
   Example: if a class Teacher is Contained in NameSpace <i>Eductaion.School.Employee</i> then instead of using fully qalified name we can provide short name as:
   </br><i> using SchoolEmp = Eductaion.School.Employee;</i> so that we donot have to use long fullname each time
   
2. <b>Reading and Writing to Console</b> :
   - `Console.Writeline(srting);`</br>`Console.Write(string);`</br>`Console.Readline(string);`</br>`Console.Read(string);`</br> are used to read and write from console
   - Read takes input from console and write provides output to console
   - Place holders' can be provided to print variable </br>
   Example: `Console.WriteLine("The full name is: {0} {1}", firstName, lastName);` firstname and lastname are string arguments and {0} is placeholder for first name and {1} is placeholder for lastName
   
3. <b>Buit-in Types </b> :
   - Boolean : represents true or false
   - Integral : numeric values without decimal
   - Floating : numeric values with decimal
   - Decimal : numeric value with decimal
   - String : character or arrays of character
   
4. <b> Escape Sequence</b> :
   - \ is used to make quotation or \ to be readable by the program.
   - Example: 
   To provide the file location we do "C:\\\Desktop" or to print hello in quotation marks we will have to provide "\\"Hello\\""
   - <b> Verbatim Literal </b>: Verbatim literal is a string with @ symbol prefix which makes escape sequences translate as normal printable characters, to enchance readability.</br>
   Example: instead of doing "C:\\\Desktop" we can do @"C:\\Desktop" which will make the code more readable

5. <b> Common operators </b> :
   - Assignment Operator : "="
     - assigns value to a variable.
     - Example: int a = 10;
   - Arithmetic Operators : "+, -, *, /, %"
     - does mathematical calculation
     - Example int a = 10 % 4; it calculates the reminder of the division and assigns the result to a variable, in this case a is equal to 2 
   - Comparison Operators : "==, !=, >, <, >=, <="
     - Compares the value or any condition
     - Most commonly used in if, else consitional statement and it returns true or false
     - Example : </br>
     if (a == 10){ Console.WriteLine("True");}</br> else{ Console.WriteLine("False");}</br> it checks whether the value of a is 10 or not, if its true the it prints True, else it prints False
   - Conditional Operators : "&&, ||"
     - it checks logical and/or conditions
     - Example : </br>
     if (a == 10 && a > 5){ Console.WriteLine("True");}</br> else{ Console.WriteLine("False");}</br> it checks whether the value of a is 10 and greater than 5 or not, if its true the it prints True, else it prints False
   - Ternary Operators : "?:" 
      - It is a short form of if else condition and used if there is only one check condition
      - Example : </br>
      bool result = (a = 10) ? true : false; ? acts as then and : as else, statement before ? is condition checking after it is the result if the condition is true and after : is the result if the condition is false
   - Null Coalescing Operator : "??"
     - There are two types of datatypes in C#; value type and reference type
     - Refernce types can be null but value type can never be null
     - Example: int is value type and string is reference type
     - To make int type nullable add j after int : i.e intj a = 10;
     - and to make sure to provide value when it is null we do int b == a ?? 0; This convert nullable int to non-nullable int and also it provides value 0 if the value of a is null
     
6. <b> Data Conversion </b> :
   - It can be converted in two ways :
     - Implicit conversion : It is done when the conversion will not result to loss of data, or throws an exception
     - Example </br> int a = 10; </br> double j = a; It is possible because there will be no loss of data or throws an exception But 
     </br> double j = 10.05; </br> int a = j; this is not possible because while converting it 0.05 will be lost as integer value cannot hold decimal number
   - Explicit Conversion :
     - Casting :
       int a = (double)j;
     - Using Convert class:
       int a = Convert.ToDouble(j);
       
7. <b> Parse and Try Parse</b> :
   - If a string is in a string format we can use parse or try parse method for conversion.
   - Parsing tries to directly convert the string values to numerical and if it cannot then it will throw exception which will result in crashing
   - Whereas try parse first checks if the value can be converted or not, if it cannot be converted the it returns 0.
   - To avoid exception and crashing using try parse method is safe
   - Example </br> string num1 = "50"; </br> string num2 = "50ab"; </br> we can do int a = int.Parse(num1); But int a = int.Parse(num2); will throw an exception as it cannot be converted to numerical value. Hence we use int.tryParse(num2, out a);
   
8. <b> Arrays</b> :
   - An array is a collection of same datatypes.
   - It is strongly typed but it cannot grow in size once initiated.
   - It has to rely on integral indices to store or retrieve items from the array.
   - Example : </br> int[] i = new int[3];
   
9. <b> Conditional Statements </b> :
    - If and If Else statement :
      - Syntax: </br>
      if(condition)</br>{ //statement }</br>else</br>{ //statement }
    - Switch Statement :
      - Syntax :
        Switch(case)</br>{</br> Case 0: </br>//statement </br> break;</br> Case 1:</br> //statement </br> break; </br> default: </br>// statement </br> break; </br> }
        
10. <b> Loops </b> :
    - While Loop :
      - Syntax : </br> While(Condition)</br>{//statement}
      - In while loop the code enters while loop only if the condition is true and it is repeated as long as the condition is true.
    - Do While Loop :
      - Syntax : </br> Do</br> {</br>//statement</br>}While(condition);
      - The code enters the loop atleast one time whether the given condition is true or not
    - For Loop:
      - Syntax :</br> For (Variable start value; variable end value; variable increment/decrement)</br>{</br>//statement</br>}
      - It requires to know the amount of the number for the loop to execute.
    - Foreach Loop:
      - It is used for lists, arrays etc. 
      - Syntax: </br> foreach(variableType newName in List/ArrayName ) </br>{</br>//statement</br>}
      - It does not need to know the amount for the loop to execute
     
11. <b> Methods </b> :
    - Methods are also called functions
    - It helps to create reusable code and helps in application maintenance
    - Syntax : </br> access-modifiers return-type MethodName(parameters)</br> {</br>//Method body</br>}
   
12. <b> Parameters in Methods </b> :
    - Value parameters : 
      - It creates a copy of the parameter passed to the method, so modification of parameter in method, does not affect the variable 
      - Example: </br> public int Sum (int a, int b)</br>{</br> return a+b; </br>}</br> a and b are value parameters</br>
    - Reference parameters :
      - Ref keyword is used to initialize reference parameters in a method
      - It refers to the same variable that was paased on the method so change made to the parameter on the method will be reflected on the variable
      - Example : </br> public int Sum (int a, ref int b)</br>{</br> b += a;</br> return b; </br>}</br> here b is reference parameter and the value of the variable passed on call will be changed to the value of sum of a and b </br>
    - Out parameters :
      - It is used when a method has to return more than one value
      - The parameter with out keyword will have the assigned processed value
      - Example : </br> public int Sum (int a, int b, out int sum)</br>{</br> sum = a + b;</br> return b; </br>}</br> , the value is returned from sum parameter</br>
    - Parameter Arrays :
      - Arrays or list of variable can also be passed as parameter on a method
      - Example : </br> public int Sum (List<int> numbers)</br>{</br> return numbers[0] + numbers[1]; </br>}</br>
      
13. <b> Classes </b> :
    - It contains data and behaviors
    - Data is represented by field and behaviour is represented by methods
    - It is used to creare complex custom types.
    - Classes have constructor which are simply methods with no return type and having same name as the class
    - Constructors are used to initialize class fields and they can be overloaded by the number and types of parameter
    - Constructors are mandatory, if not provided code will genertae parameter less constructor by default
    
14. <b> Static and non-static members of class</b> :
    - Static members have static keyword whereas non-static members does not have static keyword
    - Static members can be easily invoked using class name without using object but to invoke non-static members object of the class is required
    - Static members always remains the same but non-static members belongs to specific instance only. i.e. there will always be one static members no matter how many objects are created but there non-static members will be equal to the instance of the class
    - Static constructor are called only once during whole program run and they are called before instance constructor
    
15. <b>Inheritance</b> :
    - It allows code reuse, which redces time and errors
    - The common fields and properties are defined in the base class and derived class can se it without defining it in it
    - Base classes are automatically instantiated before derived class
    - Parent class constructors executes before child class constructor
    
16. <b>Method hiding </b> :
    - If the base class and derived class have same method name and instance of derived class is made then it will hide the base method. i.e. the method of the base class will not be called.
    - If the hiding is intentional then use new keyword for the method
    - To call the base method we can use base keyword or cast derived class to base class and invoke hidden member
    
17. <b> Polymorphism </b> :
    - It allows to invoke derived class methods through a base class reference during runtime
    - To allow this base class must have virtual methods which are then overriden by the derived class
    - Virtual keyword indidcates that a method can be overridden in any derived class
    
18. <b> Method overriding vs Method hiding </b> :
    - Say base and derived class both have same print function: </br> Baceclass instance = new DerivedClass();</br> instance.Print();
    - If the function is hidden then the print method of base class is invoked
    - If the function is overriding then method of the derived class will be invoked
    
19. <b> Function/Method Overloading </b> :
    - It allows class to have multiple methods with the same name but with different signature.
    - Methods can be overloaded based on number of parameters, types of parameter, kind of parameters(out, ref etc)
    - Example:</br> public void Sum(int a, int b,out int sum)</br>{</br> //body </br>}</br>public void Sum(doble a, double b)</br>{</br>}
    - Functions' cannot be pverloaded based on return type and params modifiers
     
20. <b>Encapsulation</b> :
    - Making fields public will make lose the control of what gets assigned and returned
    - Properties are used for encapsulation
    - There are four types of properties:
       - Read/write properties: it has both get and set accesor            
       - Readonly properties : it has get accesor only
       - Writeonly properties : it has set accesor only
       - Autoimplemented properties: get and set does not have statement
       - Example: </br> private int _id;</br> public int Id{get; set;}//auto implemented property
       
21. <b>Struct </b> :
    - Just like classes struct can have private fields, public properties, constructors and methods
    - Structs are value type whereas classes are reference type
    - Structs cannot have destructors
    - Structs cannot have parameterless constructors
    - Structs cannot inherit from another class but can inherit from interface
    - structs cannot be sed as base to form derived class/structs
    - Syntax: </br> access-modifier struct structName</br>{</br> //body </br>}
    
22. <b> Interfaces</b> :
    - Interfaces also contains properties, methods, delegates or events bt only declarations and no implementations
    - It is complie time error to provide implementations for any interface members
    - Interface members are public by default and the do not allow wxplicit access modifiers.
    - It cannot contains fields
    - Class oe structs derived from interface must provide implementation for all interface members
    - Instance of interface cannot be created but interface reference variable can point to a derived class similar to polymorphism described
    - I is prefixed infornt of the name of interfaces 
    - If a class/struct inherits from from two interfaces with same method then the methods can be implemented explicitly to stop ambiguity
    - If both I1 and I2 interface have same print method with void return type that a class inherited then it is implemented explicitly as </br><i>void I1.Print(){}</i>
    
23. <b> Abstract Classes </b> :
    - It is incomplete and hence cannot be instantiated but used as base class only
    - It cannot be sealed; i.e. stop from being derived
    - It can have implementation for some of its members unlike interface and can have fields, access modifiers
    - A non-abstract class derived from the abstract class must have all metjods implementation in it
    
24. <b> Delegates </b> :
    - It is a reference type type-safe(i.e it holds reference to a function) function pointer
    - Syntax: </br> To declare delegate: <i> access-modifier delegate return-type DelegateName(parametersofFunction);</i> </br> To Instantiate delegate: <i> DelegateName variableName = new DelegateName(FunctionName);</i> </br> To Call : <i> varibaleName(parametersofFunction); </i>
    - Signature of function and delegates must match i.e parameters of function and return type
    - It is mostly used to make framework
    - It is used to make classes flexible; a class can be modified without changing its entire logic
    
25. <b> Multicast delegates </b> :
    - It has reference to more than one function
    - It invokes the method according to the invocation list, in same order that they are added
    - All the functions pointed by multicast delegates are invoked but if the delgates have return value then the value of the last invoked method is returned
    - \+ or += registers a method to a delegate
    - \- or -= unregisters a method to a delegate
    
26. <b> Exception handling </b> :
    - An unforseen error that occurs while running program is called exception
    - If such errors are not handled then program will crash and stop working
    - We can use try, catch, finally to handle these errors
    - Syntax: </br> try</br> {</br> // it has code that can cause error </br>}</br> catch(Exception e)</br>{</br> //code to handle thrown exception</br>}</br>finally</br>{</br>//code to clean and free resources</br>}
    - finally block is optional
    - Pre-defiend specific exception must be handled first before general exception
    - <b><i>Inner Exception</i></b>: it returns the instance that caused the current exception
    - Custom Exceptions can also be created
    
27. <b> Enum </b> :
    - It is strongly typed value type constant
    - Default underlying type of enum is int
    - Default value for first element is zero and gets incremented by 1
    - Its values can be customized
    
28. <b> Access Modifiers </b> :
    - <b><i>Types and Type members </b> </i> : classes, structs, enums, delegates, interfaces are types whereas the fields, properties, methods, constructors contained inside types are called type members
    - types can have only public and internal modifiers whereas type members can have all modifiers
    - private : available within the containing type
    - public :available anywhere, no restrictions
    - protected : available within contained and derived types
    - internal : available anywhere within the containing assembly
    - protected internal : available to any code within which it is declared or from derived types of another assembly
    
29. <b> Early binding vs Late binding </b> :
    - Early binding means access/detect the methods, variables and propeties at compile time whereas late binding allows only at runtime
    - Early binding can flag errors at complie time But there is risk of run time exceptions with late binding
    - Early binding is better for perfomance and ease development
    - Late binding shold be used only when working with objects that are not available at compile time
    
30. <b> Reflection </b> :
    - Reflection is the ability of inspecting an assemblies'metadata at runtime
    - It is used to find all types in and assembly and/or dynamically invoke methods in an assembly (i.e. late binding)
    
31. <b> Generics </b> :
    - It allows to create methods and classes decoupled from the data types
    - It makes code type independent and increase the reusability based on datatype
    - Example : </br> public static bool AreEqual( <T> value1, <T> value2)</br>{</br> return value1.Equals(value2); </br>}</br>
    - In above example T can be int, string, double etc as required and will work correctly for any of it
    
32. <b> Partial Classes </b> :
    - It allows to divide a single class file into two or more class files
    - Example is Form.cs and Form.Designer.cs of windows form application
    
33. <b> Partial Methods </b> :
    - Partial method is contained on partial class or structs
    - These are private by default
    - Implementation and declaration are done in seperate file else it is compile time error
    - Providing access modifier also creates compile time error
    
34. <b> Indexers </b> :
    - It allows instance of class to be indexed just like arrays
    - Creating Indexers : </br> 1. Use "this" keyword to create an indexer </br> 2. Just like properties indexers have get and set accessors </br> 3. Indexers can be overloaded
    - Example</br> public string this[int value]{ get; set;}
    
35. <b> Dictionary </b> :
    - It is a collection of key, value pair
    - It is present System.Collections.Generic class
    - Syntax : Dictionary<keytype, valurtype>
    
36. <b> List </b> :
    - It is also present in System.Collections.Generic class
    - It is a collection of same datatype
    - It grows automatically unlike arrays
    
37. <b> Sorting List of complex types </b> :
    - Modification of IComparable interface and providing implementation for CompareTo() function
    - CompareTo() method return integer : </br> 1. Greater than zero : the current instance is greater than the object being compared </br> 2. Less than zero : the current instance is less than the value being compared </br> 3. Is zero : the crrent instance is equal to zero
    - Another way is to provide custom implementation using Icomparer interface
    - They can also be sorted using delegate or lambda expression
    
38. <b> Queue </b> :
    - It is generic FIFO(First In First Out) collection class
    - Enqueue() is sed to add to the queue
    - Dequeue() is used to removed the item
    - Contains() is used to check if an item is present in queue or not
    - Peek() returns the first entered object, readonly
    
39. <b> Stack </b> :
    - Stack is LIFO(Last In Fist Out) collection class
    - Push() is used to enter data into stack
    - Pop() is used to remove data from stack
    - Peek() returns the last entered object, read only
    
40. <b> Multi-Threading </b> :
       - <b><i>Process : </b> </i> process is what an operating system uses to facilitate the exection of a program by providing resources. Each process has a unique id associated with it.
       - <b><i>Thread : </b></i> A thread is a light weight process. Every process has atleast one thread called as main thread which executes the application code. A single process can have multiple threads.
      - Threads are used for concurrent processing utilising the multicore processor
      - <b> Advantages : </b> </br> 1. To maintain responsive User Interface </br> 2. To make efficient use of processor time while waiting I/O operations to complete </br> 3. To split large CPU  bound tasks to be processed simultaneously on a machine that has multiple processor/core
      - <b> Disadvantages : </b> </br> 1. On a single processor/core multi threading can affect program negatively as there is overhead involved with context-sitching</br>2. More lines of code is required to accomplish same task(without using multi threading)</br> 3. Multi threaded applications are difficult to write understand, debug and maintain
      - Syntax : </br > 1. Simple: <b><i> Thread</b></i> t = new <b><i> Thread</b></i>(functionName); </br> 2. <b><i> Thread</b></i> t = new <b><i> Thread</b></i>(<b><i> new ThreadStart</b></i>(function));</br> 3.<b><i> Thread</b></i> t = new <b><i> Thread</b></i>(<b><i> delegate()</b></i>{function(); });
      - To start a thread use <i>t.Start();</i>
      - To let the thread complete use <i>t.Join();</i>
      - Use <b><i> ParameterizedThreadStart </b></i> to pass data into the thread, but it is not type safe 
      - To make a threa type safe; encapsulate the thread fnction and data it needs in a helper class and se the thread start delegate to execute the function
      - To retrieve data from thread callback methods can be used
      
41. <b> Thread.Join & Thread.IsAlive </b> :
    - Join blocks the current thread and makes it wait until the thread on which join is invoked completes, timeout can also be specified for join
    - IsAlive checks whether the thread has completed is execution or not, returns true if completed else returns false
    
42. <b> Protecting shared resources </b> :
    - Operators like --, ++ are not thread safe and its behaviour is inconsistent inside a thread
    - To solve it Either <b><i>Interlocked</b></i> or <b><i>Lock</b></i> fncitionaities are used
    - Performance wise interlocked fuunctionality is good but it has very limited options to increment, decrement, add or read for int and long only whereas lock is versatile
    
43. <b> DeadLocks </b> :
    - While using multithreading deadlocks can occour; example: Lets say there are two resorces(r1, r2) required for thread t1 and t2 to perform certain task and t1 locked r1 and t2 locked r2, since both thread requires both resources and both resources have been locked by separate thread the task cannot be completed and deadlock occurs
    - Deadlocks can be resolved : </br> 1. Acquiring locks in a specific order </br> 2. Mutex class </br> 3. Monitor.TryEnter() method
    
44. <b> Async & Await </b> :
    - In a multi threaded program one thread might hinder the performance of another thread. for example the click method of a form requires alot of processing and it is implemented using multi threads, if nothing is done then the whole form containing the button will freeze, even resizing or moving arond cannot be done in the form whle the process is running
    - To resolve it async and await can be used where async keyword will make methods asynchronous and await keyword specifies the sspension point which signals async method cannot continue above this point until the async method completes
    - Async can have multiple await but not mandatory
    - Async methods creates tasks which will be performed separately withoud hindering the main thread
