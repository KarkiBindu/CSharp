CSharp
Understanding C# from basics with kudvenkat Tutorial Source :
1. Namespaces :
o A namespace is used to organize code and assists in avoiding naming clashes
o It is a collection of types; classes, interfaces, structs, enums and delegates
o They do not correspond to file, directory or assembly name.
o They could be written in separate files and/or separate assemblies and still belong to the same namespace.
o Example:
using system; system is a namespace containing various classes
o Aliases can be used if the name space is long.
Example: if a class Teacher is Contained in NameSpace Eductaion.School.Employee then instead of using fully qualified name we can provide short name as: 
using SchoolEmp = Eductaion.School.Employee; so that we do not have to use long full name each time
2. Reading and Writing to Console :
o Console.Writeline(sting);
Console.Write(sting);
Console.Readline(sting);
Console.Read(sting);
are used to read and write from console
o Read takes input from console and write provides output to console
o Place holders' can be provided to print variable 
Example: Console.WriteLine("The full name is: {0} {1}", firstName, lastName); firstname and lastname are string arguments and {0} is placeholder for first name and {1} is placeholder for lastName
3. Buit-in Types :
o Boolean : represents true or false
o Integral : numeric values without decimal
o Floating : numeric values with decimal
o Decimal : numeric value with decimal
o String : character or arrays of character
4. Escape Sequence :
o \ is used to make quotation or \ to be readable by the program.
o Example: To provide the file location we do "C:\\Desktop" or to print hello in quotation marks we will have to provide "\"Hello\""
o Verbatim Literal : Verbatim literal is a string with @ symbol prefix which makes escape sequences translate as normal printable characters, to enchance readability.
Example: instead of doing "C:\\Desktop" we can do @"C:\Desktop" which will make the code more readable
5. Common operators :
o Assignment Operator : "=" 
* Assigns value to a variable.
* Example: int a = 10;
o Arithmetic Operators : "+, -, *, /, %" 
* does mathematical calculation
* Example int a = 10 % 4; it calculates the reminder of the division and assigns the result to a variable, in this case a is equal to 2
o Comparison Operators : "==, !=, >, <, >=, <=" 
* Compares the value or any condition
* Most commonly used in if, else consitional statement and it returns true or false
* Example : 
if (a == 10){ Console.WriteLine("True");}
else{ Console.WriteLine("False");}
it checks whether the value of a is 10 or not, if its true the it prints True, else it prints False
o Conditional Operators : "&&, ||" 
* it checks logical and/or conditions
* Example : 
if (a == 10 && a > 5){ Console.WriteLine("True");}
else{ Console.WriteLine("False");}
it checks whether the value of a is 10 and greater than 5 or not, if its true the it prints True, else it prints False
o Ternary Operators : "?:" 
* It is a short form of if else condition and used if there is only one check condition
* Example : 
bool result = (a = 10) ? true : false; ? acts as then and : as else, statement before ? is condition checking after it is the result if the condition is true and after : is the result if the condition is false
o Null Coalescing Operator : "??" 
* There are two types of datatypes in C#; value type and reference type
* Reference types can be null but value type can never be null
* Example: int is value type and string is reference type
* To make int type null able add j after int : i.e intj a = 10;
* and to make sure to provide value when it is null we do int b == a ?? 0; This convert null able int to non-null able int and also it provides value 0 if the value of a is null
6. Data Conversion :
o It can be converted in two ways : 
* Implicit conversion : It is done when the conversion will not result to loss of data, or throws an exception
* Example 
int a = 10; 
double j = a; It is possible because there will be no loss of data or throws an exception But 
double j = 10.05; 
int a = j; this is not possible because while converting it 0.05 will be lost as integer value cannot hold decimal number
o Explicit Conversion : 
* Casting : int a = (double)j;
* Using Convert class: int a = Convert.ToDouble(j);
7. Parse and Try Parse :
o If a string is in a string format we can use parse or try parse method for conversion.
o Parsing tries to directly convert the string values to numerical and if it cannot then it will throw exception which will result in crashing
o Whereas try parse first checks if the value can be converted or not, if it cannot be converted the it returns 0.
o To avoid exception and crashing using try parse method is safe
o Example 
string num1 = "50"; 
string num2 = "50ab"; 
we can do int a = int.Parse(num1); But int a = int.Parse(num2); will throw an exception as it cannot be converted to numerical value. Hence we use int.tryParse(num2, out a);
8. Arrays :
o An array is a collection of same datatypes.
o It is strongly typed but it cannot grow in size once initiated.
o It has to rely on integral indices to store or retrieve items from the array.
o Example : 
int[] i = new int[3];
9. Conditional Statements :
o If and If Else statement : 
* Syntax: 
if(condition)
{ //statement }
else
{ //statement }
o Switch Statement : 
* Syntax : Switch(case)
{
Case 0: 
//statement 
break;
Case 1:
//statement 
break; 
default: 
// statement 
break; 
}
10. Loops :
o While Loop : 
* Syntax : 
While(Condition
{//statement}
* In while loop the code enters while loop only if the condition is true and it is repeated as long as the condition is true.
o Do While Loop : 
* Syntax : 
Do
{//statement}While(condition);
* The code enters the loop atleast one time whether the given condition is true or not
o For Loop: 
* Syntax : For (Variable start value; variable end value; variable increment/decrement)
{//statement}
* It requires to know the amount of the number for the loop to execute.
o Foreach Loop: 
* It is used for lists, arrays etc.
* Syntax: foreach(variableType newName in List/ArrayName ) 
{//statement}
* It does not need to know the amount for the loop to execute
11. Methods :
o Methods are also called functions
o It helps to create reusable code and helps in application maintenance
o Syntax : 
access-modifiers return-type MethodName(parameters)
{//Method body}
12. Parameters in Methods :
o Value parameters : 
* It creates a copy of the parameter passed to the method, so modification of parameter in method, does not affect the variable
* Example: 
public int Sum (int a, int b)
{
return a+b; 
}
a and b are value parameters
o Reference parameters : 
* Ref keyword is used to initialize reference parameters in a method
* It refers to the same variable that was paased on the method so change made to the parameter on the method will be reflected on the variable
* Example : 
public int Sum (int a, ref int b)
{
b += a;
return b; 
}
here b is reference parameter and the value of the variable passed on call will be changed to the value of sum of a and b 
o Out parameters : 
* It is used when a method has to return more than one value
* The parameter without keyword will have the assigned processed value
* Example : 
public int Sum (int a, int b, out int sum)
{
sum = a + b;
return b; 
}
, the value is returned from sum parameter
o Parameter Arrays : 
* Arrays or list of variable can also be passed as parameter on a method
* Example : 
public int Sum (List numbers)
{
return numbers[0] + numbers[1]; 
}
13. Classes :
o It contains data and behaviours
o Data is represented by field and behaviour is represented by methods
o It is used to create complex custom types.
o Classes have constructor which are simply methods with no return type and having same name as the class
o Constructors are used to initialize class fields and they can be overloaded by the number and types of parameter
o Constructors are mandatory, if not provided code will generate parameter less constructor by default
14. Static and non-static members of class :
o Static members have static keyword whereas non-static members does not have static keyword
o Static members can be easily invoked using class name without using object but to invoke non-static members object of the class is required
o Static members always remains the same but non-static members belongs to specific instance only. i.e. there will always be one static members no matter how many objects are created but there non-static members will be equal to the instance of the class
o Static constructor are called only once during whole program run and they are called before instance constructor
15. Inheritance :
o It allows code reuse, which reduces time and errors
o The common fields and properties are defined in the base class and derived class can se it without defining it in it
o Base classes are automatically instantiated before derived class
o Parent class constructors executes before child class constructor
16. Method hiding :
o If the base class and derived class have same method name and instance of derived class is made then it will hide the base method. i.e. the method of the base class will not be called.
o If the hiding is intentional then use new keyword for the method
o To call the base method we can use base keyword or cast derived class to base class and invoke hidden member
17. Polymorphism :
o It allows to invoke derived class methods through a base class reference during runtime
o To allow this base class must have virtual methods which are then overridden by the derived class
o Virtual keyword indicates that a method can be overridden in any derived class
18. Method overriding vs Method hiding :
o Say base and derived class both have same print function: 
Baceclass instance = new DerivedClass();
instance.Print();
o If the function is hidden then the print method of base class is invoked
o If the function is overriding then method of the derived class will be invoked
19. Function/Method Overloading :
o It allows class to have multiple methods with the same name but with different signature.
o Methods can be overloaded based on number of parameters, types of parameter, kind of parameters(out, ref etc)
o Example:
public void Sum(int a, int b,out int sum)
{ //body }
public void Sum(double a, double b)
{}
o Functions' cannot be overloaded based on return type and params modifiers
20. Encapsulation :
o Making fields public will make lose the control of what gets assigned and returned
o Properties are used for encapsulation
o There are four types of properties: 
* Read/write properties: it has both get and set accessor
* Read-only properties : it has get accessor only
* Write only properties : it has set accessor only
* Auto implemented properties: get and set does not have statement
* Example: 
private int _id;
public int Id{get; set;}//auto implemented property
21. Struct :
o Just like classes struct can have private fields, public properties, constructors and methods
o Structs are value type whereas classes are reference type
o Structs cannot have destructors
o Structs cannot have parameter less constructors
o Structs cannot inherit from another class but can inherit from interface
o structs cannot be used as base to form derived class/structs
o Syntax: 
access-modifier struct structName
{ //body }
22. Interfaces :
o Interfaces also contains properties, methods, delegates or events but only declarations and no implementations
o It is compile time error to provide implementations for any interface members
o Interface members are public by default and the do not allow explicit access modifiers.
o It cannot contains fields
o Class or structs derived from interface must provide implementation for all interface members
o Instance of interface cannot be created but interface reference variable can point to a derived class similar to polymorphism described
o I is prefixed in front of the name of interfaces
o If a class/struct inherits from two interfaces with same method then the methods can be implemented explicitly to stop ambiguity
o If both I1 and I2 interface have same print method with void return type that a class inherited then it is implemented explicitly as 
void I1.Print(){}
23. Abstract Classes :
o It is incomplete and hence cannot be instantiated but used as base class only
o It cannot be sealed; i.e. stop from being derived
o It can have implementation for some of its members unlike interface and can have fields, access modifiers
o A non-abstract class derived from the abstract class must have all methods implementation in it
24. Delegates :
o It is a reference type type-safe(i.e. it holds reference to a function) function pointer
o Syntax: 
To declare delegate: access-modifier delegate return-type DelegateName(parametersofFunction); 
To Instantiate delegate: DelegateName variableName = new DelegateName(FunctionName); 
To Call : varibaleName(parametersofFunction); 
o Signature of function and delegates must match i.e. parameters of function and return type
o It is mostly used to make framework
o It is used to make classes flexible; a class can be modified without changing its entire logic
25. Multicast delegates :
o It has reference to more than one function
o It invokes the method according to the invocation list, in same order that they are added
o All the functions pointed by multicast delegates are invoked but if the delegates have return value then the value of the last invoked method is returned
o + or += registers a method to a delegate
o - or -= unregisters a method to a delegate
26. Exception handling :
o An unforeseen error that occurs while running program is called exception
o If such errors are not handled then program will crash and stop working
o We can use try, catch, finally to handle these errors
o Syntax: 
try
{
// it has code that can cause error 
}
catch(Exception e)
{
//code to handle thrown exception
}
finally
{
//code to clean and free resources
}
o finally block is optional
o Pre-defined specific exception must be handled first before general exception
o Inner Exception: it returns the instance that caused the current exception
o Custom Exceptions can also be created
27. Enum :
o It is strongly typed value type constant
o Default underlying type of enum is int
o Default value for first element is zero and gets incremented by 1
o Its values can be customized
28. Access Modifiers :
o Types and Type members : classes, structs, enums, delegates, interfaces are types whereas the fields, properties, methods, constructors contained inside types are called type members
o types can have only public and internal modifiers whereas type members can have all modifiers
o private : available within the containing type
o public :available anywhere, no restrictions
o protected : available within contained and derived types
o internal : available anywhere within the containing assembly
o protected internal : available to any code within which it is declared or from derived types of another assembly

