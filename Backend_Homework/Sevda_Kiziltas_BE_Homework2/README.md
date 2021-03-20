
# InventoryApp - Web API Project

InventoryApp is an application where users can save the items they own and give the return of renting or purchasing these items according to their usage frequency and the price they offer. The application is a .Net Web API project. It was designed using Visual Studio 2019 as an editor. In this article, I will talk about Extensions, Validator, Abstraction, Interface, Observable Collection, and Swagger issues that I used in the project.

## Usage
After cloning this repository and installing [Visual Studio](https://visualstudio.microsoft.com/tr/downloads/) enter the project's folder through the command line and type the following code to run the program: `dotnet run`

#### Extensions

Extension Methods came into our lives with C # 3.0, it allows us to add extension methods for the relevant struct or class without modifying the class and struct structures.

There are a few rules we must follow when writing Extension methods. These;

- Extension methods must be defined as static in a static class.
- The class to be extended must be given to the related extension method as the first parameter of the method and defined with ** this ** keyword in front of it.
- Only 1 of the parameters defined in the extension method is defined with the ** this ** keyword.

_An extension called BuyOrRentExtension is used in this project. Extension suggests to the user based on the product information received from the user._

public static string BuyOrRent(this InventoryItem item)
        {
            return item.RentPrice * item.PeriodType * item.UsagePeriod  >= item.Price ? "You should buy" : "You should rent";
        }
    

#### Validation

Validations are used to check the accuracy of the information entered by the user. *In this project ** CustomValidator ** is used. This control is used for verification functions written by the designer.* 

public class StringLengthValidator : ValidationAttribute
    {
        private int _minLength;

        public StringLengthValidator(int minLength)
        {
            _minLength = minLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            InventoryController.SearchModel searchModel =
                (InventoryController.SearchModel) validationContext.ObjectInstance;
            if (searchModel.name.Length < _minLength)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.MemberName));
            }

            return ValidationResult.Success;
        }

    

#### Abstraction

Abstraction is one of the important concepts in OOP (Object Oriented Programming). Abstraction is to show functions only by hiding internal details. Abstract classes are classes that are generally used to define the base class in the class hierarchy and provide abstraction capability. We use the ** abstract ** keyword to abstract a class. General properties of abstract classes;

- We generally use abstract classes when implementing inheritance.
- Objects cannot be created with the keyword **new** .
- It can contain variables and methods.
- Classes derived from abstract classes must implement abstract methods . You can use other methods without overriding.
- They can have Constructors and destructors .
- They cannot be statically defined .
- A class can only implement an abstract class via inheritance. **Multiple inheritance** not supported .
- It can also have non-abstract methods .
- There is a "** is-a **" relationship with the classes that will receive inherits from them. *In this project, the classes in the Controller layer are derived from the ControllerBase class. Controller Base is an Abstract Class. The validator named StringLengthValidator is derived from the ValidationAttribute class.*


#### Interface

- Interfaces help to create loosely coupled applications. We reduce the connection between the two classes by creating an interface between them. That way, if one of these classes changes, it will not affect the class that depends on it.
- Only methods and properties can be defined in the interface, the field cannot be defined.
- Interface members do not have any access modifiers, all members can be accessed by the implemented class.
- In C #, a class can implement more than one interface, but it should not be confused with inheritance, it is a completely wrong approach to use the interface structure for multiple inheritance, the interface structure was not created to make multiple inheritance. 
- *In this project, ** Observable Collection ** is used for data binding. The list to be used by the Observable Collection is implemented with an Interface.*

    public interface IDatabase
    { 
        ObservableCollection<InventoryItem> InventoryItems { get; set; }
    }

-   ### Default interface methods
    
It is a method that enables default implementation by casting the methods in the interface. It is a feature that comes with C # 8.0. One of its most important goals is to provide Binary and Source Compatibility.
 For more information  [click here](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#default-interface-methods) 

#### Observable Collection

- One of the most important features for data binding
- ObservableCollection notifies the UI side when there is an event of adding or deleting a new element in the list. In this way, the changes are reflected on the visual screen.
- ObservableCollection implements the  **INotifyCollectionChanged**  and **INotifyPropertyChanged**  interfaces and performs these operations.

#### Swagger

- Swagger is a collection of open-source tools for creating, designing, and using REST APIs.
- Swagger library is available for many programming languages. Swashbuckle is one of the most popular Swagger libraries on .NET.
- Installation of Swashbuckle for **. NET Core 3**  is as follows.

```
Install-Package Swashbuckle.AspNetCore -Version 5.0.0-rc3

```

After the installation is complete

The following code blocks are added under  **Startup.cs** .

using Microsoft.OpenApi.Models;

public void ConfigureServices(IServiceCollection services)
{
services.AddSwaggerGen(c =>
{
c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
}

Then the following code block is added to add Swagger middleware.

public void Configure(IApplicationBuilder app)
{
app.UseSwagger();
app.UseSwaggerUI(c =>
{
c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
});
}
After running our project, we can see that the swagger interface is displayed under  
**/ swagger**  in the address line.


