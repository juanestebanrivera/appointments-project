FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /build

COPY ["src/Appointments.Domain/Appointments.Domain.csproj", "src/Appointments.Domain/"]
COPY ["src/Appointments.Application/Appointments.Application.csproj", "src/Appointments.Application/"]
COPY ["src/Appointments.Infrastructure/Appointments.Infrastructure.csproj", "src/Appointments.Infrastructure/"]
COPY ["src/Appointments.Api/Appointments.Api.csproj", "src/Appointments.Api/"]

RUN dotnet restore "src/Appointments.Api/Appointments.Api.csproj"

COPY . .

WORKDIR "/build/src/Appointments.Api"

RUN dotnet build "Appointments.Api.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "Appointments.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false --no-restore

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Appointments.Api.dll"]
