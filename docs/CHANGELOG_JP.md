- [English](../CHANGELOG.md)

# 変更点

## 1.2.0 (2022/05/10)

* POP10CI に対応
* SM-L200のBluetoothモジュール情報を新規追加
* React Native のバージョンを0.67.2に更新
* Android: StarDeviceDiscoveryManagerクラスを利用した際かつ、一部のプリンター(TSP100IIIBI、mPOP、mC-Print2/3、SM-L200/300)のBluetoothデバイス名が初期値の場合において、モデルを推定し取得できる仕様を追加
* Android: 不要な部分まで難読化されないように修正
* Windows: Microsoft Storeからインストールしたアプリにおいて、本ライブラリのいずれかのAPI呼び出しによりクラッシュする問題を修正

## 1.1.0 (2021/11/19)

* TSP100IV に対応
* React Native のバージョンを0.66に更新
* 使用するライブラリの更新
* 印刷速度の高速化
* TypeScript用の型定義ファイルを追加
* iOS: Xcode 13 に対応
* iOS: Apple Silicon Mac上のiOSシミュレーターに対応
* Android: JCenter廃止への対応
* 不具合修正
  * iOS
    * アプリ終了時にStarLoggerクラスがクラッシュする問題を修正
    * LANプリンター検索中にメモリ使用量が増加し続ける問題を修正
    * StarDeviceDiscoveryManagerクラスのstartDiscoveryメソッドが、検索開始後にネットワークに参加したプリンターを検出できない問題を修正
    * 実機