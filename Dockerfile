FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY /dotnet/WeatherForecast/*.csproj ./WeatherForecast/
COPY /dotnet/WeatherForecast.Test/WeatherForecast.Test.csproj ./WeatherForecast.Test/

RUN dotnet restore ./WeatherForecast/WeatherForecast.csproj
RUN dotnet restore ./WeatherForecast.Test/WeatherForecast.Test.csproj

COPY /dotnet/WeatherForecast/ ./WeatherForecast/
COPY /dotnet/WeatherForecast.Test/ ./WeatherForecast.Test/

RUN dotnet publish ./WeatherForecast/WeatherForecast.csproj -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "WeatherForecast.dll"]