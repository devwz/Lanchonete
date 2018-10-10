FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_ENVIRONMENT %environment%

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY *.sln ./
COPY ["Lanchonete/Lanchonete.csproj", "Lanchonete/"]
COPY ["Lanchonete.Core/Lanchonete.Core.csproj", "Lanchonete.Core/"]

RUN dotnet restore "Lanchonete/Lanchonete.csproj"
RUN dotnet restore "Lanchonete.Core/Lanchonete.Core.csproj"

COPY . .
WORKDIR /src/Lanchonete
RUN dotnet build "Lanchonete.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Lanchonete.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Lanchonete.dll"]