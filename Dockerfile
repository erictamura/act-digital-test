FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY RockPaperScissors.Presentation/*.csproj RockPaperScissors.Presentation/
COPY RockPaperScissors.Application/*.csproj RockPaperScissors.Application/
COPY RockPaperScissors.Core/*.csproj RockPaperScissors.Core/
COPY RockPaperScissors.Infrastructure/*.csproj RockPaperScissors.Infrastructure/
COPY RockPaperScissors.Tests/*.csproj RockPaperScissors.Tests/
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet build -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "RockPaperScissors.Presentation.dll"]

