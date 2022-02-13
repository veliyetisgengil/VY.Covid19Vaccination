   FROM microsoft/dotnet:5.0-aspnet-runtime AS base
    WORKDIR /app
    EXPOSE 5000
    ENV ASPNETCORE_URLS=http://+:5000

    FROM microsoft/dotnet:2.2-sdk AS build
    WORKDIR /src
    COPY . .
    RUN dotnet restore ". BuySellApi/BuySellApi.csproj"
    WORKDIR "/src/BuySellApi"
    RUN dotnet build "BuySellApi.csproj" -c Release -o /app

    FROM build AS publish
    WORKDIR "/src/BuySellApi"
    RUN dotnet publish "BuySellApi.csproj" -c Release -o /app

    FROM base AS final
    WORKDIR /app
    COPY --from=publish /app .
    ENTRYPOINT ["dotnet", "BuySellApi.dll", "--server.urls", "http://0.0.0.0:5000"]