#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["CodeFirst.API/CodeFirst.API.csproj", "CodeFirst.API/"]
COPY ["CodeFirst.Models/CodeFirst.Models.csproj", "CodeFirst.Models/"]
RUN dotnet restore "CodeFirst.API/CodeFirst.API.csproj"
COPY . .
WORKDIR "/src/CodeFirst.API"
RUN dotnet build "CodeFirst.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CodeFirst.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CodeFirst.API.dll"]