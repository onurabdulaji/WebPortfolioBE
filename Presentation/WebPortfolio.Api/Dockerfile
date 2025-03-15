# Base image with ASP.NET runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Build stage using SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy project files for dependencies
COPY ["Presentation/WebPortfolio.Api/WebPortfolio.Api.csproj", "Presentation/WebPortfolio.Api/"]
COPY ["Infastructure/WebPortfolio.Persistence/WebPortfolio.Persistence.csproj", "Infastructure/WebPortfolio.Persistence/"]
COPY ["Core/WebPortfolio.Domain/WebPortfolio.Domain.csproj", "Core/WebPortfolio.Domain/"]

# Restore dependencies
RUN dotnet restore "./Presentation/WebPortfolio.Api/WebPortfolio.Api.csproj"

# Copy the remaining application files
COPY . . 

# Build the application
WORKDIR "/src/Presentation/WebPortfolio.Api"
RUN dotnet build "./WebPortfolio.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebPortfolio.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage: setting up the runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Set the entry point to start the API
ENTRYPOINT ["dotnet", "WebPortfolio.Api.dll"]
