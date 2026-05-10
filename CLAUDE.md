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
| chapter02 | 引数と戻り値 | Function/Sub、引数、戻り値、文字列補間 |
| chapter03 | 分岐 | If/ElseIf/Else、Select Case、論理演算子 |
| chapter04 | 繰り返し | For/While/Do、ネスト、フィボナッチ、素因数分解 |
| chapter05 | 配列 | 1次元・2次元配列、For Each、ソート |
| chapter06 | メソッド | Sub/Function、引数、戻り値、ByRef |
| chapter07 | クラスⅠ | フィールド、プロパティ、コンストラクタ |
| chapter08 | クラスⅡ | 継承、オーバーライド、ポリモーフィズム |
| chapter09 | LINQ | Where、Select、OrderBy、GroupBy、クエリ構文 |

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
- コミットメッセージの先頭には必ず以下のプレフィックスを付ける

### プレフィックス一覧

| プレフィックス | 用途 |
|---|---|
| `feat:` | 新機能の追加 |
| `fix:` | バグ修正 |
| `docs:` | ドキュメントのみの変更 |
| `style:` | コードの見た目の変更（機能に影響しない空白・セミコロン等） |
| `refactor:` | バグ修正でも機能追加でもないコード変更（リファクタリング） |
| `chore:` | ビルド設定・ライブラリ更新・CI 設定など |

### 分割の例

| 悪い例（1コミット） | 良い例（分割） |
|---------------------|----------------|
| 問題追加 + テスト追加 + CLAUDE.md 更新 | ① 問題ファイル追加 ② テスト追加 ③ CLAUDE.md 更新 |
| バグ修正 + 新機能追加 | ① バグ修正 ② 新機能追加 |
