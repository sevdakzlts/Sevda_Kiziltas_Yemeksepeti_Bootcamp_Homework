# # IP-Address-Filtering

An API Control Attribute that allows whitelist incoming requests based on IP address.


# Usage

After cloning this repository and installing [Visual Studio](https://visualstudio.microsoft.com/tr/downloads/) enter the project's folder through the command line and type the following code to run the program:
`dotnet run`

### Startup.ConfigureServices

1.  inject IpControlAttribute
    
    ```c#
    services.AddScoped<IpControlAttribute>();
    
    ```


## Dependencies

- [.Net5.0](https://dotnet.microsoft.com/download/dotnet/5.0)


## Appsettings.json File
``` c#
{
  "WhiteList": {
    "0.0.0.1": [ "Home", "Customer" ],
    "0.0.0.2": [ "People" ]
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}

```

