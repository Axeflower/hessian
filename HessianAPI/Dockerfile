FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["HessianAPI/HessianAPI.csproj", "HessianAPI/"]
RUN dotnet restore "HessianAPI/HessianAPI.csproj"
COPY . .
WORKDIR "/src/HessianAPI"
RUN dotnet build "HessianAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "HessianAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HessianAPI.dll"]