FROM mcr.microsoft.com/devcontainers/dotnet:1-8.0

# .NET グローバルツールのパスを通す
ENV PATH="${PATH}:/home/vscode/.dotnet/tools"

# .NET Interactive（Polyglot Notebooks 用）をインストール
RUN su vscode -c "dotnet tool install --global Microsoft.dotnet-interactive"
