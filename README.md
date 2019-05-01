# C# API for the AthenaHealth

> see https://aka.ms/autorest

``` yaml 
use-extension:
  "@microsoft.azure/autorest.csharp": "2.3.84"

input-file: openapi.yaml
add-credentials: true
csharp:
  namespace: AndriiKurdiumov.AuthenaHealth.Client
  output-folder: Client
```

All content of the client, generated using autorest. Just run in the root of solution:
```
autorest
```

While https://github.com/Azure/autorest.csharp/pull/109 does not land
you may need run following commands

    git clone https://github.com/kant2002/autorest.csharp c:\d\autorest.csharp
    cd c:\d\autorest.csharp
    dotnet build

then for generation you could use

    autorest --use=c:\d\autorest.csharp

That way you will use patched version of AutoRest C# generation

# Legal
Usage of this client for Athenahealth API still subject to https://developer.athenahealth.com/terms