



FROM mcr.microsoft.com/dotnet/sdk:5.0-windowsservercore-ltsc2019 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY ./*.sln ./
COPY *.csproj .
RUN dotnet restore

# copy everything else and build app
COPY . WebApplication2
WORKDIR /source/WebApplication2
RUN dotnet publish -c release -o /app -r win-x64 --self-contained false --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019 AS runtime
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["WebApplication2"]


