
# Refresh Token

Refresh tokens are credentials that can be used to acquire new access tokens. When access tokens expire, we can use refresh tokens to get a new access token from the authentication component. The lifetime of a refresh token is usually set much longer compared to the lifetime of an access token.

## Usage

After cloning this repository and installing  [Visual Studio](https://visualstudio.microsoft.com/tr/downloads/)  enter the project's folder through the command line and type the following code to run the program:  `dotnet run`.

The API will start up on [http://localhost:57734](http://localhost:57734/), or [http://localhost:5000](http://localhost:5000/) with `dotnet run`.

You can use an HTTP client like  [Postman](https://www.getpostman.com/)  or  [Fiddler](https://www.telerik.com/download/fiddler) or [Swagger](https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger/) to  `GET http://localhost:57734`.

## Dependencies

-   [.Net5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
-  [AutoMapper](https://automapper.org/)
-   [JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer)
-   [Microsoft.EntityFrameworkCore.InMemory](https://entityframeworkcore.com/providers-inmemory#:~:text=EntityFrameworkCore.,overhead%20of%20actual%20database%20operations.)
-   [Swashbuckle.AspNetCore5.6.3](https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger/)


## Referances

-   https://code-maze.com/using-refresh-tokens-in-asp-net-core-authentication/
- https://fullstackmark.com/post/19/jwt-authentication-flow-with-refresh-tokens-in-aspnet-core-web-api
- https://jasonwatmore.com/post/2020/05/25/aspnet-core-3-api-jwt-authentication-with-refresh-tokens





