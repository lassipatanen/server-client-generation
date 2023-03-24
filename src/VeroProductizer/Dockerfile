FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VeroProductizer/VeroProductizer.csproj", "VeroProductizer/"]
RUN dotnet restore "VeroProductizer/VeroProductizer.csproj"
COPY . .
WORKDIR "/src/VeroProductizer"
RUN dotnet build "VeroProductizer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VeroProductizer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VeroProductizer.dll"]
