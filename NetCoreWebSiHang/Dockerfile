FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["NetCoreWebSiHang/NetCoreWebSiHang.csproj", "NetCoreWebSiHang/"]
RUN dotnet restore "NetCoreWebSiHang/NetCoreWebSiHang.csproj"
COPY . .
WORKDIR "/src/NetCoreWebSiHang"
RUN dotnet build "NetCoreWebSiHang.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NetCoreWebSiHang.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NetCoreWebSiHang.dll"]