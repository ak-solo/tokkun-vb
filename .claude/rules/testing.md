---
paths:
  - "tests/**/*.vb"
---

# ユニットテスト（tests/）

## テストフレームワーク

xUnit を使用する。テストプロジェクトに必要なパッケージ：

```xml
<PackageReference Include="xunit" Version="2.*" />
<PackageReference Include="xunit.runner.visualstudio" Version="2.*" />
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.*" />
```

## ファイル構成

```vbnet
' tests/Chapter01.Tests/ExercisesTests.vb

Imports Xunit

Public Class Chapter01Tests

    ' 命名規則: Test_[問題番号]_[何をテストするか]
    <Fact>
    Public Sub Test_1_4_SumOf13And17()
        Dim result = Exercises.Problem1_4()
        Assert.Equal(30, result)
    End Sub

    ' Theory + InlineData でパターンを網羅する
    <Theory>
    <InlineData(4, 8)>
    <InlineData(9, 18)>
    <InlineData(1, 2)>
    Public Sub Test_1_9_DoubledValue(x As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem1_9_Double(x))
    End Sub

End Class
```

## テスト作成ルール

- `Assert.True(True)` のような無意味なアサーションは書かない
- **`<Theory>` + `<InlineData>`** を活用し、境界値・典型値・エッジケースを複数検証する
- テスト名は「何の問題の、何を確認するか」が一目でわかるように書く
- テストコードは初学者が変更しない前提で書く（骨格側の関数シグネチャに合わせる）

## 初学者が行う作業

- `src/ChapterXX/Exercises.vb` の `Throw New NotImplementedException()` を削除し、実装を書く
- `dotnet test tests/ChapterXX.Tests` を実行して結果を確認する
- 全テストが緑になれば完了
