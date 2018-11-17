<p align="center">
  <img
    src="logo.png"
    width="600"
    style="margin-top: 20px; margin-bottom: 20px;"
  />
</p>

- [English](../README.md)

# react-native-star-io10

`react-native-star-io10`はスター精密デバイス向けアプリケーション開発をサポートするライブラリです。

本ライブラリはStarXpand SDKに含まれます。

## 動作環境

| Platform | OS Version | Arch |
| --- | --- | --- |
| iOS | iOS 12.0 以降 | 実機: arm64<br> シミュレータ: x86_64, arm64 | 
| Android | Android 6.0 以降 | arm64-v8a, armeabi-v7a, x86, x86_64 |
| Windows | Windows 10 1909 以降 | x86, x64 |

## 導入

```
npm install react-native-star-io10 --save
```

### iOS
プリンターのインターフェースによって、必要な対応があります。  
下記表を確認し対応をしてください。

| プリンターのインターフェース  | 必要な対応                                                                                |
|--------------------------|-----------------------------------------------------------------------------------------|
| Bluetooth                | [1.](#SupportedEAProtocols) & [2.](#BluetoothAlwaysUsageDescription) & [4.](#MFi) |
| Bluetooth Low Energy     | [2.](#BluetoothAlwaysUsageDescription)                                                |
| Ethernet (iOS14以上)      | [3.](#LocalNetworkUsageDescription)                                                   |
| Lightning USB           | [1.](#SupportedEAProtocols) & [4.](#MFi)                                            |

<a id="SupportedEAProtocols"></a>
#### 1. `Supported external accessory protocols` 項目の設定

1. Information Property List（デフォルトでは"Info.plist"）を選択します。
2. Keyに `Supported external accessory protocols` を追加します。
3. 項目名左側の▽をクリックして表示される"Item 0"の[Value]に `jp.star-m.starpro` を設定します。

> :warning: 該当するプリンターを使用しない場合は、この設定を行わないでください。

<a id="BluetoothAlwaysUsageDescription"></a>
#### 2. `Bluetooth Always Usage Description` 項目および `Bluetooth Peripheral Usage Description` 項目の設定

1. Information Property List（デフォルトでは"Info.plist"）を選択します。
2. Keyに `Privacy – Bluetooth Always Usage Description` を追加します。
3. `Deployment Target` をiOS12に設定する場合、Keyに `Privacy – Bluetooth Peripheral Usage Description` を追加します。
3. それぞれのValue に Bluetoothの利用目的（例: `Use Bluetooth for communication with the printer.`）を設定します。
4. Bluetoothにてプリンターと通信するとき、Bluetoothへのアクセス許可を求めるダイアログが表示されます。その際、Valueに設定した文字列がBluetoothを利用する理由として表示されます。

より詳しくは、下記URLを参照してください。

https://developer.apple.com/documentation/bundleresources/information_property_list/nsbluetoothperipheralusagedescription

<a id="LocalNetworkUsageDescription"></a>
#### 3. `Local Network Usage Description` 項目の設定

1. Information Property List（デフォルトでは"Info.plist"）を選択します。
2. Keyに `Privacy - Local Network Usage Description` を追加します。
3. Value に Local Networkの利用目的（例: `Use Local Network for communication with the printer or discovery the printers.`）を設定します。
4. iOS14以上でEthernetプリンターと通信するとき、Local Networkへのアクセス許可を求めるダイアログが表示されます。その際、Valueに設定した文字列がLocal Networkを利用する理由として表示されます。

<a id="MFi"></a>
#### 4. MFi対応プリンター向けアプリ認証を取得

MFi認証プリンターに対応したiOSアプリケーションを設計・開発し、 Apple iTunes App Storeにアプリケーション登録を行う場合、下記のURLに記載の手順によりアプリ認証を取得してください。Appleによるアプリ審査前に完了しておく必要があります。

https://star-m.jp/products/s_print/apple_app_mfi/index.html

> :warning: Bluetooth Low Energyプリンターを使用する場合は、このアプリ認証を行う必要はありません。

### Android
#### targetSdkVersionを31以降に設定する場合
[サンプルコード](../example/samples)を参考にして、プリンターとの通信や検索を開始する前に、BLUETOOTH_CONNECTパーミッションを要求してください。

#### targetSdkVersionを30以前に設定する場合
`react-native-star-io10` ライブラリには、APIレベル 31にて追加されたBLUETOOTH_CONNECTパーミッションが含まれています。AndroidManifest.xmlに下記二つの設定を行い、BLUETOOTH_CONNECTパーミッションを削除してください。

* `manifest` 要素に `xmlns:tools="http://schemas.android.com/tools"` 属性を追加します。
* `<uses-permission android:name="android.permission.BLUETOOTH_CONNECT" tools:node="remove"/>` 要素を追加します。

```xml
<manifest
    xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:tools="http://schemas.android.com/tools"
    package="com.starmicronics.starxpandsdk">

    <uses-permission android:name="android.permission.BLUETOOTH_CONNECT" tools:node="remove"/>
    ...
</manifest>
```

### Windows
- 機能を`Package.appxmanifest`に追加してください。
  - Bluetooth
  - インターネット(クライアント)
  - プライベート ネットワーク (クライアントとサーバー)
- プロジェクトの「参照」に"Visual C++ 2015-2019 UWP Desktop Runt