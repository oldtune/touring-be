#!/bin/zsh
dotnet ef migration add $1 --startup-project ./host/Touring.HttpApi.Hosting --project ./src/Touring.EntityFrameworkCore --context TouringDbContext