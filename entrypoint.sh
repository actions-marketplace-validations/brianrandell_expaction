#!/bin/sh -l
echo "Hello, Docker"
cd /app
echo "Run Docker"
dotnet restore
echo "Restored"
dotnet build
echo "Build"
dotnet run --project expaction -- --greeting "$GREETING"