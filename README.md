# Hello World of C# CI !

.net6のコンソールアプリケーションでのCIを組んでみるリポジトリ

# ステータスバッジ

※バッジは直接コミットを受けてCIを流したときのステータスしか追えてないのでプルリクでこけたり、こけたままマージしても赤くはならない。

[![dotnet package](https://github.com/HIBIKIGH/HelloWorldCSharpCI/actions/workflows/action.yml/badge.svg)](https://github.com/HIBIKIGH/HelloWorldCSharpCI/actions/workflows/action.yml)

## [![dotnet package](https://github.com/HIBIKIGH/HelloWorldCSharpCI/actions/workflows/action.yml/badge.svg?branch=master&event=pull_request_target)](https://github.com/HIBIKIGH/HelloWorldCSharpCI/actions/workflows/action.yml)

## 

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

[単体テストの基礎 - Visual Studio (Windows) | Microsoft Learn](https://learn.microsoft.com/ja-jp/visualstudio/test/unit-test-basics?view=vs-2022#create-unit-test-projects-and-test-methods-c)



[.NETでのビルドとテスト - GitHub Docs](https://docs.github.com/ja/actions/automating-builds-and-tests/building-and-testing-net)