FROM mcr.microsoft.com/dotnet/sdk:9.0 AS builder

WORKDIR /backend

COPY . ./
RUN apt update

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS aspnet

WORKDIR /backend

COPY --from=builder /backend/out .

ENTRYPOINT ["dotnet", "backend.dll"]
