FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Tonytins.Models/Tonytins.Models.csproj", "Tonytins.Models/"]
COPY ["Tonytins.Api/Tonytins.Api.csproj", "Tonytins.Api/"]
RUN dotnet restore "Tonytins.Api/Tonytins.Api.csproj"
COPY . .
WORKDIR "/src/Tonytins.Api"
RUN dotnet build "Tonytins.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tonytins.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tonytins.Api.dll"]