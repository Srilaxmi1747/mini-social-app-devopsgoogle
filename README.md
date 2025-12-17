# Mini Social App – DevOps Google

This repository contains a **Mini Social Web Application** built using **ASP.NET Core MVC**
with a complete **CI/CD pipeline** and **automatic deployment to Google Cloud Run**.

## Application Features
- User Registration
- User Login
- Create Post
- View Feed (Mini Social Timeline)

## DevOps & Tools Used
- .NET 8 (ASP.NET Core MVC)
- xUnit (Unit Testing)
- Coverlet (Code Coverage)
- SonarCloud (Static Code Analysis)
- Docker (Containerization)
- GitHub Actions (CI/CD)
- Google Cloud Run (Auto Deployment)

## CI/CD Pipeline Flow
1. Code push to `main` branch
2. Restore & Build
3. Run Unit Tests + Coverage
4. SonarCloud Quality Gate
5. Docker Image Build
6. Push Image to Registry
7. Auto Deploy to Google Cloud Run

## How to Run Locally
```bash
dotnet restore
dotnet build
dotnet run
```

## Deployment
Deployment is fully automated via GitHub Actions.