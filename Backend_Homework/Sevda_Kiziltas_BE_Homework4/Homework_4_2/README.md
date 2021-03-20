
# Log Request and Response

Logging is one of the most essential components of an application. An application once moved to production still needs maintenance and monitoring for any uncovered bugs and runtime errors and a good logging mechanism implemented with essential attributes being logged can be a lot helpful in understanding the issues better. And similarly, when building an API for any application, it is indeed necessary to build an underlying logging system that can put up nice insights for every request received.


# Usage

After cloning this repository and installing [Visual Studio](https://visualstudio.microsoft.com/tr/downloads/) enter the project's folder through the command line and type the following code to run the program:
`dotnet run`
The API will start up on  [http://localhost:63639](http://localhost:63639/), or  [http://localhost:5000](http://localhost:5000/)  with  `dotnet run`.

You can use an HTTP client like  [Postman](https://www.getpostman.com/)  or  [Fiddler](https://www.telerik.com/download/fiddler)  or  [Swagger](https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger/)  to  `GET http://localhost:63639`.

## Dependencies
- [.Net5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Microsoft.EntityFrameworkCore5.0.3](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)
- [Swashbuckle.AspNetCore5.6.3](https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger/)

## The Middleware

Middleware can be implemented as a lambda directly in the Configure function, but more typically it is implemented as a class that is added to the pipeline using an extension method on IApplicationBuilder.

We need to include our new middleware in the ASP.NET Core pipeline. In the Startup.cs file, we can do this in the ConfigureServices method:

```
public class Startup
{
    //...
    
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory  loggerFactory)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
			app.UseSwagger();
			app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Homework_4_2.API v1"));
        }

        //Add our new middleware to the pipeline
        app.UseMiddleware<RequestResponseLoggingMiddleware>();

    }
}
```


## Referances
- https://referbruv.com/blog/posts/logging-http-request-and-response-in-aspnet-core-using-middlewares

