# Clean Code In C#

Bad code can cause a whole range of problems relating to efficiency, scalability, and maintainability.
Clean code principles greatly improve your software. Through the right application of clean code principles such as DRY and SOLID, the correct design patterns for the task at hand, and by standardizing on best practice coding standards, your code will be less complex, easy to read and so easy to maintain, and will be easy to extend as the need arises.


# Usage

After cloning this repository and installing [Visual Studio](https://visualstudio.microsoft.com/tr/downloads/) enter the project's folder through the command line and type the following code to run the program:
`dotnet run`

## Dependencies
- [.Net5.0](https://dotnet.microsoft.com/download/dotnet/5.0)


## Important Tips To Write Clean C# Code

## 1. Boolean comparisons and value assignments 
A **Boolean value** is either true or false. A **Boolean expression** is an expression that evaluates to produce a result which is a Boolean value.
``` c#
bool GetResult(int value) => (value == 1);
```
.
## 2. Use Ternary Operator
The conditional **operator** ?: , also known as the **ternary** conditional **operator**, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to true or false.

``` c#
string Result(int value) => value == 1 ? "Value is equals 1" : "Value is not equals 1";
```

## 3. Use Strongly Type

Magic Strings are strings that are directly specified within the application code which has a direct impact on the application behavior. In other words, do not use hardcoded strings or values in our application. It would be tough to keep track of such strings when your application grows. Also, these strings can be associated with some kind of external references, like a file name, file path, URL, etc. In such cases, when then the location of the resources change, all these magic strings would have to be updated, else that application breaks. 
``` c#
 const string AdminRole = "Admin";
            string UserRole = "Premium";
            if (UserRole == AdminRole)
            {
                return ;
            }
```

## 4. Complex Conditions
The complexity of an expression is defined by the number of &&, || and condition? ifTrue : ifFalse operators it contains.

A single expression's complexity should not become too high to keep the code readable.
``` c#
int BirthDate = 1997;
            bool IsAdult = (DateTime.Now.Year - BirthDate) >= 18;
```

## 5. Rule of Seven

People can only keep 7 items in short-term memory. We mustn't forget this rule when writing clean code.
Our variable definitions in methods should be made just-in-time, just before the first value assignment.
``` c#
public void GetTotalNumber(int number1, int number2)
        {
            int totalNumber = number1 + number2;
            int minimumNumber = 0;
            if (totalNumber>= minimumNumber)
                return;
            
        }
```

## 6. Avoid Too Many Parameters and 

Too many parameters is always a nightmare. A long parameter list can indicate that a new structure should be created to wrap the numerous parameters or that the function is doing too many things.


## 7. Fail Fast

The fail-fast principle stands for stopping the current operation as soon as any unexpected error occurs. Adhering to this principle generally results in a more stable solution.
The trick here is that adhering to the fail-fast principle, we improve the feedback loop.
``` c#
public Student StudentInformation(Student student)
        {
            if (student == null)
                throw new FileNotFoundException();
            
            return student;
        }
```
## Referances
- https://enterprisecraftsmanship.com/posts/fail-fast-principle/
- https://rikkeisoft.github.io/sonar-rules/cs.html#csharpsquid-S3984
- https://codewithmukesh.com/blog/write-clean-csharp-code/
- https://www.toptal.com/c-sharp/top-10-mistakes-that-c-sharp-programmers-make
- https://bilisim.io/2020/04/20/clean-code-principles/
- https://bilisim.io/2020/04/25/clean-code-method-principles/
