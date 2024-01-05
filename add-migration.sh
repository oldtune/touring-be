#!/bin/zsh
dotnet ef migrations add $1 --startup-project ./src/Touring.EntityFrameworkCore --project ./src/Touring.EntityFrameworkCore --context TouringDbContext