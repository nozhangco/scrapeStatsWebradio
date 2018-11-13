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

1. Information Property List