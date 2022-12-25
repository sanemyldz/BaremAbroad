#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BaremAbroad.UI/BaremAbroad.UI.csproj", "BaremAbroad.UI/"]
RUN dotnet restore "BaremAbroad.UI/BaremAbroad.UI.csproj"
COPY . .
WORKDIR "/src/BaremAbroad.UI"
RUN dotnet build "BaremAbroad.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BaremAbroad.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BaremAbroad.UI.dll"]