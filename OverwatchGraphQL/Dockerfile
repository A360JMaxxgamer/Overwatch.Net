FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["OverwatchGraphQL/OverwatchGraphQL.csproj", "OverwatchGraphQL/"]
RUN dotnet restore "OverwatchGraphQL/OverwatchGraphQL.csproj"
COPY . .
WORKDIR "/src/OverwatchGraphQL"
RUN dotnet build "OverwatchGraphQL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OverwatchGraphQL.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OverwatchGraphQL.dll"]