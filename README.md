# CSharp
Understanding C# from basics

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
   - </i>Console.Writeline(sting);</br>Console.Write(sting);</br>Console.Readline(sting);</br>Console.Read(sting);</br> are used to read and write from console
   - Read takes input from console and write provides output to console
   - Place holders' can be provided to print variable </br>
   Example: Console.WriteLine("The full name is: {0} {1}", firstName, lastName); firstname and lastname are string arguments and {0} is placeholder for first name and {1} is placeholder for lastName
   
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
     
7. <b> Data Conversion </b> :
   - It can be converted in two ways :
     - Implicit conversion : It is done when the conversion will not result to loss of data, or throws an exception
     - Example </br> int a = 10; </br> double j = a; It is possible because there will be no loss of data or throws an exception But 
     </br> double j = 10.05; </br> int a = j; this is not possible because while converting it 0.05 will be lost as integer value cannot hold decimal number
   - Explicit Conversion :
     - Casting :
       int a = (double)j;
     - Using Convert class:
       int a = Convert.ToDouble(j);
       
8. <b> Parse and Try Parse</b> :
   - If a string is in a string format we can use parse or try parse method for conversion.
   - Parsing tries to directly convert the string values to numerical and if it cannot then it will throw exception which will result in crashing
   - Whereas try parse first checks if the value can be converted or not, if it cannot be converted the it returns 0.
   - To avoid exception and crashing using try parse method is safe
   - Example </br> string num1 = "50"; </br> string num2 = "50ab"; </br> we can do int a = int.Parse(num1); But int a = int.Parse(num2); will throw an exception as it cannot be converted to numerical value. Hence we use int.tryParse(num2, out a);
   
9. <b> Arrays</b> :
   - An array is a collection of same datatypes.
   - It is strongly typed but it cannot grow in size once initiated.
   - It has to rely on integral indices to store or retrieve items from the array.
   - Example : </br> int[] i = new int[3];
   
10. <b> Conditional Statements </b> :
    - If and If Else statement :
      - Syntax: </br>
      if(condition)</br>{ //statement }</br>else</br>{ //statement }
    - Switch Statement :
      - Syntax :
        Switch(case)</br>{</br> Case 0: </br>//statement </br> break;</br> Case 1:</br> //statement </br> break; </br> default: </br>// statement </br> break; </br> }
        
11. <b> Loops </b> :
    - While Loop :
      - Syntax : </br> While(Condition)</br{//statement}
      - In while loop the code enters while loop only if the condition is true and it is repeated as long as the condition is true.
    - Do While Loop :
      - Syntax : </br> Do</br> {//statement}While(condition);
      - The code enters the loop atleast one time whether the given condition is true or not
    - For Loop:
      - Syntax : For (Variable start value; variable end value; variable increment/decrement)</br>{//statement}
      - It requires to know the amount of the number for the loop to execute.
    - Foreach Loop:
      - It is used for lists, arrays etc. 
      - Syntax:  foreach(variableType newName in List/ArrayName ) </br>{//statement}
      - It does not need to know the amount for the loop to execute
     
12. <b> Methods </b> :
    - Methods are also called functions
    - It helps to create reusable code and helps in application maintenance
    - Syntax : </br> access-modifiers return-type MethodName(parameters)</br> {//Method body}
   
14. <b> Parameters in Methods </b> :
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
      
15. <b> Classes </b> :
    - It contains data and behaviors
    - Data is represented by field and behaviour is represented by methods
    - It is used to creare complex custom types.
    - Classes have constructor which are simply methods with no return type and having same name as the class
    - Constructors are used to initialize class fields and they can be overloaded by the number and types of parameter
    - Constructors are mandatory, if not provided code will genertae parameter less constructor by default
    
16. <b> Static and non-static members of class</b> :
    - Static members have static keyword whereas non-static members does not have static keyword
    - Static members can be easily invoked using class name without using object but to invoke non-static members object of the class is required
    - Static members always remains the same but non-static members belongs to specific instance only. i.e. there will always be one static members no matter how many objects are created but there non-static members will be equal to the instance of the class
    - Static constructor are called only once during whole program run and they are called before instance constructor
    
17. <b>Inheritance</b> :
    - It allows code reuse, which redces time and errors
    - The common fields and properties are defined in the base class and derived class can se it without defining it in it
    - Base classes are automatically instantiated before derived class
    - Parent class constructors executes before child class constructor
    
18. <b>Method hiding </b> :
    - If the base class and derived class have same method name and instance of derived class is made then it will hide the base method. i.e. the method of the base class will not be called.
    - If the hiding is intentional then use new keyword for the method
    - To call the base method we can use base keyword or cast derived class to base class and invoke hidden member
    
19. <b> Polymorphism</b> :
    - It allows to invoke derived class methods through a base class reference during runtime
    - To allow this base class must have virtual methods which are then overriden by the derived class
    - Virtual keyword indidcates that a method can be overridden in any derived class
    
20.<b> Method overriding vs Method hiding </b>
    - Say base and derived class both have same print function: </br> Baceclass instance = new DerivedClass();</br> instance.Print();
    - If the function is hidden then the print method of base class is invoked
    - If the function is overriding then method of the derived class will be invoked
    
21. <b>Function/Method Overloading </b>
     - It allows class to have multiple methods with the same name but with different signature.
     - Methods can be overloaded based on number of parameters, types of parameter, kind of parameters(out, ref etc)
     - Example:</br> public void Sum(int a, int b,out int sum)</br{}</br>public void Sum(doble a, double b)</br>{}
     - Functions' cannot be pverloaded based on return type and params modifiers
     
22.<b>
