# -----------------------------
# Build stage
# -----------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .
RUN dotnet publish src/MiniSocialApp/MiniSocialApp.csproj -c Release -o /app/publish

# -----------------------------
# Runtime stage
# -----------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Render expects port 10000
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MiniSocialApp.dll"]
