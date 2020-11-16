FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet CorporateFinance.dll