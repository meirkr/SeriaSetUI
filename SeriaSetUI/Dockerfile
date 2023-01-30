FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SeriaSetUI/SeriaSetUI.csproj", "SeriaSetUI/"]
RUN dotnet restore "SeriaSetUI/SeriaSetUI.csproj"
COPY . .
WORKDIR "/src/SeriaSetUI"
RUN dotnet build "SeriaSetUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SeriaSetUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SeriaSetUI.dll"]
