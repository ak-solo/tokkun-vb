---
paths:
  - ".devcontainer/**"
---

# devcontainer（.devcontainer/）

## 含める環境

- .NET 10 SDK
- VSCode 拡張機能
  - `ms-dotnettools.vscode-dotnet-runtime`
  - `ms-dotnettools.vscode-dotnet-pack`

## 確認コマンド

```bash
dotnet --version                            # SDK の確認
dotnet test                                 # 全テストを実行
dotnet test tests/Chapter01.Tests          # 特定の章のみ
dotnet run --project playground/Chapter01  # プレイグラウンドを実行
```
