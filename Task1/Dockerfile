#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./Task1.csproj", "Task1/"]
RUN dotnet restore "Task1/Task1.csproj"
WORKDIR "/src/Task1"
COPY . .
RUN dotnet build "Task1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task1.csproj" -c Release -o /app/publish

FROM base AS final
ARG GIT_INFO
ARG BUILD_TIME
LABEL GIT_INFO=$GIT_INFO
LABEL BUILD_TIME=$BUILD_TIME
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task1.dll"]