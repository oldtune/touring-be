#!/bin/zsh
dotnet ef database update --startup-project ./host/Touring.HttpApi.Host --project ./src/Touring.EntityFrameworkCore --context TouringDbContext