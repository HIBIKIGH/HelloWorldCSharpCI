# Hello World of C# CI !

.net6のコンソールアプリケーションでのCIを組んでみるリポジトリ

## 環境

使うものは以下

- Visual Studio 2022 Community Edition

- .NET6

- MSTest

- GitHub Actions

- GitHub Releases

## やりたいこと

このリポジトリでやりたいことは以下

- ローカルで動くMSTestを使った自動テストを作成

- ローカルのテストマネージャでテスト実行ができる

- コードをリモートmainにコミットされると、Actionsでビルドとテストが動く

- テストまでOKだったら内容がマージされる

- テストまでOKだったら成果物がReleasesに配置される

## 参考になりそうなURL

[単体テストの概要 - Visual Studio (Windows) | Microsoft Learn](https://learn.microsoft.com/ja-jp/visualstudio/test/getting-started-with-unit-testing?view=vs-2022&tabs=dotnet%2Cmstest)

[MSTest と .NET による単体テスト C# - .NET | Microsoft Learn]([https://learn.microsoft.c](https://learn.microsoft.c)

[.NETでのビルドとテスト - GitHub Docs](https://docs.github.com/ja/actions/automating-builds-and-tests/building-and-testing-net)