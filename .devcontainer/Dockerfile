FROM mcr.microsoft.com/dotnet/sdk:10.0

RUN apt-get update && apt-get install -y --no-install-recommends \
    git curl ca-certificates \
  && rm -rf /var/lib/apt/lists/*
