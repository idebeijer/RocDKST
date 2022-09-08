FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RocDKST.Api/RocDKST.Api.csproj", "RocDKST.Api/"]
RUN dotnet restore "RocDKST.Api/RocDKST.Api.csproj"
COPY . .
WORKDIR "/src/RocDKST.Api"
RUN dotnet build "RocDKST.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RocDKST.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RocDKST.Api.dll"]
