##### dotnet commands:

##### .net 8

##### Catalog service

- _(Services/Catalog)_ dotnet new webapi -controllers -n "Catalog.Api.Web"
- _(Services/Catalog)_ dotnet new classlib -n "Catalog.Core"
- _(Services/Catalog)_ dotnet new classlib -n "Catalog.Application"
- _(Services/Catalog)_ dotnet new classlib -n "Catalog.Infrastructure"

##### Basket service

- _(Services/Basket)_ dotnet new webapi -controllers -n "Basket.Api.Web"
- _(Services/Basket)_ dotnet new classlib -n "Basket.Core"
- _(Services/Basket)_ dotnet new classlib -n "Basket.Application"
- _(Services/Basket)_ dotnet new classlib -n "Basket.Infrastructure"

##### Ocelot api gateway

- (ApiGateway/Ocelot.ApiGateway) dotnet new webapi -n "Ocelot.ApiGateway"
- (ApiGateway/Ocelot.ApiGateway) dotnet add package Ocelot

##### solution file

- dotnet new sln
- dotnet sln add "Services/Catalog/Catalog.Api.Web"
- dotnet sln add "Services/Catalog/Catalog.Core"
- dotnet sln add "Services/Catalog/Catalog.Application"
- dotnet sln add "Services/Catalog/Catalog.Infrastructure"

- dotnet sln add "Services/Basket/Basket.Api.Web"
- dotnet sln add "Services/Basket/Basket.Core"
- dotnet sln add "Services/Basket/Basket.Application"
- dotnet sln add "Services/Basket/Basket.Infrastructure"

- dotnet sln add "ApiGateway/Ocelot.ApiGateway"

#### run

- (ApiGateway/Ocelot.ApiGateway) dotnet build
- (ApiGateway/Ocelot.ApiGateway) dotnet run --launch-profile https
