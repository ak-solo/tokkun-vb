# tokkun-vb — VB.NET ハンズオン学習教材

## プロジェクト概要

VB.NET を題材にした初学者向けプログラミング学習教材。
「基礎説明 → 問題を解く → ユニットテストで自己検証 → プレイグラウンドで体験する」
というサイクルで、手を動かしながら学べることを目指す。

### 学習の流れ

```
1. docs/ の README（基礎説明 + 問題文）を読む
2. src/ の骨格コードに実装を書く
3. dotnet test でユニットテストを実行し、全テストが通るまで修正する
4. dotnet run --project playground/ChapterXX で動作を体感する
```

---

## ディレクトリ構成

```
tokkun-vb/
├── .devcontainer/
│   ├── devcontainer.json       # VSCode devcontainer 設定
│   └── Dockerfile
├── docs/
│   ├── chapter01.md            # 基礎説明 + 問題文（章ごと）
│   ├── chapter02.md
│   └── ...
├── src/
│   ├── Chapter01/
│   │   ├── Chapter01.vbproj
│   │   └── Exercises.vb        # 初学者が実装を書くファイル（骨格のみ）
│   ├── Chapter02/
│   └── ...
├── tests/
│   ├── Chapter01.Tests/
│   │   ├── Chapter01.Tests.vbproj
│   │   └── ExercisesTests.vb   # ユニットテスト（変更しない）
│   ├── Chapter02.Tests/
│   └── ...
├── playground/
│   ├── Chapter01/
│   │   ├── Chapter01.Playground.vbproj
│   │   └── Program.vb          # 値を変えながら実行できる実験用コード
│   ├── Chapter02/
│   └── ...
├── tokkun-vb.sln
└── CLAUDE.md
```

---

## 章の構成

| ファイル | 章タイトル | 主なトピック |
|---|---|---|
| chapter01 | 表示・変数・演算 | Console.WriteLine、変数、四則演算、累乗 |
| chapter02 | 入力 | Console.ReadLine、型変換、Integer.Parse |
| chapter03 | 分岐 | If/ElseIf/Else、Select Case、論理演算子 |
| chapter04 | 繰り返し | For/While/Do、ネスト、フィボナッチ、素因数分解 |
| chapter05 | 配列 | 1次元・2次元配列、For Each、ソート |
| chapter06 | メソッド | Sub/Function、引数、戻り値、ByRef |
| chapter07 | クラスⅠ | フィールド、プロパティ、コンストラクタ |
| chapter08 | クラスⅡ | 継承、オーバーライド、ポリモーフィズム |

---

## 実装設計の原則

### テスト可能な構造にする

コンソール I/O に依存する問題でも、**計算ロジックは引数・戻り値で表現できる関数**として切り出す。

```vbnet
' NG: テストできない
Sub Problem1_4()
    Dim x As Integer = 13 + 17
    Console.WriteLine(x)
End Sub

' OK: ロジックを関数に切り出す
Function Problem1_4() As Integer
    Return 13 + 17
End Function
```

入力が必要な問題（chapter02 以降）も、入力値を引数として受け取る形にする。

```vbnet
' NG: Console.ReadLine() をそのまま使う
Function Problem2_3() As String
    Dim x = Integer.Parse(Console.ReadLine())
    Return $"{x},{x^2},{x^3}"
End Function

' OK: 入力値を引数にする
Function Problem2_3(x As Integer) As String
    Return $"{x},{x ^ 2},{x ^ 3}"
End Function
```

### 表示系の問題

文字列を**返す** Function として実装し、Main から Console.WriteLine で出力する。
これにより、テストでは戻り値を Assert するだけでよくなる。

---

## ユニットテスト（tests/）

### テストフレームワーク

xUnit を使用する。テストプロジェクトに必要なパッケージ：

```xml
<PackageReference Include="xunit" Version="2.*" />
<PackageReference Include="xunit.runner.visualstudio" Version="2.*" />
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.*" />
```

### ファイル構成

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

### テスト作成ルール

- `Assert.True(True)` のような無意味なアサーションは書かない
- **`<Theory>` + `<InlineData>`** を活用し、境界値・典型値・エッジケースを複数検証する
- テスト名は「何の問題の、何を確認するか」が一目でわかるように書く
- テストコードは初学者が変更しない前提で書く（骨格側の関数シグネチャに合わせる）

### 初学者が行う作業

- `src/ChapterXX/Exercises.vb` の `Throw New NotImplementedException()` を削除し、実装を書く
- `dotnet test tests/ChapterXX.Tests` を実行して結果を確認する
- 全テストが緑になれば完了

---

## プレイグラウンド（playground/）

### 目的

- 引数を変えながら関数の動作を確認する「実験の場」
- テストとは別に、自分の実装が直感的に正しいか体感できる

### 実行方法

```bash
dotnet run --project playground/Chapter01   # Chapter01 を実行
dotnet run --project playground/Chapter02   # Chapter02 を実行
```

### ファイル構成

```vbnet
' playground/Chapter01/Program.vb

Module Program
    Sub Main()
        ' ===== 問題 1-1 〜 1-3: 文字列の表示 =====
        Console.WriteLine(Exercises.Problem1_1())

        ' ===== 問題 1-9: 倍数（x の値を変えて試してみよう）=====
        Dim x9 As Integer = 3   ' ← この値を変えて実行してみよう
        Dim r9 = Exercises.Problem1_9(x9)
        Console.WriteLine($"{x9} の 2 倍: {r9(0)}")
    End Sub
End Module
```

### プレイグラウンドの原則

- `Program.vb` の変数の値（コメントで `← 変えて試そう` と示した箇所）を書き換えて実行する
- `Module Program` / `Sub Main()` で囲む（VB.NET はトップレベルステートメント非対応）
- 同じ変数名が複数必要な場合はサフィックスで区別する（例: `x9`, `x10`, `x13`）

---

## 骨格コード（src/）

### ファイルの書き方

```vbnet
' src/Chapter01/Exercises.vb

Public Class Exercises

    ' 問題 1-1: "Hello World" を返す
    Public Shared Function Problem1_1() As String
        Throw New NotImplementedException("問題 1-1 を実装してください")
    End Function

    ' 問題 1-4: 13 と 17 の和を返す
    Public Shared Function Problem1_4() As Integer
        Throw New NotImplementedException("問題 1-4 を実装してください")
    End Function

End Class
```

### 骨格コードの原則

- 関数シグネチャ（名前・引数・戻り値の型）は変えない
- `Throw New NotImplementedException` をそのまま残す（テストが `NotImplementedException` で失敗するのが「Red」の状態）
- 問題のコメントに問題番号と概要を明記する
- 入力値を Console.ReadLine() から取ることは **しない**（引数で受け取る）

---

## devcontainer（.devcontainer/）

### 含める環境

- .NET 10 SDK
- VSCode 拡張機能
  - `ms-dotnettools.vscode-dotnet-runtime`
  - `ms-dotnettools.vscode-dotnet-pack`

### 確認コマンド

```bash
dotnet --version                            # SDK の確認
dotnet test                                 # 全テストを実行
dotnet test tests/Chapter01.Tests          # 特定の章のみ
dotnet run --project playground/Chapter01  # プレイグラウンドを実行
```

---

## docs/（問題文 + 基礎説明）

### 構成テンプレート

```markdown
# X章 章タイトル

## 基礎知識

[概念の説明]

## 構文例

[コードサンプル]

## 練習問題

### 問題 X-1

[問題文]

**ヒント:** [ヒント]

### 問題 X-2
...
```

---

## 命名規則

| 要素 | 規則 | 例 |
|---|---|---|
| 実装クラス | `Exercises` | `Public Class Exercises` |
| 関数名 | `Problem[章]-[番号]` + 補足 | `Problem1_4()`, `Problem1_9_Double()` |
| テストクラス | `Chapter[章番号]Tests` | `Chapter01Tests` |
| テストメソッド | `Test_[問題番号]_[説明]` | `Test_1_4_SumOf13And17` |
| プロジェクト | `ChapterXX` / `ChapterXX.Tests` / `ChapterXX.Playground` | `Chapter01`, `Chapter01.Tests`, `Chapter01.Playground` |

---

## 問題追加の手順

新しい問題・章を追加するときの手順：

1. `docs/chapterXX.md` に基礎説明と問題文を書く
2. `src/ChapterXX/Exercises.vb` に骨格関数（`NotImplementedException`）を追加する
3. `tests/ChapterXX.Tests/ExercisesTests.vb` にユニットテストを書く（複数の TestCase で検証）
4. `playground/ChapterXX/Program.vb` に実験用コードを追加する
5. `tokkun-vb.sln` にプロジェクトを追加する

---

## 制約・注意事項

- テストを通すためだけの**ハードコード**（`Return 30` など）は禁止。汎用的なロジックで実装すること
- 骨格コードの**関数シグネチャは変えない**（テストが壊れる）
- 入力は必ず**引数**で受け取る（Console.ReadLine() を関数内で使わない）
- Chapter01〜Chapter03 の問題は返り値ありの Function として設計する
- Chapter04 以降のループ・配列は、結果を返す形（配列・文字列など）で設計する

---

## Git コミット方針

- コミットは **変更理由（目的）ごとに分割**すること
- 1コミット = 1つの論理的な変更（機能追加・バグ修正・リファクタリングを混在させない）
- コミット前に変更内容を確認し、複数の目的が混在していれば必ず分割する
- ファイルをまとめて `git add .` せず、目的ごとに `git add <ファイル>` で個別にステージングすること
- コミットメッセージは「何をしたか」ではなく「**なぜ**その変更をしたか」を書く

### 分割の例

| 悪い例（1コミット） | 良い例（分割） |
|---------------------|----------------|
| 問題追加 + テスト追加 + CLAUDE.md 更新 | ① 問題ファイル追加 ② テスト追加 ③ CLAUDE.md 更新 |
| バグ修正 + 新機能追加 | ① バグ修正 ② 新機能追加 |
