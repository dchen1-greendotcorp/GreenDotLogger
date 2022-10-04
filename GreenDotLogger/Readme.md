# GreenDot Application Insight Logger for .NET Apps


This is the .NET SDK for customize logger based on [Application Insights Logger](https://learn.microsoft.com/en-us/azure/azure-monitor/app/ilogger).

## NuGet packages
[GreenDotShares.Logger Package](https://github.com/dchen1-greendotcorp/GreenDotLogger/packages/1657549)
[Code Repo] (https://github.com/dchen1-greendotcorp/GreenDotLogger)

## using GreenDot Application Insight Logger

### 1. Install package ---(cmd) dotnet add [project name] package GreenDotLogger --version 1.0.1

### 2. Implement interface IMaskService, example HttpFunctionAppTest.MaskService, example [https://github.com/dchen1-greendotcorp/HttpFunctionAppLogTest]

### 3. appsettings.json include ApplicationInsights:ConnectionString

### 4. Registeration service, example HttpFunctionAppTest.Startup

### 5. Using logger, example HttpFunctionTest function provide three different ways to log

