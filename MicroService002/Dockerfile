#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MicroService002/MicroService002.csproj", "MicroService002/"]
RUN dotnet restore "MicroService002/MicroService002.csproj"
COPY . .
WORKDIR "/src/MicroService002"
RUN dotnet build "MicroService002.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroService002.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroService002.dll"]
