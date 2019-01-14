FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["ZhiKeCore.Web/ZhiKeCore.Web.csproj", "ZhiKeCore.Web/"]
COPY ["ZhiKeCore.EF/ZhiKeCore.EF.csproj", "ZhiKeCore.EF/"]
COPY ["ZhiKeCore.Models/ZhiKeCore.Models.csproj", "ZhiKeCore.Models/"]
RUN dotnet restore "ZhiKeCore.Web/ZhiKeCore.Web.csproj"
COPY . .
WORKDIR "/src/ZhiKeCore.Web"
RUN dotnet build "ZhiKeCore.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ZhiKeCore.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ZhiKeCore.Web.dll"]