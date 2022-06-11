#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MinimalAPI.PostgreSQL/MinimalAPI.PostgreSQL.csproj", "MinimalAPI.PostgreSQL/"]
RUN dotnet restore "MinimalAPI.PostgreSQL/MinimalAPI.PostgreSQL.csproj"
COPY . .
WORKDIR "/src/MinimalAPI.PostgreSQL"
RUN dotnet build "MinimalAPI.PostgreSQL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinimalAPI.PostgreSQL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinimalAPI.PostgreSQL.dll"]