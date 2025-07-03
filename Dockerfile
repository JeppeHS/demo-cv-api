# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy
COPY DemoCVApi/DemoCVApi.csproj ./DemoCVApi/
    RUN dotnet restore ./DemoCVApi/DemoCVApi.csproj

# Copy
COPY DemoCVApi/ ./DemoCVApi/
    WORKDIR /src/DemoCVApi
RUN dotnet publish -c Release -o /app/publish

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "DemoCVApi.dll"]